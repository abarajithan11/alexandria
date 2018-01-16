using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Alexandria
{
    public partial class frmMemNew : Form
    {
        // Common Variable Declaration.

        string MemID, FName, LName, MType, Guard, NIC, Addr, Work, TP, Email, Status;
        int MTi; DateTime DateJ, DoB; double Fine, fee;

        public frmMemNew()
        {
            InitializeComponent();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            // Disclaimers
             
            //Remove single & double quotes which cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox || c is RichTextBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); }}

            if (txtFName.Text == "" || txtLName.Text == "" || cboxType.Text == "" || txtAddr.Text == "" || txtNIC.Text == "" || txtWork.Text == "" || txtTP.Text == "" || txtDobDate.Text=="" || txtDobMon.Text == ""|| txtDobYear.Text == "" || txtDobDate.Text=="Date" || txtDobMon.Text == "Month"|| txtDobYear.Text == "Month")
            { MessageBox.Show("One or many of the required fields are left blank. Please fill them and try again", "Field(s) left blank", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            if (txtNIC.Text.Length != 10) { MessageBox.Show("NIC number invalid", "Invalid NIC", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            if (cboxType.Text == "Child Membership" && txtGuardian.Text == "") { MessageBox.Show("A guardian should be specified for a Child Member", "Specify Guardian", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            bool isDate = DateTime.TryParse((txtDobMon.Text + "/" + txtDobDate.Text + "/" + txtDobYear.Text), out DoB);
            if(!isDate) { MessageBox.Show("Date of Birth is invalid", "Invalid Date of Birth", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }

            //Declarations
            FName = txtFName.Text; LName = txtLName.Text; Guard = txtGuardian.Text; NIC = txtNIC.Text; Work = txtWork.Text; Addr = txtAddr.Text; TP = txtTP.Text; Email = txtEmail.Text; Status = "Valid";
            DateJ = DateTime.Today.Date; Fine = 0; 
            if (cboxType.Text == "Child Membership") MType = "Child"; else if (cboxType.Text == "Adult Membership") MType = "Adult";

            //Check age and type
            DateTime now = DateTime.Today;
            int age = now.Year - DoB.Year; if (DoB > now.AddYears(-age)) age--; 

            //Disclaim age and type
            if (age < set.AgeMin && MType == "Adult") { MessageBox.Show("This person is not old enough for an adult membership.", "Age not enough", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            if (age >= set.AgeMin && MType == "Child") { MessageBox.Show("This person is old enough for an adult membership. Therefore, child membership cannot be created", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }

            //Check for previous NIC, address and Blacklist
            string sqlDupl = string.Format("SELECT MemberID, FName, LName, MType, MStatus, NIC, Address, MWork, Email, TP FROM Member WHERE NIC = '{0}' OR Address = '{1}' OR MWork = '{2}' OR Email = '{3}' OR TP = '{4}'", NIC, Addr, Work, Email, TP); OleDbCommand cmdDupl = new OleDbCommand(sqlDupl, db.con);
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open(); OleDbDataReader drDupl = cmdDupl.ExecuteReader(); drDupl.Read();

            if (drDupl.HasRows && Email != "")
            {
                string tMemID = drDupl["MemberID"].ToString(), tMType = drDupl["MType"].ToString(), tFName = drDupl["FName"].ToString(), tLName = drDupl["LName"].ToString(), tNIC = drDupl["NIC"].ToString(), tStatus = drDupl["MStatus"].ToString(), tAddr = drDupl["Address"].ToString(), tMWork = drDupl["MWork"].ToString(), tEmail = drDupl["Email"].ToString(), tTP = drDupl["TP"].ToString();
                
                
                if (tStatus == "Blocked" && (tNIC == NIC || tEmail == Email) && MType == tMType) { MessageBox.Show(string.Format("A person with such personal credentials, MemberID '{0}' and in the name name: '{1} {2}' is blocked and marked in Blacklist, maybe due to book theft or any other illegal activity. \r\n\r\nPlease take nessasary actions.", tMemID, tFName, tLName), "Person in Blacklist", MessageBoxButtons.OK, MessageBoxIcon.Warning); goto End; }
                else if (tStatus == "Valid" && (tNIC == NIC || tEmail == Email) && MType == tMType && MType == "Adult") { MessageBox.Show(string.Format("This person is already a valid member in the library with the name: '{0} {1}'\r\n\r\nIf not, please change the personal credentials, such as Email or NIC number anew", tFName, tLName), "Valid member", MessageBoxButtons.OK, MessageBoxIcon.Warning); goto End; }
                else if (tStatus == "Expired" && (tNIC == NIC || tEmail == Email) && MType == tMType && MType == "Adult") { MessageBox.Show(string.Format("This person holds an expired membership with MemberID '{0}' in the library with the name: '{1} {2}'\r\n\r\nIf not, please change the personal credentials, such as Email or NIC number anew", tMemID, tFName, tLName), "Expired member", MessageBoxButtons.OK, MessageBoxIcon.Warning); goto End; }
                else if (tStatus == "Blocked" && (tAddr == Addr || tMWork == Work || tTP == TP)) { MessageBox.Show(string.Format("A person with these home address, work address or telephone number with MemberID '{0}' and in the name: '{1} {2}' is blocked and marked in Blacklist, maybe due to book theft or any other illegal activity. \r\n\r\nYou may inquire about the blocked member from this person. This person will be added as a Member", tMemID, tFName, tLName), "Person in Blacklist", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            
            }

            // Declaring MemID
            {
                string MaxID;

                // Getting the MaxID from DB
                string sqlMaxID = "SELECT MAX(MemberID) as MaxID, COUNT(MemberID) as CountID FROM Member"; OleDbCommand cmdMaxID = new OleDbCommand(sqlMaxID, db.con);
                if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open(); OleDbDataReader drMaxID = cmdMaxID.ExecuteReader(); drMaxID.Read(); 
                
                if (drMaxID["CountID"].ToString() != "0") 
                {
                    MaxID = drMaxID["MaxID"].ToString();
                    Methods meth = new Methods();
                    MemID = meth.NewID(MaxID);
                }
                else MemID = "M0001";

            }
            if (MType == "Child") MTi = 1; else MTi = 0;
            // Declarations End

            //Request paying
            fee = set.NewC[MTi];
            DialogResult receive = MessageBox.Show(string.Format("Rs. {0}/- should be received for creation of a new {1} membership. Receive the amount and continue.", fee, MType), "Receive Fees", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (receive == DialogResult.Cancel) goto End;

            // Adding Transaction details

            string sqlTrans = string.Format("INSERT INTO Cash (TDate, Amount, TDetail, Event) VALUES('{0}', {1}, '{2}', 'NewMem')", DateTime.Now.ToString(), fee, "MemberID = "+MemID);
            OleDbCommand cmdTrans = new OleDbCommand(sqlTrans, db.con);
            cmdTrans.ExecuteNonQuery();
            // Transactions added.

            // Add all to Relation 'Member' in DB.

            string sqlNew = string.Format("INSERT INTO Member (MemberID, FName, LName, MType, MStatus, DateJoined, Email, DateofBirth, TP, Guardian, NIC, Address, MWork) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')", MemID, FName, LName, MType, Status, DateJ.ToShortDateString(), Email, DoB.ToShortDateString(), TP, Guard, NIC, Addr, Work);
            OleDbCommand cmdNew = new OleDbCommand(sqlNew, db.con); cmdNew.ExecuteNonQuery();
            MessageBox.Show(string.Format("New Member '{0}' has been added successfully and transactions have been recorded.", MemID), "Adding Successful", MessageBoxButtons.OK, MessageBoxIcon.Information); // Message

            // Reset Form
            txtFName.Text = txtLName.Text = cboxType.Text = txtGuardian.Text = txtDobDate.Text = txtDobMon.Text = txtDobYear.Text = txtNIC.Text = txtAddr.Text = txtWork.Text = txtTP.Text = txtEmail.Text = "";


        End: if(db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }


        private void cboxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxType.SelectedIndex == 0) { txtGuardian.Visible = label9.Visible = true; lblLLNIC.Text = "Guardian's NIC"; }
            else if (cboxType.SelectedIndex == 1) { txtGuardian.Visible = label9.Visible = false; lblLLNIC.Text = "Member's NIC"; }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close(); frmMemNew f = new frmMemNew(); f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
