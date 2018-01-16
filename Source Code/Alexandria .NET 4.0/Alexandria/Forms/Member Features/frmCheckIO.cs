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
    public partial class frmCheckIO : Form
    {
        //Declarations
        string MemID, accFine, BookID; double FineAll = 0;

        public frmCheckIO()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            //Disclaimer
            if (txtMemID.Text == "") goto End;
            //Remove single & double quoteswhich cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }


            MemID = txtMemID.Text;
            string sqlMemDD = string.Format("SELECT MStatus, Fine FROM Member WHERE MemberID = '{0}'", MemID);
            OleDbCommand cmdMemDD = new OleDbCommand(sqlMemDD, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drMemDD = cmdMemDD.ExecuteReader(); drMemDD.Read();

            //Disclaim
            if (!drMemDD.HasRows) { MessageBox.Show("Invalid Member ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            else if (drMemDD["MStatus"].ToString() == "Valid") goto Continue;
            else if (drMemDD["MStatus"].ToString() == "Expired") { MessageBox.Show("This membership has expired. You cannot use the library until you renew this membership.", "Membership Expired", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            else if (drMemDD["MStatus"].ToString() == "Blocked") { MessageBox.Show("This membership has been blocked. Please contact the Librarian for more details.", "Membership BLOCKED", MessageBoxButtons.OK, MessageBoxIcon.Warning); goto End; }
            else { MessageBox.Show("This Membership ID is invalid.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }

        Continue:
            {
                //Check for Account fines
                accFine = drMemDD["Fine"].ToString();
                if (accFine != "0") MessageBox.Show(string.Format("You have Rs. {0}/- of unpaid fines stored in your account. Please pay them as soon as possible", accFine), "You have fines", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Check LendStatus for Present Fines

                string sqlFineC = string.Format("SELECT BookID FROM LendStatus WHERE MemberID = '{0}'", MemID);
                OleDbCommand cmdFineC = new OleDbCommand(sqlFineC, db.con);
                OleDbDataReader drFineC = cmdFineC.ExecuteReader();

                while (drFineC.Read() && drFineC.HasRows)
                {
                    //Call Method to calculate present fines
                    BookID = drFineC["BookID"].ToString(); bool isBFine, IsBlocked; double Fine; int Days; DateTime iDate; int MTi;
                    Methods m = new Methods();
                    m.FindBookFine(BookID, out isBFine, out Fine, out Days, out iDate, out MemID, out IsBlocked, out MTi);
                    if (isBFine) FineAll = FineAll + Fine;
                }

                //Remind Present Fines
                if (FineAll != 0) MessageBox.Show(string.Format("You have Rs. {0}/- of fines to be paid for the books you've borrowed. Please return the books and pay the fines as soon as possible", FineAll), "You have fines", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Check whether last event was recorded.
                string sqlChk = string.Format("SELECT Event FROM CheckInOut WHERE MemberID = '{0}' ORDER BY CDate DESC", MemID);
                OleDbCommand cmdChk = new OleDbCommand(sqlChk, db.con);
                OleDbDataReader drChk = cmdChk.ExecuteReader(); drChk.Read();

                if (!drChk.HasRows || drChk["Event"].ToString() == "Out")
                {
                    //If last checkout was not recorded, mark it as NotRec
                    string sqlNotRec = string.Format("INSERT INTO CheckInOut (MemberID, Event) VALUES ('{0}', 'NotRec')", MemID);
                    OleDbCommand cmdNotRec = new OleDbCommand(sqlNotRec, db.con);
                    cmdNotRec.ExecuteNonQuery();
                }

                //Log CheckIn
                string sqlCin = string.Format("INSERT INTO CheckInOut (MemberID, Event, CDate) VALUES ('{0}', 'Out', '{1}')", MemID, DateTime.Now);
                OleDbCommand cmdCin = new OleDbCommand(sqlCin, db.con);
                cmdCin.ExecuteNonQuery();
                
                //Success
                MessageBox.Show("Thank you for visiting the library. Your departure has been logged. Please come again.", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Reset Form
                txtMemID.Clear();
            }


        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //Disclaimer
            if (txtMemID.Text == "") goto End;
            //Remove single & double quoteswhich cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }


            MemID = txtMemID.Text;
            string sqlMemDD = string.Format("SELECT MStatus, Fine FROM Member WHERE MemberID = '{0}'", MemID);
            OleDbCommand cmdMemDD = new OleDbCommand(sqlMemDD, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drMemDD = cmdMemDD.ExecuteReader(); drMemDD.Read();

            //Disclaim
            if(!drMemDD.HasRows) { MessageBox.Show("Invalid Member ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; } 
            else if (drMemDD["MStatus"].ToString() == "Valid") goto Continue;
            else if (drMemDD["MStatus"].ToString() == "Expired") { MessageBox.Show("This membership has expired. You cannot use the library until you renew this membership.", "Membership Expired", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            else if (drMemDD["MStatus"].ToString() == "Blocked") { MessageBox.Show("This membership has been blocked. Please contact the Librarian for more details.", "Membership BLOCKED", MessageBoxButtons.OK, MessageBoxIcon.Warning); goto End; }
            else { MessageBox.Show("This Membership ID is invalid.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            
            Continue: 
            {
                //Check for Account fines
                accFine = drMemDD["Fine"].ToString();
                if (accFine != "0") MessageBox.Show(string.Format("You have Rs. {0}/- of unpaid fines stored in your account. Please pay them as soon as possible", accFine), "You have fines", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Check LendStatus for Present Fines

                string sqlFineC = string.Format("SELECT BookID FROM LendStatus WHERE MemberID = '{0}'", MemID);
                OleDbCommand cmdFineC = new OleDbCommand(sqlFineC, db.con);
                OleDbDataReader drFineC = cmdFineC.ExecuteReader();

                while (drFineC.Read() && drFineC.HasRows)
                {
                    //Call Method to calculate present fines
                    BookID = drFineC["BookID"].ToString(); bool isBFine, isBlocked; double Fine; int Days ; DateTime iDate; int MTi;
                    Methods m = new Methods();
                    m.FindBookFine(BookID, out isBFine, out Fine, out Days, out iDate, out MemID, out isBlocked, out MTi);
                    if (isBFine) FineAll = FineAll + Fine;
                }

                //Remind Present Fines
                if (FineAll != 0) MessageBox.Show(string.Format("You have Rs. {0}/- of fines to be paid for the books you've borrowed. Please return the books and pay the fines as soon as possible", FineAll), "You have fines", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //Check whether last event was recorded.
                string sqlChk = string.Format("SELECT Event FROM CheckInOut WHERE MemberID = '{0}' ORDER BY CDate DESC", MemID);
                OleDbCommand cmdChk = new OleDbCommand(sqlChk, db.con); 
                OleDbDataReader drChk = cmdChk.ExecuteReader(); drChk.Read();

                if (!drChk.HasRows) { }
                else if (drChk["Event"].ToString() == "In")
                {
                    //If last checkout was not recorded, mark it as NotRec
                    string sqlNotRec = string.Format("INSERT INTO CheckInOut (MemberID, Event) VALUES ('{0}', 'NotRec')", MemID);
                    OleDbCommand cmdNotRec = new OleDbCommand(sqlNotRec, db.con); 
                    cmdNotRec.ExecuteNonQuery();
                }

                //Log CheckIn
                string sqlCin = string.Format("INSERT INTO CheckInOut (MemberID, Event, CDate) VALUES ('{0}', 'In', '{1}')", MemID, DateTime.Now);
                OleDbCommand cmdCin = new OleDbCommand(sqlCin, db.con); 
                cmdCin.ExecuteNonQuery();

                //Success
                MessageBox.Show("Welcome to the Library. Your arrival has been logged", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                //Reset Form
                txtMemID.Clear();
            }


        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void frmCheckIO_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.ColorTranslator.FromHtml("#f6ebd7");
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
