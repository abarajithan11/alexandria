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
    public partial class frmAddBook : Form
    {

        public bool TitleNew = false; string TitleID = "";

        public frmAddBook()
        {
            InitializeComponent();
        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {

            string sqlTitle = "SELECT BTitle FROM Title";
            string sqlAuthor = "SELECT DISTINCT Author FROM Title";
            string sqlGenre = "SELECT DISTINCT Genre FROM Title";

            OleDbCommand cmdTitle = new OleDbCommand(sqlTitle, db.con);
            OleDbCommand cmdAuthor = new OleDbCommand(sqlAuthor, db.con);
            OleDbCommand cmdGenre = new OleDbCommand(sqlGenre, db.con);

            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();

            OleDbDataReader drTitle = cmdTitle.ExecuteReader();
            OleDbDataReader drAuthor = cmdAuthor.ExecuteReader();
            OleDbDataReader drGenre = cmdGenre.ExecuteReader();

            while (drTitle.Read()) { cboxTitle.Items.Add(drTitle["BTitle"].ToString()); }
            while (drAuthor.Read()) { cboxAuthor.Items.Add(drAuthor["Author"].ToString()); }
            while (drGenre.Read()) { cboxGenre.Items.Add(drGenre["Genre"].ToString()); }


            cboxType.SelectedIndex = 1;
            db.con.Close();
            

            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {


            //Disclaimers Start
            if (cboxTitle.Text == "" || cboxType.Text == "" || cboxAuthor.Text == "" || cboxGenre.Text == "" || txtPages.Text == "" || txtPrice.Text == "" || txtQty.Text == "" || txtPublisher.Text == "")
            { MessageBox.Show("Stock cannot be added because, one or many of the nessasary fields are left blank. Please fill all the fields and try again", "Field Left Blank", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            
            //Remove single & double quotes which cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }

            int Qty; bool q = int.TryParse(txtQty.Text, out Qty); 
            if(q==false) {MessageBox.Show("Insert a valid value for No. of books", "Invalid no. of books", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            //Disclaimers End

            //Declarations
            string Title = cboxTitle.Text; string Maxbook = "B0000"; string BookID; double Price, Trans; Methods methods = new Methods();

            //When Creating new title.
            if (TitleNew == true)
            {

                //Disclaimer + integer Declarations

                int Pages; bool pg = int.TryParse(txtPages.Text, out Pages); bool p = double.TryParse(txtPrice.Text, out Price);
                if (q == false || p == false || pg == false) { MessageBox.Show("Insert a valid value for No. of books, No. Pages or Price"); goto End; }


                //Declarations

                string Type, Author, Genre, ISBN, Publisher; TitleID = "";
                Author = cboxAuthor.Text; Genre = cboxGenre.Text; ISBN = txtISBN.Text; Publisher = txtPublisher.Text;

                if (cboxType.SelectedIndex == 0) Type = "CLend"; else if (cboxType.SelectedIndex == 1) Type = "ALend"; else Type = "Ref";

                //Creating New TitleID
                {

                    //Getting MaxID from Databse
                    string sqlMaxTitle = "SELECT MAX(TitleID) as MaxTitle, COUNT(TitleID) as CountID FROM Title";
                    OleDbCommand cmdMaxTitle = new OleDbCommand(sqlMaxTitle, db.con);
                    if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                    OleDbDataReader drMaxTitle = cmdMaxTitle.ExecuteReader(); drMaxTitle.Read();

                    
                    //If there are titles in DB, formulate a new TitleID

                    if (drMaxTitle["CountID"].ToString() != "0")
                    {
                        // Calling NewID method
                        TitleID = methods.NewID(drMaxTitle["MaxTitle"].ToString());
                    }
                    else TitleID = "T0001";
                }

                //Declartions End


                //Add Values to Relation: Title

                string sqlTitleNew = string.Format("INSERT INTO Title(TitleID, BTitle, BType, Price, Genre, ISBN, Pg, Author, Publisher) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", TitleID, Title, Type, Price, Genre, ISBN, Pages, Author, Publisher);
                OleDbCommand cmdTitleNew = new OleDbCommand(sqlTitleNew, db.con);
                if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                cmdTitleNew.ExecuteNonQuery();

            }
            else Price = double.Parse(txtPrice.Text);

            // Get the highest BookID from Database
            string sqlMaxBook = "SELECT MAX(BookID) as MaxBook, COUNT(BookID) as CountID FROM Book";
                OleDbCommand cmdMaxBook = new OleDbCommand(sqlMaxBook, db.con);
                if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drMaxbook = cmdMaxBook.ExecuteReader();drMaxbook.Read();

                if (drMaxbook["CountID"].ToString() != "0") Maxbook = drMaxbook["MaxBook"].ToString(); else Maxbook = "B0000";
            
            // Adding books in a loop.

            for (int book = 1; book <= Qty; book++)
            {
                //Calling new ID method to create newID
                BookID = methods.NewID(Maxbook);
                
                //Adding a book with such book ID & TitleID to DB

                string sqlbook = string.Format("INSERT INTO Book (BookID, TitleID) VALUES ('{0}','{1}')", BookID, TitleID);
                OleDbCommand cmdbook = new OleDbCommand(sqlbook, db.con);
                if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                cmdbook.ExecuteNonQuery();

                //Make the BookID as the new Book_MaxID to help the next loop
                Maxbook = BookID;
            }

            Maxbook = ""; BookID = "";


            // Adding Transaction details

            Trans = Price * Qty; string TDetail = string.Format("{0} books under the Title: {1}", Qty, Title);

            string sqlTrans = string.Format("INSERT INTO Cash (TDate, Amount, TDetail, Event) VALUES('{0}', {1}, '{2}', 'NewStock')", DateTime.Now.ToString(), -Trans, TDetail);
            OleDbCommand cmdTrans = new OleDbCommand(sqlTrans, db.con);
            cmdTrans.ExecuteNonQuery();
            // Transactions added.

            //Successful Message
            MessageBox.Show(string.Format("{0} Book(s) and/or Book Title have been added to collection and transaction has been recorded successfully", Qty.ToString()), "Books Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset form
            this.Close(); frmAddBook f = new frmAddBook(); f.Show();

            End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Do you want to discard these details?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sure == DialogResult.Yes) this.Close(); frmAddBook f = new frmAddBook(); f.Show();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {


            if (cboxTitle.Text == "") goto End;

            //Remove single & double quoteswhich cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }


                cboxTitle.Enabled = false;
                string sqlTitle = string.Format("SELECT TitleID FROM Title WHERE BTitle = '{0}'", cboxTitle.Text);
                OleDbCommand cmdTitle = new OleDbCommand(sqlTitle, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drTitle = cmdTitle.ExecuteReader();

                string sqlTitleC = string.Format("SELECT Count(TitleID) AS TitCount FROM Title WHERE BTitle = '{0}'", cboxTitle.Text);
                OleDbCommand cmdTitleC = new OleDbCommand(sqlTitleC, db.con);
                OleDbDataReader drTitCount = cmdTitleC.ExecuteReader();

                if (drTitle.Read() && drTitCount.Read() && int.Parse(drTitCount["TitCount"].ToString()) > 0)
                {
                    TitleNew = false; TitleID = drTitle["TitleID"].ToString();
                    DialogResult a = MessageBox.Show("The Title and corresponding details cannot be changed later. Do you want to continue?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (a == DialogResult.Yes)
                    {
                        TitleNew = false;

                        string sqlDetail = string.Format("SELECT * FROM Title WHERE BTitle = '{0}'", cboxTitle.Text);
                        OleDbCommand cmdDetail = new OleDbCommand(sqlDetail, db.con); OleDbDataReader drDetail = cmdDetail.ExecuteReader();

                        if (drDetail.Read())
                        {
                            string sType = drDetail["BType"].ToString();
                            if (sType == "CLend") cboxType.SelectedIndex = 0; else cboxType.SelectedIndex = 1;

                            txtPrice.Text = drDetail["Price"].ToString();
                            txtISBN.Text = drDetail["ISBN"].ToString();
                            txtPages.Text = drDetail["Pg"].ToString();
                            cboxGenre.Text = drDetail["Genre"].ToString();
                            txtPublisher.Text = drDetail["Publisher"].ToString();
                            cboxAuthor.Text = drDetail["Author"].ToString();

                        }
                        else { MessageBox.Show("ERROR Reading Details"); goto End; }

                        btnCancel.Enabled = cboxGenre.Enabled = cboxAuthor.Enabled = cboxType.Enabled = txtISBN.Enabled = txtPages.Enabled = txtPrice.Enabled = btnSet.Enabled = txtPublisher.Enabled = false; txtQty.Enabled = btnAdd.Enabled = true;

                    }
                    else if (a == DialogResult.No) { cboxTitle.Focus(); cboxTitle.Enabled = true; }

                }
                else
                {
                    DialogResult b = MessageBox.Show("The Title cannot be changed later. Do you want to continue?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (b == DialogResult.Yes) { btnCancel.Enabled = TitleNew = true; cboxGenre.Enabled = cboxAuthor.Enabled = cboxType.Enabled = txtISBN.Enabled = txtPages.Enabled = txtPrice.Enabled = txtQty.Enabled = btnAdd.Enabled = txtPublisher.Enabled = true; cboxTitle.Enabled = btnSet.Enabled = false; }
                    else { cboxTitle.Focus(); cboxTitle.Enabled = true; }

                }

            End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();


            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (cboxTitle.Text != "")
            {
                DialogResult sure = MessageBox.Show("Do you want to discard these details?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (sure == DialogResult.Yes) this.Close();
            }
            else this.Close();
        }


    }
}
