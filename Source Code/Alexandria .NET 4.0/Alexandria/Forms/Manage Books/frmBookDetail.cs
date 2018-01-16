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
    public partial class frmBookDetail : Form
    {
        //Common Variable Decalartions
        string TitleID, BookID, Title, Author, Genre, Publish, Pg, ISBN, Ty, Price, Popul, Times;
        //Declare specific variables
        int NoAvail = 0; string NoBooks; bool IsValidID;
        

        public frmBookDetail()
        {
            InitializeComponent();
        }

        public void btnGetTitle_Click(object sender, EventArgs e)
        {
            //Disclaimers
            if (txtTitleID.Text == "") goto End; TitleID = txtTitleID.Text;
            //Remove single & double quoteswhich cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }


            //Call method
            FillTitleInfo(TitleID);

            btnRemBook.Enabled = false;
        End: ;
        }

        public void FillTitleInfo(string TitleID)
        {
            

            //Call Method for details.
            Methods m = new Methods();
            m.TitleInfo(TitleID, out IsValidID, out Title, out Author, out Genre, out Publish, out Pg, out ISBN, out Ty, out Price, out Popul, out Times, out NoAvail, out NoBooks);

            //Disclaimer: If Invalid TitleID
            if (IsValidID == false) { MessageBox.Show("No Title exist with the given TitleID", "Invalid Title ID", MessageBoxButtons.OK, MessageBoxIcon.Error); txtTitleID.Clear(); goto End; }
            //If valid, continue

            //Modify the form
            lblLLAvail.Visible = lblLLLentTo.Visible = lblLLLentOn.Visible = lblLLFine.Visible = lblAvail.Visible = lblLentTo.Visible = lblLentOn.Visible = lblFine.Visible = false;
            txtBookID.Clear(); txtBookID.Enabled = txtTitleID.Enabled = btnGetTitle.Visible = btnGetBook.Visible = false;
            MakeTaller();

            //Display all details
            lblTitle.Text = Title;
            lblAuthor.Text = Author;
            lblGenre.Text = Genre;
            lblPublish.Text = Publish;
            lblPg.Text = Pg;
            lblISBN.Text = ISBN;
            lblTy.Text = Ty;
            lblPrice.Text = Price;
            lblPop.Text = Popul;
            lblTimes.Text = Times;
            lblNoBooks.Text = NoBooks;
            lblAvNo.Text = NoAvail.ToString();


        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void frmBookDetail_Load(object sender, EventArgs e)
        {
           if (txtBookID.Text == "" && txtTitleID.Text == "") this.Height = 186;
        }

        public void btnGetBook_Click(object sender, EventArgs e)
        {
            // Disclaimers
            if (txtBookID.Text == "") goto End;
            //Remove single & double quoteswhich cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }


            //Declarations
            string Avail, BookID, MemID; DateTime LendD; double Fine; 
            BookID = txtBookID.Text;

            //Get Details from Book Table
            string sqlBook = string.Format("SELECT TitleID FROM Book WHERE BookID = '{0}'", BookID);
            OleDbCommand cmdBook = new OleDbCommand(sqlBook, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drBook = cmdBook.ExecuteReader(); drBook.Read();

            //Disclaimer: If Invalid BookID
            if (drBook.HasRows) { IsValidID = true; TitleID = drBook["TitleID"].ToString(); } else { MessageBox.Show("No Book exist with the given BookID", "Invalid BookID", MessageBoxButtons.OK, MessageBoxIcon.Error); IsValidID = false; txtBookID.Clear(); goto End; }

            //Call Method for details.
            Methods m = new Methods();
            m.TitleInfo(TitleID, out IsValidID, out Title, out Author, out Genre, out Publish, out Pg, out ISBN, out Ty, out Price, out Popul, out Times, out NoAvail, out NoBooks);

            //Error Handling
            if (IsValidID == false) { MessageBox.Show("Some Error Occured"); goto End; }

            //Get Lend Details from lendStatus
            string sqlLendD = string.Format("SELECT * FROM LendStatus WHERE BookID = '{0}'", BookID);
            OleDbCommand cmdLendD = new OleDbCommand(sqlLendD, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drLendD = cmdLendD.ExecuteReader(); drLendD.Read();

            if (drLendD.HasRows) // If lent
            {
                //Call method to calculate fines
                bool isBFine, IsBlocked; int Days; DateTime iDate; int MTi;
                m.FindBookFine(BookID, out isBFine, out  Fine, out  Days, out  iDate, out  MemID, out IsBlocked, out MTi);

                //Load into variables
                MemID = drLendD["MemberID"].ToString();
                Avail = "Lent";
                LendD = DateTime.Parse(drLendD["LendDate"].ToString());

                //Show details
                lblLentTo.Text = MemID;
                lblLentOn.Text = LendD.ToString("dd MMMM yyyy");
                lblFine.Text = Fine.ToString();

            }
            else
            {
                Avail = "Available";

                //Modify Form
                lblLLFine.Visible = lblLLLentOn.Visible = lblLLLentTo.Visible = lblFine.Visible = lblLentOn.Visible = lblLentTo.Visible = false;
            }

            //Display all details

            lblTitle.Text = Title;
            lblAuthor.Text = Author;
            lblGenre.Text = Genre;
            lblPublish.Text = Publish;
            lblPg.Text = Pg;
            lblISBN.Text = ISBN;
            lblTy.Text = Ty;
            lblPrice.Text = Price;
            lblPop.Text = Popul;
            lblAvail.Text = Avail;

            btnRemtitle.Enabled = false;
            //Modify Form
            lblTimes.Visible = lblNoBooks.Visible = lblAvNo.Visible = false;
            txtTitleID.Clear(); txtBookID.Enabled = txtTitleID.Enabled = btnGetTitle.Visible = btnGetBook.Visible = lblLLNoAvail.Visible = lblLLNoBooks.Visible = lblLLTimes.Visible = false;
            MakeTaller();


        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnRemBook_Click(object sender, EventArgs e)
        {
            // Disclaimer
            DialogResult sure = MessageBox.Show("Are you sure you want to remove this book? This cannot be undone.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sure == DialogResult.No) goto End;
            //If sure, continue

            BookID = txtBookID.Text;
            //Calling VisualBasic inputBox for Reason
            string Reason = Microsoft.VisualBasic.Interaction.InputBox("Please enter the reasons for this removal:", "Give Reasons");

            //Call method to delete book
            Methods m = new Methods();
            m.RemBook(BookID, Reason, true);

            //Success
            MessageBox.Show("Book has been removed and details of reason have been logged successfully.", "Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Reset();


        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnRemtitle_Click(object sender, EventArgs e)
        {
            // Disclaimer
            DialogResult sure = MessageBox.Show("Are you sure you want to remove all books under this title? This cannot be undone.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sure == DialogResult.No) goto End;
            //If sure, continue

            TitleID = txtTitleID.Text;
            //Calling VisualBasic inputBox for Reason
            string Reason = Microsoft.VisualBasic.Interaction.InputBox("Please enter the reasons for this removal:", "Give Reasons");

            //Get BookIDs
            string sqlBook = string.Format("SELECT BookID FROM Book WHERE TitleID = '{0}'", TitleID);
            OleDbCommand cmdBook = new OleDbCommand(sqlBook, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drBook = cmdBook.ExecuteReader();

            int n = 0;
            while (drBook.Read())
            {
                BookID = drBook["BookID"].ToString();

                //Call method to delete book
                Methods m = new Methods();
                m.RemBook(BookID, Reason, false);

                n = n + 1;
            }

            //Success
            MessageBox.Show(string.Format("{0} books under this title ha(ve)s been removed and details reason have been logged successfully.", n), "Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Reset();            
            
            End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            this.Close(); frmBookDetail f = new frmBookDetail(); f.Show(); 
        }

        private void MakeTaller()
        {
            this.Height = 617;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLentTo_Click(object sender, EventArgs e)
        {
            frmMemDetails m = new frmMemDetails();
            m.txtMemID.Text = lblLentTo.Text; m.Show();
        }
    }
}
