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
    public partial class frmReturnExt : Form
    {
        string BookID = "", MemID; double Price, AmountOnly, Amount, Fine, accFine; 

        public frmReturnExt()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {

            if (txtBookID.Text == "") goto End;
            //Remove single & double quoteswhich cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }

            BookID = txtBookID.Text;


            // Check Book Availability in LendStatus table
            string sqlIsLentBook = string.Format("SELECT COUNT(BookID) as IsLentBook FROM LendStatus WHERE BookID = '{0}'", BookID);
            OleDbCommand cmdIsLentBook = new OleDbCommand(sqlIsLentBook, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drIsLentBook = cmdIsLentBook.ExecuteReader();

            //If book is not present in Lent table
            drIsLentBook.Read(); 
            if (drIsLentBook["IsLentBook"].ToString() == "0")
            {
                // Check the ID in BookID table
                string sqlIsValid = string.Format("SELECT COUNT(BookID) as Books FROM Book WHERE BookID = '{0}'", BookID);
                OleDbCommand cmdIsValid = new OleDbCommand(sqlIsValid, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drIsValid = cmdIsValid.ExecuteReader();

                
                drIsValid.Read(); 
                if (drIsValid["Books"].ToString() == "0") // If BookID not present in Book Table, say Invalid ID
                { MessageBox.Show("No book with given BookID exists. Please enter a valid ID", "Invalid BookID", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
                
                else // If BookID present in Book table (and not in Lend Table), then book not lent.
                { MessageBox.Show("This book has not been lent or has been returned already.", "Book not Lent.", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            }

            //If book is present in Lent table, continue.
            btnSet.Enabled = txtBookID.Enabled = false; btnExtend.Visible = btnLoss.Visible = btnReset.Visible = btnReturn.Visible = true;

        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            Methods m = new Methods();

            // Decalre varibales and call method to check and calculate book fines 

            bool isBFine, IsBlocked; int Days; DateTime iDate; int MTi;
            m.FindBookFine(BookID, out isBFine, out Fine, out Days, out iDate, out MemID, out IsBlocked, out MTi);

            //Find Blocked Member
            if (IsBlocked) MessageBox.Show("This Membership has been Blocked, maybe due to behavior or security reasons. Please take nessasary actions.", "MEMBER BLOCKED", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //For member's fines in account
            accFine = 0; bool isFine = false;
            m.FindAccFines(MemID, ref isFine, ref accFine);

            //Tak actions for fines and non fines
            {
                if (isBFine) //If Fines [ideal date is passed]
                { 
                    
                    //Whether to pay today or later
                    DialogResult now = MessageBox.Show(string.Format("This Book should have been returned {0} day(s) ago. Now, Rs {1}/- should be paid as fine. \r\n\r\nFine amount can be received now or the amount will be added to Member's account and a notification will be raised when he uses his Membership again. \r\n\r\nHave you received the amount today?", Days, Fine), "Received the fine?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (now == DialogResult.Yes) // If paying today.
                    {
                        //Add details to Cash table

                        string sqlPayRem = string.Format("INSERT INTO Cash(Event, TDetail, TDate, Amount) VALUES ('FinePaid', '{0}', '{1}', '{2}')", string.Format("MemberID = {0} | BookID = {1}", MemID, BookID), DateTime.Now.ToString(), Fine);
                        OleDbCommand cmdPayRem = new OleDbCommand(sqlPayRem, db.con);
                        cmdPayRem.ExecuteNonQuery();

                        MessageBox.Show(string.Format("Transaction of fine amount of Rs.{0}/- has beeen successfully recorded.", Fine), "Transaction Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else // If to be paid later
                    {
                        //Add the fine amount to old account fines.

                        string sqlFineLater = string.Format("UPDATE Member SET Fine = Fine + {0} WHERE MemberID = '{1}'", Fine, MemID);
                        OleDbCommand cmdFineLater = new OleDbCommand(sqlFineLater, db.con);
                        cmdFineLater.ExecuteNonQuery();

                        MessageBox.Show(string.Format("Fine amount of Rs.{0}/- has beeen successfully added to Member's account to be received later.", Fine), "Fines successfully added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }          
                }

                else //If No fines, show message
                { MessageBox.Show("No fines will be charged for this return", "No Fines!", MessageBoxButtons.OK, MessageBoxIcon.Information); } 

            }
            // End taking actions on book fines


            //Check for Previous Account Fines Using Method FindAccFines
            {
                

                if (isFine) // If there's fine
                { 
                    //Ask whether to pay them today.
                    DialogResult accNow = MessageBox.Show(string.Format("The Member {0} has unpaid fines of Rs. {1} stored in his/her account. Would you like to receive them now too? \r\n\r\nIf yes, receive them and continue.", MemID, accFine), "Receive the unpaid fines?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (accNow == DialogResult.Yes) { m.PayAccFines(MemID, accFine); }
                }
            }

            //Remove record Book from LendStatus

            string sqlRemBook = string.Format("DELETE FROM LendStatus WHERE BookID = '{0}'", BookID);
            OleDbCommand cmdRemBook = new OleDbCommand(sqlRemBook, db.con);
            cmdRemBook.ExecuteNonQuery();

            //SUCCESS
            MessageBox.Show("Book return has been recorded successfully", "Book Return Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset Form
            Reset();

       
            End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();

            // Decalre varibales and call method to check and calculate book fines 

            bool isBFine, IsBlocked; int Days; DateTime iDate; int MTi;
            m.FindBookFine(BookID, out isBFine, out Fine, out Days, out iDate, out MemID, out IsBlocked, out MTi);
            
                            
            //Get the Extension detail from LendStatus relation
            string sqlLDetail = string.Format("SELECT Extend FROM LendStatus WHERE BookID = '{0}'", BookID);
            OleDbCommand cmdLDetail = new OleDbCommand(sqlLDetail, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drLDetail = cmdLDetail.ExecuteReader(); drLDetail.Read();

            //Alert Blocked Member
            if (IsBlocked) { MessageBox.Show("This Membership has been Blocked, maybe due to behavior or security reasons. Please take nessasary actions.", "MEMBER BLOCKED", MessageBoxButtons.OK, MessageBoxIcon.Warning); goto End; }

            //Disclaim for already Extended books.
            if (drLDetail["Extend"].ToString() == "-1") { MessageBox.Show("This issue has already been extended once. It cannot be extended again.", "Issue already extended", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }

            //Tak actions for fines and non fines
            {
                if (isBFine) //If Fines [ideal date is passed]
                    { MessageBox.Show(string.Format("This Book should've been returned {0} day(s) ago. Issues that have passed the return date cannot be extended.", Days), "Issue Cannot be Extended", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                
                // If No Fines
                else
                {
                    //Modify Days: Days allowed per book
                    //Modify extended ideal Date: Date to be returned + days allowed per book.
                    Days = set.Btime[MTi];
                    iDate = iDate.AddDays(Days);

                    string sqlExt = string.Format("UPDATE LendStatus SET Extend = -1, LendDate = '{0}' WHERE BookID = '{1}'", iDate, BookID);
                    OleDbCommand cmdExt = new OleDbCommand(sqlExt, db.con);
                    cmdExt.ExecuteNonQuery();

                    MessageBox.Show(string.Format("This issue has been successfully extended by {0} days, upto {1}.", Days, iDate.ToLongDateString()), "Extension SUccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            //Reset Form
            Reset();

        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnLoss_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Are you sure you want to mark this book as lost?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sure == DialogResult.No) goto End;

            //Get TitleID from Book table
            string sqlBook = string.Format("SELECT TitleID FROM Book WHERE BookID = '{0}'", BookID);
            OleDbCommand cmdBook = new OleDbCommand(sqlBook, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drBook = cmdBook.ExecuteReader(); drBook.Read();
            string TitleID = drBook["TitleID"].ToString();

            //Select Price from Title Table with BookID
            string sqlTitle = string.Format("SELECT Price FROM Title WHERE TitleID = '{0}'", TitleID);
            OleDbCommand cmdTitle = new OleDbCommand(sqlTitle, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drTitle = cmdTitle.ExecuteReader(); drTitle.Read();
            Price = double.Parse(drTitle["Price"].ToString());


            //Call method to find fines for this book & member Tyoe 
            bool isBFine, IsBlocked; double Fine; int Days; DateTime iDate; int MTi;
            Methods m = new Methods();
            m.FindBookFine(BookID, out isBFine, out Fine, out Days, out iDate, out MemID, out IsBlocked, out MTi);

            //Remove member from Blacklist by shaowing member details
            if (IsBlocked)
            {
                DialogResult black = MessageBox.Show("This Member was blocked due to possible book theft or other security reasons. Since the member pays for the lost book, do you want to check details to remove the member from blacklist?", "Remove from Blacklist?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (black == DialogResult.Yes)
                {
                    frmMemDetails n = new frmMemDetails(); n.txtMemID.Text = MemID; n.ShowDialog();
                }
            }
            //Calculate Amount: Amount = (Price x Defined Times) + Present fine.
            AmountOnly = (Price * set.LostBookTimes[MTi]); 
            Amount = AmountOnly + Fine;

            // If there's fine, receive the fine also.
            string FineText = ""; if(isBFine) { FineText = string.Format(" and fines of Rs. {0}/- ", Fine); }

            //Show messagebox and verify transaction
            DialogResult isok = MessageBox.Show(string.Format("This Book costs Rs. {0}/-.\r\n\r\nWith {1} times the price of the book{2}, amount to be paid in total is Rs. {3}/-. \r\n\r\nReceive the amount and press OK.", Price, set.LostBookTimes[MTi], FineText, Amount ), string.Format("Rs. {0}/- must be paid Now", Amount), MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (isok == DialogResult.Cancel) goto End;

            //If Okay, continue.

            if (isBFine)
            {
                //Add details of Pay Fine and Pay for book to Cash table
                string sqlPayFine = string.Format("INSERT INTO Cash (Event, TDetail, TDate, Amount) VALUES ('FinePaid', '{0}', '{1}', {2})", string.Format("BookID = {0} | MemberID = {1}", BookID, MemID), DateTime.Now.ToString(), Fine);
                OleDbCommand cmdPayFine = new OleDbCommand(sqlPayFine, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                cmdPayFine.ExecuteNonQuery();
            }

            string sqlRemCash = string.Format("INSERT INTO Cash (Event, TDetail, TDate, Amount) VALUES ('LostPaid', '{0}', '{1}', {2})", string.Format("MemberID = {0}", MemID), DateTime.Now.ToString(), AmountOnly);
            OleDbCommand cmdRemCash = new OleDbCommand(sqlRemCash, db.con);
            cmdRemCash.ExecuteNonQuery();

            //Call method to remove Book from database
            m.RemBook(BookID, string.Format("Book Lost and Paid by Member = {0}", MemID), false);

            //Success
            MessageBox.Show(string.Format("Transaction of fine amount of Rs.{0}/- has beeen successfully recorded and Book has been successfully removed.", Amount), "Transaction & Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Reset();



        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            this.Close(); frmReturnExt f = new frmReturnExt(); f.Show();
        }


    }
}
