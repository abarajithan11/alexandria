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
    public partial class frmExtra : Form
    {
        public frmExtra()
        {
            InitializeComponent();
        }

        List<string> Title = new List<string>(); 

        private void frmExtra_Load(object sender, EventArgs e)
        {
            
            //Calculate popularity and stars
            Popul p = new Popul();
            p.BookCalcAll();
            p.MemCalcAll();

            

            //Adding Top Members
            {
                //Declarations
                string topMemID, topMPop;

                //Count Members
                string sqlCntMem = string.Format("SELECT COUNT(MemberID) as CntMem FROM Member");
                OleDbCommand cmdCntMem = new OleDbCommand(sqlCntMem, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drCntMem = cmdCntMem.ExecuteReader(); drCntMem.Read();
                int No = int.Parse(drCntMem["CntMem"].ToString());

                //Write SQL for top members
                string sqlTopMem = string.Format("SELECT MemberID, Stars FROM Member WHERE Stars NOT IN (0) ORDER BY Stars DESC");
                OleDbCommand cmdTopMem = new OleDbCommand(sqlTopMem, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drTopMem = cmdTopMem.ExecuteReader(); drTopMem.Read();

                int n = 5; int i = 0;
                if (No < n) n = No;

                while (drTopMem.Read() && i < n)
                {
                    topMemID = drTopMem["MemberID"].ToString(); topMPop = drTopMem["Stars"].ToString();
                    topMPop = Math.Round(decimal.Parse(topMPop.ToString()), 2).ToString();
                    lboxTopMem.Items.Add(string.Format("{0} [{1}]", topMemID, topMPop));
                    i++;
                }
            }
            
            //Adding Top Titles
            {
                //Declarations
                string topTitleID, topTPop;

                //Count Titles
                string sqlCntTitle = string.Format("SELECT COUNT(TitleID) as CntTitle FROM Title");
                OleDbCommand cmdCntTitle = new OleDbCommand(sqlCntTitle, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drCntTitle = cmdCntTitle.ExecuteReader(); drCntTitle.Read();
                int No = int.Parse(drCntTitle["CntTitle"].ToString());

                //Write SQL for top Titles
                string sqlTopTitle = string.Format("SELECT TitleID, BTitle, Popularity FROM Title WHERE Popularity ORDER BY Popularity DESC");
                OleDbCommand cmdTopTitle = new OleDbCommand(sqlTopTitle, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drTopTitle = cmdTopTitle.ExecuteReader(); 

                int n = 5; int i = 0;
                if (No < n) n = No;

                while (drTopTitle.Read() && i < n)
                {
                    topTitleID = drTopTitle["BTitle"].ToString(); topTPop = drTopTitle["Popularity"].ToString();
                    topTPop = Math.Round(decimal.Parse(topTPop.ToString()), 2).ToString();
                    lboxTitlePop.Items.Add(string.Format("[{0}] {1}", topTPop, topTitleID));
                    Title.Add(drTopTitle["TitleID"].ToString());
                    i++;
                }
            }

            //Adding Top Authors
            {
                //Declarations
                string topAuthor, topAPop;

                //Count Authors
                string sqlCntAuthor = "SELECT COUNT(Author) AS CntAuthor FROM (SELECT DISTINCT Author FROM Title)";
                OleDbCommand cmdCntAuthor = new OleDbCommand(sqlCntAuthor, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drCntAuthor = cmdCntAuthor.ExecuteReader(); drCntAuthor.Read();
                int No = int.Parse(drCntAuthor["CntAuthor"].ToString());

                //Write SQL for top Titles
                string sqlTopAuthor = string.Format("SELECT Author, SUM(Popularity) AS TotPop FROM Title GROUP BY Author ORDER BY SUM(Popularity) DESC");
                OleDbCommand cmdTopAuthor = new OleDbCommand(sqlTopAuthor, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drTopAuthor = cmdTopAuthor.ExecuteReader(); 

                int n = 5; int i = 0;
                if (No < n) n = No;

                while (drTopAuthor.Read() && i < n)
                {
                    topAuthor = drTopAuthor["Author"].ToString(); topAPop = drTopAuthor["TotPop"].ToString();
                    topAPop = Math.Round(decimal.Parse(topAPop.ToString()), 2).ToString();
                    if(topAPop != "0") lboxAuthorPop.Items.Add(string.Format("[{0}] {1}", topAPop, topAuthor));

                    i++;
                }
            }

            //Adding Top Genres
            {
                //Declarations
                string TopGenre, topGPop;

                //Count Genres
                string sqlCntGenre = string.Format("SELECT COUNT(Genre) as CntGenre FROM (SELECT DISTINCT Genre FROM Title)");
                OleDbCommand cmdCntGenre = new OleDbCommand(sqlCntGenre, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drCntGenre = cmdCntGenre.ExecuteReader(); drCntGenre.Read();
                int No = int.Parse(drCntGenre["CntGenre"].ToString());

                //Write SQL for top Titles
                string sqlTopGenre = string.Format("SELECT Genre, SUM(Popularity) AS TotPop FROM Title GROUP BY Genre ORDER BY SUM(Popularity) DESC");
                OleDbCommand cmdTopGenre = new OleDbCommand(sqlTopGenre, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drTopGenre = cmdTopGenre.ExecuteReader(); 

                int n = 5; int i = 0;
                if (No < n) n = No;

                while (drTopGenre.Read() && i < n)
                {

                    TopGenre = drTopGenre["Genre"].ToString(); topGPop = drTopGenre["TotPop"].ToString();
                    topGPop = Math.Round(decimal.Parse(topGPop.ToString()), 2).ToString();
                    if (topGPop != "0") lboxGenrePop.Items.Add(string.Format("[{0}] {1}", topGPop, TopGenre));

                    i++;
                }
            }

            //Fill Blacklist
            {
                //Write SQL for top Titles
                string sqlBlack = "SELECT MStatus, MemberID FROM Member";
                OleDbCommand cmdBlack = new OleDbCommand(sqlBlack, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drBlack = cmdBlack.ExecuteReader(); drBlack.Read();

                while (drBlack.Read())
                {
                    if(drBlack["MStatus"].ToString() == "Blocked") lboxBlack.Items.Add(drBlack["MemberID"].ToString());
                }
            }

            //Fill all common stats in method
            FillAllStats(); 

            if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();

        }

        private void lboxTopMem_DoubleClick(object sender, EventArgs e)
        {
            if (lboxTopMem.SelectedItems.Count == 1)
            {
                frmMemDetails f = new frmMemDetails();
                f.txtMemID.Text = lboxTopMem.SelectedItem.ToString().Substring(0, 5);
                f.ShowDialog();
            }
        }

        private void lboxBlack_DoubleClick(object sender, EventArgs e)
        {
            if (lboxBlack.SelectedItems.Count == 1)
            {
                frmMemDetails f = new frmMemDetails();
                f.txtMemID.Text = lboxBlack.SelectedItem.ToString();
                f.ShowDialog();
            }
        }

        private void lboxTitlePop_DoubleClick(object sender, EventArgs e)
        {
            if (lboxTitlePop.SelectedItems.Count == 1)
            {
                int i = lboxTitlePop.SelectedIndex;

                frmBookDetail f = new frmBookDetail();
                f.FillTitleInfo(Title[i]);
                f.txtTitleID.Text = Title[i];
                f.btnGetTitle_Click(sender, e);
            }
        }

        private void FillAllStats()
        {

            //Array to fill Member Stats
            string[] sqlCountMem = new string[] { "MemberID LIKE '%'", "MType = 'Adult'", "MType = 'Child'", "MStatus = 'Valid'", "MStatus = 'Expired'", "MStatus = 'Blocked'" };
            string[] CountMem = new string[6];

            //Loop to count MemberID of each type and add to array
            for (int i = 0; i < 6; i++)
            {
                string sqlTotM = string.Format("SELECT COUNT(MemberID) AS MemID FROM Member WHERE {0}", sqlCountMem[i]);
                OleDbCommand cmdTotM = new OleDbCommand(sqlTotM, db.con);
                if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drTotM = cmdTotM.ExecuteReader(); drTotM.Read();

                CountMem[i] = drTotM["MemID"].ToString(); 
            }

            //Show data in labels
            lblTotMem.Text = CountMem[0]; lblAdultM.Text = CountMem[1]; lblChildM.Text = CountMem[2]; lblValidM.Text = CountMem[3]; lblExpiredM.Text = CountMem[4]; lblBlockedM.Text = CountMem[5];





            //Arrays to fill TotBooks and BType stats
            string[] sqlCountTit1 = new string[] { "TitleID LIKE '%'", "BType = 'ALend'", "BType = 'CLend'", "BType = 'Ref'" };
            string[] CountBook1 = new string[4]; int TotBooks;

            //Loop to fill each of 4 info.
            for (int i = 0; i < 4; i++)
            {
                string sqlEachT = string.Format("SELECT TitleID FROM Title WHERE {0}", sqlCountTit1[i]);
                OleDbCommand cmdEachT = new OleDbCommand(sqlEachT, db.con);
                OleDbDataReader drEachT = cmdEachT.ExecuteReader();

                int tNoBooks = 0;

                //For each TitleID of specific type, no. of books are calculated
                while (drEachT.Read())
                {
                    string tTitleID = drEachT["TitleID"].ToString();
                    string sqlEachBT = string.Format("SELECT COUNT(BookID) as Book FROM Book WHERE TitleID = '{0}'", tTitleID);
                    OleDbCommand cmdEachBT = new OleDbCommand(sqlEachBT, db.con);
                    OleDbDataReader drEachBT = cmdEachBT.ExecuteReader(); drEachBT.Read();

                    //No. of books for each titleid are added to a common interger represents the no of books in that type.
                    tNoBooks = tNoBooks + int.Parse(drEachBT["Book"].ToString());
                }

                //common integer is added to array
                CountBook1[i] = tNoBooks.ToString();
            }
            //Get total no. of books
            TotBooks = int.Parse(CountBook1[0]);

            //Show data in labels
            lblTotbook.Text = CountBook1[0]; lblAdultB.Text = CountBook1[1]; lblChildB.Text = CountBook1[2]; lblRefB.Text = CountBook1[3];




            //Arrays to find no of title, authors and genres
            string[] sqlTitCommon = new string[] { "TitleID", "Author", "Genre" };
            string[] TitCommon = new string[3];

            //Loop to fill each 3 info
            for (int i = 0; i < 3; i++)
            {
                string sqlCommon = string.Format("SELECT COUNT({0}) as Common FROM (SELECT DISTINCT {0} FROM Title)", sqlTitCommon[i]);
                OleDbCommand cmdCommon = new OleDbCommand(sqlCommon, db.con);
                OleDbDataReader drCommon = cmdCommon.ExecuteReader(); drCommon.Read();

                TitCommon[i] = drCommon["Common"].ToString();
            }

            //Show data in labels
            lblTotTitle.Text = TitCommon[0]; lblAuthor.Text = TitCommon[1]; lblGenre.Text = TitCommon[2];




            //Count no. of bookID in Lendstatus as the no. of lent books.
            string sqlIsLent = string.Format("SELECT COUNT(BookID) as LentB FROM LendStatus");
            OleDbCommand cmdIsLent = new OleDbCommand(sqlIsLent, db.con);
            OleDbDataReader drIsLent = cmdIsLent.ExecuteReader(); drIsLent.Read();

            int LentB = int.Parse(drIsLent["LentB"].ToString());
            int AvailB = TotBooks - LentB; //Avail books are calculated.

            //Show data in labels
            lblLentB.Text = LentB.ToString();
            lblAvailB.Text = AvailB.ToString();
        }
        
    }
}
