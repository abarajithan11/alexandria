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
    public partial class frmRemBook : Form
    {
        bool IsValidID; string TitleID, BookID; int N, TotN; List<string> AvailBooks = new List<string>();

        public frmRemBook()
        {
            InitializeComponent();
        }

        private void btnRBook_Click(object sender, EventArgs e)
        {
            // Disclaimers
            if (txtBookID.Text == "") goto End;
            //Remove single & double quoteswhich cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }


            //Declarations
            BookID = txtBookID.Text;

            //Check Book Table
            string sqlBook = string.Format("SELECT TitleID FROM Book WHERE BookID = '{0}'", BookID);
            OleDbCommand cmdBook = new OleDbCommand(sqlBook, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drBook = cmdBook.ExecuteReader(); drBook.Read();

            //Disclaimer: If Invalid BookID
            if (drBook.HasRows) { IsValidID = true; TitleID = drBook["TitleID"].ToString(); } else { MessageBox.Show("Please enter a valid BookID", "Invalid BookID", MessageBoxButtons.OK, MessageBoxIcon.Error); IsValidID = false; goto End; }

            // Disclaimer for sure
            DialogResult sure = MessageBox.Show("Are you sure you want to remove this book? This cannot be undone.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sure == DialogResult.No) goto End;
            //If sure, continue
            txtTitleID.Clear();

            //Calling VisualBasic inputBox for Reason
            string Reason = Microsoft.VisualBasic.Interaction.InputBox("Please enter the reasons for this removal:", "Give Reasons");

            //Call method to delete book
            Methods m = new Methods();
            m.RemBook(BookID, Reason, true);

            //Success
            MessageBox.Show("Book has been removed and details of cash and reason have been logged successfully.", "Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBookID.Clear();


        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnRTitle_Click(object sender, EventArgs e)
        {
            // Disclaimers
            if (txtTitleID.Text == "" || cboxNo.Text == "") goto End;
            //Remove single & double quoteswhich cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }
            if (cboxNo.Text != "All")
            {
                bool isN = int.TryParse(cboxNo.Text, out N);
                if (isN == false) { MessageBox.Show("Enter a valid number for no. of books", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            }
            

            //Declarations
            TitleID = txtTitleID.Text;

            //Check Book Table
            string sqlTitle = string.Format("SELECT BookID FROM Book WHERE TitleID = '{0}'", TitleID);
            OleDbCommand cmdTitle = new OleDbCommand(sqlTitle, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drTitle = cmdTitle.ExecuteReader();

            //Disclaimer: If Invalid BookID
            if (drTitle.HasRows) { IsValidID = true; } else { MessageBox.Show("Please enter a valid TitleID", "Invalid TitleID", MessageBoxButtons.OK, MessageBoxIcon.Error); IsValidID = false; goto End; }

            //Count all books.
            string sqlBookCnt = string.Format("SELECT COUNT(BookID) AS BookCnt FROM Book WHERE TitleID = '{0}'", TitleID);
            OleDbCommand cmdBookCnt = new OleDbCommand(sqlBookCnt, db.con);
            OleDbDataReader drBookCnt = cmdBookCnt.ExecuteReader(); drBookCnt.Read();
            TotN = int.Parse(drBookCnt["BookCnt"].ToString());
            


            //Substract Lent Books
            while (drTitle.Read())
            {
                BookID = drTitle["BookID"].ToString();

                //Check each bookID in LendStatus
                string sqlLentD = string.Format("SELECT BookID FROM LendStatus WHERE BookID = '{0}'", BookID);
                OleDbCommand cmdLentD = new OleDbCommand(sqlLentD, db.con); 
                OleDbDataReader drLentD = cmdLentD.ExecuteReader();

                //If Lent, remove 
                if (drLentD.HasRows == false) AvailBooks.Add(BookID);
            
            }
            TotN = AvailBooks.Count;

            string ShowNo;
            if (TotN == 0) ShowNo = "no books"; else ShowNo = "only " + TotN.ToString() + " books";

            if (cboxNo.Text != "All" && TotN < N ) { MessageBox.Show(string.Format("There are {0} available to remove at the moment.", ShowNo), "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }

            // Disclaimer for sure
            DialogResult sure = MessageBox.Show("Are you sure you want to remove these books under this title? This cannot be undone.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sure == DialogResult.No) goto End;
            //If sure, continue


            //Calling VisualBasic inputBox for Reason
            string Reason = Microsoft.VisualBasic.Interaction.InputBox("Please enter the reasons for this removal:", "Give Reasons");

            if(cboxNo.Text == "All") // To remove all books under title
            {
                //Read Book table for all book IDs
                string sqlChkTitle = string.Format("SELECT BookID FROM Book WHERE TitleID = '{0}'", TitleID);
                OleDbCommand cmdChkTitle = new OleDbCommand(sqlChkTitle, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drChkTitle = cmdChkTitle.ExecuteReader();

                while (drChkTitle.Read())
                {
                    BookID = drChkTitle["BookID"].ToString();

                    //Call method to remove
                    Methods m = new Methods();
                    m.RemBook(BookID, Reason, false);
                }
                goto Success;
            }

            for(int i = 0; i < N; i++) 
            {
                //Call method to remove
                Methods m = new Methods();
                m.RemBook(AvailBooks[i], Reason, false);
            }


        Success:
            //Success

            string s;
        if (cboxNo.Text == "All") s = "All books have"; else if (cboxNo.Text == "1") s = N.ToString() + " Book has"; else s = N.ToString() + " Books have";
            MessageBox.Show(string.Format("{0} been removed and details of reason have been logged successfully.", s), "Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBookID.Clear(); txtTitleID.Clear(); cboxNo.Text = "";

        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }
    }
}
