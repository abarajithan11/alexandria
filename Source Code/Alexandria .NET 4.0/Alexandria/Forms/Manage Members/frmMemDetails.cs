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
    public partial class frmMemDetails : Form
    {
        // Common Variable Declaration.

        string MemID, NewMemID, FName, LName, FullDate, MType, Guard, NIC, Addr, Work, TP, Email, Status;
        int TimesBorrow, Renewed, MTi; DateTime DateJ, DateR, DoB; double Stars, fullStars, fee, Fine;


        public frmMemDetails()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            //Remove single & double quotes which cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox || c is RichTextBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }

            //Declare MemID based on Input Type
            if (cvar.InsertID && txtMemID.Text == "") { MemID = cvar.MemID; txtMemID.Text = MemID; } // If input from outside.
            else if (txtMemID.Text == "") goto End; // If Form opened anew.
            else MemID = txtMemID.Text; // If Value entered in textbox.

            //Access Database for Details
            string sqlMemD = string.Format("SELECT * FROM Member WHERE MemberID = '{0}'", MemID);
            OleDbCommand cmdMemD = new OleDbCommand(sqlMemD, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drMemD = cmdMemD.ExecuteReader();

            if (drMemD.Read())
            {
                txtMemID.Enabled = false; MakeWide(); //Make the form wider.

                txtFName.Text = drMemD["FName"].ToString();
                txtLName.Text = drMemD["LName"].ToString();
                txtAddr.Text = drMemD["Address"].ToString();
                txtEmail.Text = drMemD["Email"].ToString();
                txtGuardian.Text = drMemD["Guardian"].ToString();
                txtNIC.Text = drMemD["NIC"].ToString();
                txtTP.Text = drMemD["TP"].ToString();
                txtWork.Text = drMemD["MWork"].ToString();
                lblStatus.Text = drMemD["MStatus"].ToString();
                Fine = double.Parse(drMemD["Fine"].ToString());
                lblFine.Text = Fine.ToString() + "/-";
                lblRenew.Text = drMemD["Renewed"].ToString();
                Popul p = new Popul();
                TimesBorrow = int.Parse(drMemD["TimesBorrow"].ToString());

                if (Fine == 0) btnFine.Enabled = false; else btnFine.Enabled = true;

               
                DateTime now = DateTime.Today;
                DateTime Dob = DateTime.Parse(drMemD["DateOfBirth"].ToString());
                int age = now.Year - Dob.Year; if (Dob > now.AddYears(-age)) age--;
                lblAge.Text = age.ToString();

                MType = drMemD["MType"].ToString();
                if (MType == "Child") { cboxType.SelectedIndex = 0; lblLLg.Visible = txtGuardian.Visible = true; lblLLNic.Text = "Guardian's NIC"; }
                else if (MType == "Adult") { cboxType.SelectedIndex = 1; lblLLg.Visible = txtGuardian.Visible = false; lblLLNic.Text = "NIC Number"; cboxType.Enabled = false; }

                if (lblStatus.Text == "Blocked") btnBlack.Text = "Remove from Blacklist";
                else btnBlack.Text = "Add to Blacklist";

                //Split & Use Date of Birth
                string Fulldob = drMemD["DateOfBirth"].ToString();
                string[] DoBSpace = Fulldob.Split(' '); // Split Date from Time
                string[] DoBSlash = DoBSpace[0].Split('/'); // SpilitDate components

                txtDobMon.Text = DoBSlash[0]; txtDobDate.Text = DoBSlash[1]; txtDobYear.Text = DoBSlash[2];

                //Split & Use Date Joined
                DateJ = DateTime.Parse(drMemD["DateJoined"].ToString());
                FullDate = DateJ.ToString();
                string[] DateSpace = FullDate.Split(' '); // Split Date from Time
                string[] DateSlash = DateSpace[0].Split('/'); // SpilitDate components

                lblDate.Text = DateSlash[1] + "-" + DateSlash[0] + "-" + DateSlash[2];

                // To Retrive BookIDs

                string sqlBookID = string.Format("SELECT BookID FROM LendStatus WHERE MemberID = '{0}'", MemID);
                OleDbCommand cmdBookID = new OleDbCommand(sqlBookID, db.con); OleDbDataReader drBookID = cmdBookID.ExecuteReader();

                while (drBookID.Read()) // For Each bookID
                {
                    string BookID = drBookID["BookID"].ToString();

                    string sqlBook = string.Format("SELECT TitleID FROM Book WHERE BookID = '{0}'", BookID); //Get TitleID from BookID
                    OleDbCommand cmdBook = new OleDbCommand(sqlBook, db.con); OleDbDataReader drBook = cmdBook.ExecuteReader();

                    if (drBook.Read())
                    {
                        string TitleID = drBook["TitleID"].ToString(); 
                        
                        string sqlTitle = string.Format("SELECT BTitle, Author, Genre FROM Title WHERE TitleID = '{0}'", TitleID); // Get Title info from TitleID
                        OleDbCommand cmdTitle = new OleDbCommand(sqlTitle, db.con); OleDbDataReader drTitle = cmdTitle.ExecuteReader();

                        if (drTitle.Read()) { lboxBookID.Items.Add(BookID); lboxTitle.Items.Add(drTitle["BTitle"].ToString()); lboxAuthor.Items.Add(drTitle["Author"].ToString()); lboxGenre.Items.Add(drTitle["Genre"].ToString()); }
                    }
                }

                //To Get last Check In

                string sqlCheckIn = string.Format("SELECT Max(CDate) as MaxCheckIn FROM CheckInOut WHERE MemberID = '{0}' AND EVENT = 'In' GROUP BY MemberID, Event", MemID);
                OleDbCommand cmdCheckIn = new OleDbCommand(sqlCheckIn, db.con); OleDbDataReader drCheckIn = cmdCheckIn.ExecuteReader();

                if (drCheckIn.Read() & drCheckIn.HasRows) { DateTime CheckIn = DateTime.Parse(drCheckIn["MaxCheckIn"].ToString()); lblCheckIn.Text = CheckIn.ToString("dd-MM-yyyy"); }
                
                    

                //Calculate Recent Star Points Via method & Display
                Popul star = new Popul();
                fullStars = star.MemCalc(MemID, false);
                Stars = double.Parse(Math.Round(decimal.Parse(fullStars.ToString()), 2).ToString());
                lblStars.Text = Stars.ToString();
                
                btnGet.Enabled = false;

            }
            else MessageBox.Show("MemberID does not match with any of the members. Try again", "Invalid MemberID", MessageBoxButtons.OK, MessageBoxIcon.Error);

            cvar.MemID = ""; cvar.InsertID = false;
            if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
            

        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            //Verify
            DialogResult one = MessageBox.Show(string.Format("Are you sure you want to update these details to the member '{0}'?", MemID), "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(one ==DialogResult.No) goto End;

            // Disclaimers

            //Remove single & double quotes which cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox || c is RichTextBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }

            if (txtFName.Text == "" || txtLName.Text == "" || txtAddr.Text == "" || txtNIC.Text == "" || txtWork.Text == "" || txtTP.Text == "" || txtDobDate.Text == "" || txtDobMon.Text == "" || txtDobYear.Text == "" || txtDobDate.Text == "Date" || txtDobMon.Text == "Month" || txtDobYear.Text == "Month")
            { MessageBox.Show("One or many of the required fields are left blank. Please fill them and try again", "Field(s) left blank", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            if (txtNIC.Text.Length != 10) { MessageBox.Show("NIC number invalid", "Invalid NIC", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            if ((MType == "Child" && cboxType.Text == "Adult Member") || (MType == "Adult" && cboxType.Text == "Child Member")) { MessageBox.Show("Member type cannot be changed", "Can't change member type", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; } 
            if (cboxType.Text == "Child Member" && txtGuardian.Text == "") { MessageBox.Show("A guardian must be specified for a child member.", "Specify Guardian", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            

            // Disclaimers End

            //Declarations
            FName = txtFName.Text; LName = txtLName.Text; Guard = txtGuardian.Text; NIC = txtNIC.Text; Work = txtWork.Text; Addr = txtAddr.Text; TP = txtTP.Text; Email = txtEmail.Text; Status = "Valid";
            Fine = 0; DoB = DateTime.Parse(txtDobMon.Text + "/" + txtDobDate.Text + "/" + txtDobYear.Text);

            // Declarations End

            // Update all to Relation 'Member' in DB.

            string sqlUpd = string.Format("UPDATE Member SET FName ='{0}', LName ='{1}', Email ='{2}', DateofBirth ='{3}', TP ='{4}', Guardian ='{5}', NIC ='{6}', Address ='{7}', MWork ='{8}' WHERE MemberID = '{9}'", FName, LName, Email, DoB.ToShortDateString(), TP, Guard, NIC, Addr, Work, MemID);
            OleDbCommand cmdUpd = new OleDbCommand(sqlUpd, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open(); cmdUpd.ExecuteNonQuery();
            MessageBox.Show(string.Format("Details of Member({0}) have been updated successfully", MemID), "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information); // Message

            // Reset Form
            Reset();

            End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            //Remove single & double quotes which cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox || c is RichTextBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }

            
            // Check if any books borrowed
            DialogResult two = MessageBox.Show("Are you sure you want to renew this membership?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (two == DialogResult.No) goto End;
            if (lboxBookID.Items.Count != 0 || lblFine.Text != "0/-") { MessageBox.Show("The books borrowed by the member must be returned and all fines should be paid before attempting a membership renewal", "Return books and pay fines", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            if (txtFName.Text == "" || txtLName.Text == "" || cboxType.Text == "" || txtAddr.Text == "" || txtNIC.Text == "" || txtWork.Text == "" || txtTP.Text == "" || txtDobDate.Text == "" || txtDobMon.Text == "" || txtDobYear.Text == "" || txtDobDate.Text == "Date" || txtDobMon.Text == "Month" || txtDobYear.Text == "Month")
            { MessageBox.Show("One or many of the required fields are left blank. Please fill them and try again", "Field(s) left blank", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            if (txtNIC.Text.Length != 10) { MessageBox.Show("NIC number invalid", "Invalid NIC", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            if (cboxType.Text == "Child Membership" && txtGuardian.Text == "") { MessageBox.Show("A guardian should be specified for a Child Member", "Specify Guardian", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            bool isDate = DateTime.TryParse((txtDobMon.Text + "/" + txtDobDate.Text + "/" + txtDobYear.Text), out DoB);
            if (!isDate) { MessageBox.Show("Date of Birth is invalid", "Invalid Date of Birth", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }


            if (lblStatus.Text == "Valid")
            {
                DialogResult one = MessageBox.Show("The membership is not yet expired. Beginning of new membership will be calculated from the end of present membership. Do you want to continue?", "Membership still valid", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (one == DialogResult.No) goto End;
            }
            DateR = DateTime.Now;

            if (lblStatus.Text == "Blocked") { MessageBox.Show("This member is blocked and marked in Blacklist, maybe due to book theft or any other illegal activity. This membership cannot be renewed. \r\n\r\nPlease take nessasary actions.", "Member in Blacklist", MessageBoxButtons.OK, MessageBoxIcon.Warning); goto End; }
            // Disclaimers End


            //Declarations
            FName = txtFName.Text; LName = txtLName.Text; Guard = txtGuardian.Text; NIC = txtNIC.Text; Work = txtWork.Text; Addr = txtAddr.Text; TP = txtTP.Text; Email = txtEmail.Text; Status = "Valid";
            Fine = 0; DoB = DateTime.Parse(txtDobMon.Text + "/" + txtDobDate.Text + "/" + txtDobYear.Text); Popul p = new Popul(); Stars = p.MemCalc(MemID, false);
            if (cboxType.Text == "Child Member") MType = "Child"; else if (cboxType.Text == "Adult Member") MType = "Adult";

            if (lblStatus.Text == "Valid") DateR = DateJ.AddMonths(set.Expire[MTi]);
            
            //Check age and type
            DateTime now = DateTime.Today;
            int age = now.Year - DoB.Year; if (DoB > now.AddYears(-age)) age--;

            if (age >= set.AgeMin && MType == "Child")
            {
                DialogResult r = MessageBox.Show("This Child member is now old enough to be an Adult Member. Continue creating an adult membership?", "Adult Member", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes) { MType = "Adult"; cboxType.Text = "Adult Member"; } else goto End;
            }
            if (MType == "Child") MTi = 0; else MTi = 1;

            Renewed = int.Parse(lblRenew.Text) + 1;

            // Declaring MemID
            {
                string MaxID;

                // Getting the MaxID from DB
                string sqlMaxID = "SELECT MAX(MemberID) as MaxID FROM Member"; OleDbCommand cmdMaxID = new OleDbCommand(sqlMaxID, db.con);
                if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open(); OleDbDataReader drMaxID = cmdMaxID.ExecuteReader();
                if (drMaxID.Read()) MaxID = drMaxID["MaxID"].ToString().Substring(1, 4); else goto End;

                // Increment MaxID to PresentID
                int iID = int.Parse(MaxID) + 1;
                string sID = iID.ToString();

                //Loop to add enough zeros for the 5-character format (M0001)

                for (int i = sID.Length; i != 4; i++) { sID = "0" + sID; }
                NewMemID = "M" + sID;
            }
            // Declarations End

            //Request paying
            
            fee = set.NewC[MTi];
            DialogResult receive = MessageBox.Show(string.Format("Rs. {0}/- should be received for renewal of a {1} membership. Receive the amount and continue.", fee, MType), "Receive Fees", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (receive == DialogResult.Cancel) goto End;

            // Adding Transaction details

            string sqlTrans = string.Format("INSERT INTO Cash (TDate, Amount, TDetail, Event) VALUES('{0}', {1}, '{2}', 'RenewMem')", DateTime.Now.ToString(), fee, "MemberID = " + MemID);
            OleDbCommand cmdTrans = new OleDbCommand(sqlTrans, db.con);
            cmdTrans.ExecuteNonQuery();
            // Transactions added.

            // Add all to Relation 'Member' in DB.

            string sqlNew = string.Format("INSERT INTO Member (MemberID, FName, LName, MType, MStatus, DateJoined, Email, DateofBirth, TP, Guardian, NIC, Address, MWork, Renewed, TimesBorrow, Stars) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', {13}, {14}, {15})", NewMemID, FName, LName, MType, Status, DateR.ToShortDateString(), Email, DoB.ToShortDateString(), TP, Guard, NIC, Addr, Work, Renewed, TimesBorrow, Stars);
            OleDbCommand cmdNew = new OleDbCommand(sqlNew, db.con); cmdNew.ExecuteNonQuery();

            //Delete Old Member
            string sqlDel = string.Format("DELETE FROM Member WHERE MemberID = '{0}'", MemID);
            OleDbCommand cmdDel = new OleDbCommand(sqlDel, db.con); cmdDel.ExecuteNonQuery();

            MessageBox.Show(string.Format("Membership of Member({0}) has been successfully renewed as ID '{1}'", MemID, NewMemID), "Renewal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information); // Message

            // Reset Form
            Reset();




        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            //Remove single & double quotes which cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox || c is RichTextBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }            
            if (btnBlack.Text == "Add to Blacklist")
            {
                DialogResult r = MessageBox.Show("Do you really want to block this member and add to blacklist? \r\n\r\nAn alert will be raised when this member uses the library again.", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    string sqlBlack = string.Format("UPDATE Member SET MStatus = 'Blocked' WHERE MemberID = '{0}'", MemID);
                    OleDbCommand cmdBlack = new OleDbCommand(sqlBlack, db.con);
                    if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                    cmdBlack.ExecuteNonQuery();

                    //Remove taken books if stolen
                    Methods m = new Methods();
                    if(lboxBookID.Items.Count !=0)
                    {
                    DialogResult b = MessageBox.Show("This member has not returned some books. Do you want to mark them stolen and remove from library?", "Remove books", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (b == DialogResult.Yes)
                    {
                        //Pass to method in loop
                        for (int i = 0; i < lboxBookID.Items.Count; i++)
                        {
                            string BookID = lboxBookID.Items[i].ToString();
                            m.RemBook(BookID, string.Format("Stolen by MemberID = {0}", MemID), false);
                        }
                    }
                    }


                    MessageBox.Show("Member has been added to blacklist successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }

            }
            else if (btnBlack.Text == "Remove from Blacklist")
            {
                DialogResult r = MessageBox.Show("Do you really want to unblock this member and remove from blacklist?", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    if (MType == "Child") MTi = 1; else MTi = 0;
                    DateTime DJ = DateTime.Parse(FullDate).AddMonths(set.Expire[MTi]);

                    if (DJ.CompareTo(DateTime.Today) < 0) { MessageBox.Show("This membership has expired and will be marked as expired", "Expired Membership"); Status = lblStatus.Text = "Expired"; }
                    else Status = lblStatus.Text = "Valid";

                    string sqlBlack = string.Format("UPDATE Member SET MStatus = '{0}' WHERE MemberID = '{1}'", Status, MemID);
                    OleDbCommand cmdBlack = new OleDbCommand(sqlBlack, db.con);
                    if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                    cmdBlack.ExecuteNonQuery();

                    MessageBox.Show("Member has been removed from blacklist successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }

            }
            else { }

        if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnFine_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            m.PayAccFines(MemID, Fine);
            lblFine.Text = "0/-"; btnFine.Enabled = false;
        }

        private void lboxBookID_DoubleClick(object sender, EventArgs e)
        {
            frmBookDetail f = new frmBookDetail();
            f.txtBookID.Text = lboxBookID.Items[lboxBookID.SelectedIndex].ToString();
            f.btnGetBook_Click(sender, e);
            f.ShowDialog();
        }

        private void lboxTitle_DoubleClick(object sender, EventArgs e)
        {
            frmBookDetail f = new frmBookDetail();
            f.txtBookID.Text = lboxBookID.Items[lboxTitle.SelectedIndex].ToString();
            f.btnGetBook_Click(sender, e);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Remove single & double quotes which cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox || c is RichTextBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }

            
            DialogResult r = MessageBox.Show("Do you really want to remove this member? \r\n\r\nThis action cannot be undone.", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                string Isrembook = "";

                //Check for lent books
                if (lboxBookID.Items.Count != 0)
                {
                    DialogResult b = MessageBox.Show("This member has not returned few books. Do you want to mark them as returned?", "Return Books", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (b == DialogResult.Yes)
                    {
                        Methods m = new Methods();

                        //Pass to method in loop
                        for (int i = 0; i < lboxBookID.Items.Count; i++)
                        {
                            string BookID = lboxBookID.Items[i].ToString();
                            string sqlRemBook = string.Format("DELETE FROM LendStatus WHERE BookID = '{0}'", BookID);
                            OleDbCommand cmdRemBook = new OleDbCommand(sqlRemBook, db.con);
                            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                            cmdRemBook.ExecuteNonQuery();
                        }
                        Isrembook = " and all the books borrowed have been marked as returned.";
                    }
                    else goto End;
                }
                    string sqlRem = string.Format("DELETE FROM Member WHERE MemberID = '{0}'", MemID);

                    OleDbCommand cmdRem = new OleDbCommand(sqlRem, db.con);
                    if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                    cmdRem.ExecuteNonQuery();
                
                MessageBox.Show(string.Format("Member has been removed successfully", Isrembook), "Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void Reset()
        {
            this.Close();
            frmMemDetails f = new frmMemDetails();
            f.Show();
        }

        private void frmMemDetails_Load(object sender, EventArgs e)
        {
            if (txtMemID.Text == "") this.Width = 218;
            else btnGet_Click(sender, e);
        }

        private void MakeWide()
        { this.Width = 1055; }

        private void lboxBookID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxBookID.SelectedItems.Count != 0)
            {
                frmBookDetail b = new frmBookDetail(); b.txtBookID.Text = lboxBookID.Items[lboxBookID.SelectedIndex].ToString(); b.btnGetBook_Click(sender, e); b.ShowDialog();
            }
        }

    }
}
