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
    public partial class frmBSearch : Form
    {
        //Commom Variable Declaration

        string OrderBy = null, OrderIn = "ASC"; int[] Pg = new int[2] { 0, 0 };

        //Commom variable declaration ends

        public frmBSearch()
        {
            InitializeComponent();
        }

        private void frmBSearch_Load(object sender, EventArgs e)
        {
            SearchBooks();
        }

        private void SearchBooks()
        {
            //Declarations
            string Title, Author, Genre, BType, Publisher, OrderSQL, PageSQL;
            string TitleID, BookID, rTitle, rAuthor, rGenre, rBType, rPublisher, rPg, rPop;
            int TotBooks, AvailBooks;

            //Disclaim for pages
            if (txtPg1.Text == "" && txtPg2.Text == "") PageSQL = "";
            else
            {
                bool isNum1 = int.TryParse(txtPg1.Text, out Pg[0]);
                bool isNum2 = int.TryParse(txtPg2.Text, out Pg[1]);
                if (!(isNum1 || isNum1)) { MessageBox.Show("Please insert valid numbers into number of pages or leave the fields blank.", "Invalid Pages", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }

                //Design the SQL for filter by pages.
                PageSQL = string.Format(" AND Pg BETWEEN {0} AND {1} ", Pg[0], Pg[1]);
            }

            //Remove single & double quoteswhich cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }

            // Disclaimers end
            


            //Declarations
            Title = txtTitle.Text; Author = txtAuthor.Text; Genre = txtGenre.Text; Publisher = txtPub.Text; BType = cboxType.Text; OrderBy = cboxSort.Text;
            if (BType == "Adult Lending") BType = "ALend"; else if (BType == "Child Lending") BType = "CLend"; else if (BType == "Reference") BType = "Ref"; else if (BType == "All") BType = ""; else BType = "";

            //Design the SQL for sort by.
            switch (OrderBy)
            {
                case "Author":
                    OrderSQL = " ORDER BY Author ";
                    break;
                case "Genre":
                    OrderSQL = " ORDER BY Genre ";
                    break;
                case "Popularity":
                    OrderSQL = " ORDER BY Popularity ";
                    break;
                case "Pages":
                    OrderSQL = " ORDER BY Pg ";
                    break;
                case "Book Type":
                    OrderSQL = " ORDER BY BType ";
                    break;
                case "Publisher":
                    OrderSQL = " ORDER BY Publisher ";
                    break;
                default: OrderSQL = " ORDER BY BTitle ";
                    break;
            }
            OrderSQL = OrderSQL + OrderIn;

            //Create a datatable
            
                DataTable Results = new DataTable("Results");
                Results.Columns.Add("Title");
                Results.Columns.Add("Author");
                Results.Columns.Add("Genre");
                Results.Columns.Add("Popularity");
                Results.Columns.Add("Book Type");
                Results.Columns.Add("Pages");
                Results.Columns.Add("Publisher");
                Results.Columns.Add("Available");
                Results.Columns.Add("Total");
                
            
            //End Declarations

            //*************** Call to calculate Popularity

            //Write the main sql command
            string sqlMain = string.Format("SELECT * FROM Title WHERE BTitle LIKE '%{0}%' AND Author LIKE '%{1}%' AND Genre LIKE '%{2}%' AND BType LIKE '%{3}%' AND Publisher LIKE '%{4}%'{5}{6}", Title, Author, Genre, BType, Publisher, PageSQL, OrderSQL);
            OleDbCommand cmdMain = new OleDbCommand(sqlMain, db.con);
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drMain = cmdMain.ExecuteReader();

            //For each row in result
            while (drMain.Read())
            {
                //Load results to variables
                TitleID = drMain["TitleID"].ToString(); rTitle = drMain["BTitle"].ToString(); rAuthor = drMain["Author"].ToString(); rGenre = drMain["Genre"].ToString(); rPop = drMain["Popularity"].ToString(); rPg = drMain["Pg"].ToString(); rPublisher = drMain["Publisher"].ToString(); rBType = drMain["BType"].ToString();
                if (rBType == "CLend") rBType = "Child Lending"; else if (rBType == "ALend") rBType = "Adult Lending"; else rBType = "Reference";

                //Count BookIDs for given TitleID
                string sqlBookCnt = string.Format("SELECT COUNT(BookID) AS BookCnt FROM Book WHERE TitleID = '{0}'", TitleID);
                OleDbCommand cmdBookCnt = new OleDbCommand(sqlBookCnt, db.con); OleDbDataReader drBookCnt = cmdBookCnt.ExecuteReader(); drBookCnt.Read();
                TotBooks = int.Parse(drBookCnt["BookCnt"].ToString());
                AvailBooks = TotBooks;

                //SQL to get bookIDs for title
                string sqlBookID = string.Format("SELECT BookID FROM Book WHERE TitleID = '{0}'", TitleID);
                OleDbCommand cmdBookID = new OleDbCommand(sqlBookID, db.con); OleDbDataReader drBookID = cmdBookID.ExecuteReader();

                while (drBookID.Read())
                {
                    BookID = drBookID["BookID"].ToString();

                    //SQL to check each bookID in Lendstatus
                    string sqlLendD = string.Format("SELECT MemberID AS TempD FROM LendStatus WHERE BookID = '{0}'", BookID);
                    OleDbCommand cmdLendD = new OleDbCommand(sqlLendD, db.con); OleDbDataReader drLendD = cmdLendD.ExecuteReader(); drLendD.Read();

                    if (drLendD.HasRows) AvailBooks = AvailBooks - 1;
                }

                //Add Details to Data Table
                Results.Rows.Add(rTitle, rAuthor, rGenre, rPop, rBType, rPg, rPublisher, AvailBooks, TotBooks);
            }

            //Display results in data grid

            if (Results.Rows.Count == 0) MessageBox.Show("There are no titles with the specified details. Try removing or modifying few filters.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtResults.DataSource = Results;



        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void cboxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrderBy == cboxSort.SelectedItem.ToString())
            {
                if (OrderIn == "ASC") OrderIn = "DESC";
                else OrderIn = "ASC";
            }

            OrderBy = cboxSort.SelectedItem.ToString();
            SearchBooks();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Call method
            SearchBooks(); 
        }
   
    }
}
