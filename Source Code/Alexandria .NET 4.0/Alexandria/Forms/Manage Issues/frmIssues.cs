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
    public partial class frmIssues : Form
    {
        string MemID, MStatus, MType, BookID, BType, accFine; int BooksAllowed, MTi;

        public frmIssues()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            //Disclaimer
            if (txtMemID.Text == "") goto End;
            //Remove single & double quoteswhich cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }


            MemID = txtMemID.Text;

            //Get info about Member
            string sqlMem = string.Format("SELECT MType, Fine, MStatus FROM Member WHERE MemberID = '{0}'", MemID);
            OleDbCommand cmdMem = new OleDbCommand(sqlMem, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drMem = cmdMem.ExecuteReader();

            if (drMem.Read()) //If memeber is present
            {
                MStatus = drMem["MStatus"].ToString(); accFine = drMem["Fine"].ToString(); MType = drMem["MType"].ToString(); int NoBooks;

                //Disclaimers and Percautions

                //Check Membership Status
                if (MStatus == "Expired") { MessageBox.Show("Books cannot be lent to this Member since the membership has been expired.", "Membership Expired", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
                else if (MStatus == "Blocked") { MessageBox.Show("This Membership has been Blocked, maybe due to behavior or security reasons. Please take nessasary actions.", "MEMBER BLOCKED", MessageBoxButtons.OK, MessageBoxIcon.Warning); goto End; }

                // ALLOW TO PAY FINES FROM HERE ITSELF.
                if (accFine != "0") MessageBox.Show(string.Format("This member has {0}/- balance of unpaid fines in his account. These fines may be recieved now and/or new books can be recieved.", accFine), "Member has Fines", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MType == "Adult") MTi = 0; else if (MType == "Child") MTi = 1;

                //Count Number of books he borrowed

                string sqlNoBooks = string.Format("SELECT COUNT(BookID) as NoBooks FROM LendStatus WHERE MemberID = '{0}'", MemID);
                OleDbCommand cmdNoBooks = new OleDbCommand(sqlNoBooks, db.con); OleDbDataReader drNoBooks = cmdNoBooks.ExecuteReader();
                if (drNoBooks.Read()) NoBooks = int.Parse(drNoBooks["NoBooks"].ToString()); else NoBooks = 0;

                BooksAllowed = set.NoBooks[MTi] - NoBooks; // Set the no. of books he can borrow not.
                
                //Check Maximum books limit exceepded
                if (BooksAllowed <= 0) { MessageBox.Show(string.Format("This Member has borrowed {0}, the maximum number of books allowed for this type of membership. No more books can be Lent to this member.", set.NoBooks[MTi]), "Lending limit exceeded", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }

                //If all right show other controls
                        //Now Height 109
                btnSet.Enabled = txtMemID.Enabled = false; btnIssue.Enabled = txtBookID.Enabled = true; btnIssue.Visible = txtBookID.Visible = lblBookID.Visible = true;

            }
            else MessageBox.Show(string.Format("No Membership with Member Id '{0}' exists.", MemID), "Invalid Member ID", MessageBoxButtons.OK, MessageBoxIcon.Error);


        End: if(db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }


        private void btnIssue_Click(object sender, EventArgs e)
        {
            //Disclaimer
            if (BooksAllowed <= 0) { MessageBox.Show("This member has borrowed maximum number of books.", "Lending Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            if (txtBookID.Text == "") goto End;
            //Remove single & double quoteswhich cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }
            BookID = txtBookID.Text;

            //Check validity of BookID
            string sqlBookIDV = string.Format("SELECT TitleID FROM Book WHERE BookID = '{0}'", BookID);
            OleDbCommand cmdBookIDV = new OleDbCommand(sqlBookIDV, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drBookIDV = cmdBookIDV.ExecuteReader(); drBookIDV.Read();

            if (drBookIDV.HasRows) // If valid BookID
            {
                //Check Book Type
                string sqlBType = string.Format("SELECT BType FROM Title WHERE TitleID = '{0}'", drBookIDV["TitleID"]);
                OleDbCommand cmdBType = new OleDbCommand(sqlBType, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drBType = cmdBType.ExecuteReader(); drBType.Read(); BType = drBType["BType"].ToString();

                //Disclaim for invalid book Types
                if (BType == "Ref") {MessageBox.Show("This book is for reference only, not for borrowal", "Reference book", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End;}
                else if (BType == "ALend" && MTi == 1) { MessageBox.Show("Adult books cannot be borrowed using child memberships.", "Adult Book", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
                

                // Check Book Availability
                string sqlIsLentBook = string.Format("SELECT COUNT(BookID) as IsLentBook FROM LendStatus WHERE BookID = '{0}'", BookID);
                OleDbCommand cmdIsLentBook = new OleDbCommand(sqlIsLentBook, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drIsLentBook = cmdIsLentBook.ExecuteReader();

                if (drIsLentBook.Read() && drIsLentBook["IsLentBook"].ToString() != "0") { MessageBox.Show("This book has already been lent and not yet received. Receive the book before lending it again.", "Book Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
                //Book Available to lend

                //LEND THE BOOK. Log Lending to Database
                {
                    //Log to LendStatus
                    string sqlLendBook = string.Format("INSERT INTO LendStatus (BookID, MemberID, LendDate, Extend) VALUES ('{0}', '{1}', '{2}', 0)", BookID, MemID, DateTime.Now.ToString());
                    OleDbCommand cmdLendBook = new OleDbCommand(sqlLendBook, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                    cmdLendBook.ExecuteNonQuery();

                    //Log to Member Timesborrow
                    string sqlMemTB = string.Format("UPDATE Member SET TimesBorrow = TimesBorrow + 1 WHERE MemberID = '{0}'", MemID);
                    OleDbCommand cmdMemTB = new OleDbCommand(sqlMemTB, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                    cmdMemTB.ExecuteNonQuery();

                    //Log to Title Timesborrow
                    string TitleID = drBookIDV["TitleID"].ToString();
                    string sqlTitTB = string.Format("UPDATE Title SET TimesBorrowed = TimesBorrowed + 1 WHERE TitleID = '{0}'", TitleID);
                    OleDbCommand cmdTitTB = new OleDbCommand(sqlTitTB, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                    cmdTitTB.ExecuteNonQuery();

                }

                //Lending Successful
                MessageBox.Show("Book Lending has been recorded successfully", "Lending Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BooksAllowed = BooksAllowed - 1; txtBookID.Clear();

                //Block lending more books, if limits exceeds
                if (BooksAllowed == 0) { txtBookID.Enabled = btnIssue.Enabled = false; }
                
            }
            else MessageBox.Show(string.Format("No book with BookID '{0}' exists.", BookID), "Invalid BookID", MessageBoxButtons.OK, MessageBoxIcon.Error);



        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close(); frmIssues f = new frmIssues(); f.Show();
        }
    }
}
