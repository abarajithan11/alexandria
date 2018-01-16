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
    public class db
    {
        public static OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\LibraryDB.mdb; Jet OLEDB:Database Password=masterpwd");
    }

    public class cvar // Common Variables
    {
        public static bool InsertID = false;
        public static string MemID;
        public static string UType = "";
        public static string UText = "";
    }

    public partial class set // Setting variables and settings recall method
    {

        public static string[] SType = new string[] { "A", "C" };
        public static string[] SNameI = new string[] { "Btime", "NoBooks", "Expire", "Alert", "LostBookTimes"};
        public static string[] SNameD = new string[] { "Fine", "RenewC", "NewC" };

        //A 2 dimensional array is created to store values of SettingType and SettingName
        public static int[,] SValueI = new int[,] { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, {0, 0} };
        public static double[,] SValueD = new double[,] { { 0, 0 }, { 0, 0 }, { 0, 0 } };

        public static int AgeMin = 0;

        public static double[] Fine = new double[2] { 0, 0 };
        public static double[] RenewC = new double[2] { 0, 0 };
        public static double[] NewC = new double[2] { 0, 0 };

        public static int[] Btime = new int[2] { 0, 0 };
        public static int[] NoBooks = new int[2] { 0, 0 };
        public static int[] Expire = new int[2] { 0, 0 };
        public static int[] Alert = new int[2] { 0, 0 };
        public static int[] LostBookTimes = new int[2] { 0, 0 };
       
        public void recall() // Recall Setting Values from DB and load them to global variables.
        {
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();

            // Main For loop of Int to repeatedly retrive interger values from DB (using SNameI) and add values to SValue[*,_] 15 times.
            for (int iSN = 0; iSN < SNameI.Length; iSN++)
            {
                // Sub for loop to repeatedly add values from DB (using SType) and add to SValue[_,*] twice during each main loop.
                for (int iST = 0; iST < SType.Length; iST++)
                {
                    string sqlSet = string.Format("SELECT SValue FROM Setting WHERE SName = '{0}' AND SType = '{1}'", SNameI[iSN], SType[iST]);
                    OleDbCommand cmdSet = new OleDbCommand(sqlSet, db.con); OleDbDataReader drSet = cmdSet.ExecuteReader();

                    if (drSet.Read()) { SValueI[iSN, iST] = int.Parse(drSet["SValue"].ToString()); }
                }
            
            }

            // Main For loop of double to repeatedly retrive double values from DB (using SNameD) and add values to SValue[*,_] 15 times.
            for (int iSN = 0; iSN < SNameD.Length; iSN++)
            {
                // Sub for loop to repeatedly add values from DB (using SType) and add to SValue[_,*] twice during each main loop.
                for (int iST = 0; iST < SType.Length; iST++)
                {
                    string sqlSet = string.Format("SELECT SValue FROM Setting WHERE SName = '{0}' AND SType = '{1}'", SNameD[iSN], SType[iST]);
                    OleDbCommand cmdSet = new OleDbCommand(sqlSet, db.con); OleDbDataReader drSet = cmdSet.ExecuteReader();

                    if (drSet.Read()) { SValueD[iSN, iST] = double.Parse(drSet["SValue"].ToString()); }
                }

            }

            string sqlSetAge = "SELECT SValue FROM Setting WHERE SName = 'AgeMin'";
            OleDbCommand cmdSetAge = new OleDbCommand(sqlSetAge, db.con); OleDbDataReader drSetAge = cmdSetAge.ExecuteReader();


            //Add Minimun Age information.
            if (drSetAge.Read()) { AgeMin = int.Parse(drSetAge["SValue"].ToString()); }

            //Add Values to User-friendly variables.

            Fine[0] = SValueD[0, 0]; Fine[1] = SValueD[0, 1];
            RenewC[0] = SValueD[1, 0]; RenewC[1] = SValueD[1, 1];
            NewC[0] = SValueD[2, 0]; NewC[1] = SValueD[2, 1];

            Btime[0] = SValueI[0, 0]; Btime[1] = SValueI[0, 1];
            NoBooks[0] = SValueI[1, 0]; NoBooks[1] = SValueI[1, 1];
            Expire[0] = SValueI[2, 0]; Expire[1] = SValueI[2, 1];
            Alert[0] = SValueI[3, 0]; Alert[1] = SValueI[3, 1];
            LostBookTimes[0] = SValueI[4, 0]; LostBookTimes[1] = SValueI[4, 1];

        }
    } 

    public partial class Popul // Update Popularity Points.
    {

        //Calculate STar Points for each member and input each of them to DB 
        public void MemCalcAll()
        {
            // Creat command to get MemberID one by one)

            string sqlMem = string.Format("SELECT MemberID FROM Member");
            OleDbCommand cmdMem = new OleDbCommand(sqlMem, db.con);
            if(db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drMem = cmdMem.ExecuteReader();

            //For Each member, Call MemCalc method and calculate and add StarPoints
            while (drMem.Read())
            {
                MemCalc(drMem["MemberID"].ToString(), true);

            } // To next member


        if (db.con.State.Equals(ConnectionState.Closed)) db.con.Close();
        
    
        }
        
        //Calculate StarPoints of A Member with Given ID. 
        public double MemCalc(string MemID1, bool updateDB) 
        {
            
            //Declarations
            double StarPoints, Stars =0;

            string sqlMem = string.Format("SELECT TimesBorrow, Renewed, DateJoined FROM Member WHERE MemberID = '{0}'", MemID1);
            OleDbCommand cmdMem = new OleDbCommand(sqlMem, db.con);
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drMem = cmdMem.ExecuteReader();


            if (drMem.Read())
            {

                int TimesBorrow = int.Parse(drMem["TimesBorrow"].ToString()), Renewed = int.Parse(drMem["Renewed"].ToString()), CheckIn = 0, Months;
                DateTime DateJ = DateTime.Parse(drMem["DateJoined"].ToString());

                //Count Times Checked in from DB
                string sqlCheckIn = string.Format("SELECT COUNT(CDate) AS CntDate FROM CheckInOut WHERE MemberID = '{0}' AND Event = 'In' GROUP BY MemberID, Event", MemID1);
                OleDbCommand cmdCheckIn = new OleDbCommand(sqlCheckIn, db.con);
                OleDbDataReader drCheckIn = cmdCheckIn.ExecuteReader();
                if (drCheckIn.Read()) CheckIn = int.Parse(drCheckIn["CntDate"].ToString());

                // Find no.of months passed since the member first joined.

                int TotDays = int.Parse(DateTime.Today.Subtract(DateJ).TotalDays.ToString()) + 1;
                Months = (Renewed * 365 + TotDays ) / 30;

                // Star points is sum of Times borrowd and Checkin/4 (4 checkins have equal points for one borrowal)
                StarPoints = (TimesBorrow + CheckIn / 4);

                //Stars is Popularity Points per Months till today.
                Stars = StarPoints / (Months + 1); 


                // Add Stars to each Member
                if (updateDB)
                {
                    string sqlPop = string.Format("UPDATE Member SET Stars = {0} WHERE MemberID = '{1}'", Stars, MemID1);
                    OleDbCommand cmdPop = new OleDbCommand(sqlPop, db.con); cmdPop.ExecuteNonQuery();
                }
            }
            else MessageBox.Show("Member ID not read");

            return Stars;
        }

        //Calculate Popularity for a given title
        public double BookCalc(string BookID, string TitleID, bool updateDB)
        {
            // Declarations
            int Times, NoBooks; double Pop;


            if (TitleID == null) // If titleID not given, get it
            {
                //Get TitleID from Book table
                string sqlBook = string.Format("SELECT TitleID FROM Book WHERE BookID = '{0}'", BookID);
                OleDbCommand cmdBook = new OleDbCommand(sqlBook, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drBook = cmdBook.ExecuteReader(); drBook.Read();
                TitleID = drBook["TitleID"].ToString();
            }

            //Get TimesTaken from Title
            string sqlTimes = string.Format("SELECT TimesBorrowed FROM Title WHERE TitleID = '{0}'", TitleID);
            OleDbCommand cmdTimes = new OleDbCommand(sqlTimes, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drTimes = cmdTimes.ExecuteReader(); drTimes.Read();
            Times = int.Parse(drTimes["TimesBorrowed"].ToString());

            //Get no. of books from Book
            string sqlNoBook= string.Format("SELECT COUNT(BookID) as NoBook FROM Book WHERE TitleID = '{0}'", TitleID);
            OleDbCommand cmdNoBook= new OleDbCommand(sqlNoBook, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drNoBook= cmdNoBook.ExecuteReader(); drNoBook.Read();
            NoBooks = int.Parse(drNoBook["NoBook"].ToString());

            //Calculate Popularity = Time taken per book
            Pop = double.Parse(Math.Round(decimal.Parse((Times / NoBooks).ToString()), 2).ToString());

            if (updateDB)
            {
                string sqlPop = string.Format("UPDATE Title SET Popularity = {0} WHERE TitleID = '{1}'", Pop, TitleID);
                OleDbCommand cmdPop = new OleDbCommand(sqlPop, db.con); cmdPop.ExecuteNonQuery();
            }

            return Pop;
        }

        public void BookCalcAll()
        {
            // Creat command to get TitleID one by one)

            string sqlBookD = string.Format("SELECT TitleID FROM Title");
            OleDbCommand cmdBookD = new OleDbCommand(sqlBookD, db.con);
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drBookD = cmdBookD.ExecuteReader();

            //For Each BookDber, Call BookDCalc method and calculate and add StarPoints
            while (drBookD.Read())
            {
                BookCalc(null, drBookD["TitleID"].ToString(), true);

            } // To next BookDber
        }
        
    }

    public partial class Methods // Common Methods
    {
        // Create New ID from MaxID method
        public string NewID(string MaxID)
        {

            //Getting Initial Characted from MAx ID
            string a = MaxID.Substring(0, 1);

            //Incrementing MaxID into newID
            int iID = int.Parse(MaxID.Substring(1, 4));
            string sID = (iID + 1).ToString();

            // Using a for loop to create newID with legnth 5 (1 + 4)
            for (int i = sID.Length; i != 4; i++) { sID = "0" + sID; }
            string NewID = a + sID;

            return NewID;
        }

        // Check for Alert Notifications [It works PERFECTLY, in few tries.. WOW]
        public void Notif(ref int N, ref DateTime[] nLend, ref string[] nMemID, ref string[] nMemType, ref string[] nBookID, ref string[] nTitleID, ref string[] nTitle, ref double[] nPrice, ref bool NError)
        {

            //Disclaimer for Settings not loaded.
            if (set.Btime[0] == 0 && set.Btime[1] == 0) { MessageBox.Show("Settings not loaded. Load settings and try again."); NError = true; goto End; }

            // Lists are declared as the values cannot be added to arrays since we dont know the array legnth aka no. of notif.

            List<DateTime> lLend = new List<DateTime>();
            List<string> lMemID = new List<string>();
            List<string> lMemType = new List<string>();
            List<string> lBookID = new List<string>();
            List<string> lTitleID = new List<string>();
            List<string> lTitle = new List<string>();
            List<double> lPrice = new List<double>();


            // Read the LendStatus Relation to get all data
            string sqlLend = "SELECT BookID, MemberID, LendDate FROM LendStatus";
            OleDbCommand cmdLend = new OleDbCommand(sqlLend, db.con);
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drLend = cmdLend.ExecuteReader();

            N = 0; // No notification at this point

            while (drLend.Read()) // For each record in LendStatus
            {
                //Declare temporary VARIABLES for each record
                string tBookID, tMemID, tMemType, tTitleID, tTitle; double tPrice; DateTime tLend; int i;

                //Lend Date and MemberID
                tLend = DateTime.Parse(drLend["LendDate"].ToString()); tMemID = drLend["MemberID"].ToString();

                //Check MemType of Member since the Alert time differs acc. to MemType
                string sqlMType = string.Format("SELECT MType FROM Member WHERE MemberID = '{0}'", tMemID);
                OleDbCommand cmdMType = new OleDbCommand(sqlMType, db.con); OleDbDataReader drMType = cmdMType.ExecuteReader();
                if (drMType.Read()) tMemType = drMType["MType"].ToString(); else tMemType = "ERROR";

                //Get respective Alert time and calculate ideal time aka time when the alert should be raised.
                if (tMemType == "Adult") i = 0; else i = 1;
                DateTime idealDT = tLend.AddDays(set.Alert[i]);
                
                if (DateTime.Today.Date > idealDT) // If Alert should have been raised in the past (before today), Get details and count it.
                {
                    N = N + 1; // Take this record into count.
                    tBookID = drLend["BookID"].ToString(); // Get bookID

                    //From BookID in Book relation, get TitleID & Load it to temp var.
                    string sqlBookID = string.Format("SELECT TitleID FROM Book WHERE BookID = '{0}'", tBookID);
                    OleDbCommand cmdBookID = new OleDbCommand(sqlBookID, db.con); OleDbDataReader drBookID = cmdBookID.ExecuteReader();
                    if (drBookID.Read()) tTitleID = drBookID["TiTleID"].ToString(); else tTitleID = "ERROR";

                    //From TitleID in Title relation, get Title's information
                    string sqlTitle = string.Format("SELECT BTitle, Price, BTitle FROM Title WHERE TitleID = '{0}'", tTitleID);
                    OleDbCommand cmdTitle = new OleDbCommand(sqlTitle, db.con); OleDbDataReader drTitle = cmdTitle.ExecuteReader();

                    //Load them to temp. variables
                    if (drTitle.Read()) { tTitle = drTitle["BTitle"].ToString(); tPrice = double.Parse(drTitle["Price"].ToString()); }
                    else { tTitle = "ERROR"; tPrice = 404; }

                    //Add all temp. variables to the lists.
                    lLend.Add(tLend); lMemID.Add(tMemID); lMemType.Add(tMemType); lBookID.Add(tBookID); lTitleID.Add(tTitleID); lTitle.Add(tTitle); lPrice.Add(tPrice);

                }
            } // To next record in LendStatus

            //All records and their values have been inserted into 7 lists and no. of Notif loaded to variable 'N'

            if (N == 0) goto End; // If No alerts, end the method with empty arrays
            
            //If alerts, change all lists to respective arrays and out them via ref
            nLend = lLend.ToArray(); nMemID = lMemID.ToArray(); nMemType = lMemType.ToArray(); nBookID = lBookID.ToArray(); nTitleID = lTitleID.ToArray(); nTitle = lTitle.ToArray();  nPrice = lPrice.ToArray();

            
        End: ;
        }
         
        //Check for Member's old fines
        public void FindAccFines(string MemID, ref bool isFine, ref double accFine)
        { 
            //Get old fines in account
            string sqlMFine = string.Format("SELECT Fine FROM Member WHERE MemberID = '{0}'", MemID);
            OleDbCommand cmdMFine = new OleDbCommand(sqlMFine, db.con);
            OleDbDataReader drMFine = cmdMFine.ExecuteReader();

            if (drMFine.Read() && drMFine.HasRows)
            {
                accFine = double.Parse(drMFine["Fine"].ToString());

                if (accFine != 0) // If unpaid fines are there.
                { isFine = true; }

            }
            else MessageBox.Show("Invalid Member ID", "", MessageBoxButtons.OK, MessageBoxIcon.Error);       
        }

        // Pay Member's old fines
        public void PayAccFines(string MemID, double accFine)
        {

            //Reset the account fines.
            string sqlaccFineNow = string.Format("UPDATE Member SET Fine = Fine - {0} WHERE MemberID = '{1}'", accFine, MemID);
            OleDbCommand cmdaccFineNow = new OleDbCommand(sqlaccFineNow, db.con);
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            cmdaccFineNow.ExecuteNonQuery();

            //Record transaction details to Cash
            string sqlaccFineNowCash = string.Format("INSERT INTO Cash(Event, TDetail, TDate, Amount) VALUES ('AccFinePaid', '{0}', '{1}', '{2}')", string.Format("MemberID = {0}", MemID), DateTime.Now.ToString(), accFine);
            OleDbCommand cmdaccFineNowCash = new OleDbCommand(sqlaccFineNowCash, db.con);
            cmdaccFineNowCash.ExecuteNonQuery();

            MessageBox.Show(string.Format("Transaction of account fine balance of Rs.{0} has beeen successfully recorded and the Member {1}'s account has been cleared of all previous fines.", accFine, MemID), "Transaction Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
        }

        //Check and return fine details for one book
        public void FindBookFine(string BookID, out bool isBFine, out double Fine, out int Days, out DateTime iDate, out string MemID, out bool IsBlocked, out int MTi)
        {
            //Declarations
            string MType; DateTime LDate; MTi = 2;

            //Temporary Declarations
            isBFine = false; Fine = 0; Days = 0; iDate = DateTime.Today; MemID = "ERROR";

            //Get the Lending detains from LendStatus relation
            string sqlLDetail = string.Format("SELECT LendDate, MemberID, Extend FROM LendStatus WHERE BookID = '{0}'", BookID);
            OleDbCommand cmdLDetail = new OleDbCommand(sqlLDetail, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drLDetail = cmdLDetail.ExecuteReader(); drLDetail.Read();


            MemID = drLDetail["MemberID"].ToString(); // Get MemID

            //Get MemberType from MemID to get number of days and get old fines in account
            string sqlMDetail = string.Format("SELECT MType, MStatus FROM Member WHERE MemberID = '{0}'", MemID);
            OleDbCommand cmdMDetail = new OleDbCommand(sqlMDetail, db.con);
            OleDbDataReader drMDetail = cmdMDetail.ExecuteReader(); drMDetail.Read();

            //Load Status to variable
            if (drMDetail["MStatus"].ToString() == "Blocked") { IsBlocked = true;} else IsBlocked = false;
            
            //Load Type to variable
            MType = drMDetail["MType"].ToString();

            //From MType, get number of days can be kept
            if (MType == "Adult") MTi = 0; else MTi = 1;

            LDate = DateTime.Parse(drLDetail["LendDate"].ToString());
            iDate = LDate.AddDays(set.Btime[MTi]); // Find the date when the book should be returned
            Days = DateTime.Today.Subtract(iDate).Days; // Find the days between today and that date

            if (Days <= 0) isBFine = false;

            else
            {
                isBFine = true;

                Fine = set.Fine[MTi] * Days; // Calculate Fines from Days and fine per day
                Fine = double.Parse(Math.Round(decimal.Parse(Fine.ToString()), 1).ToString()); //Round to 1 decimal
            }

        
        }

        //Remove a book of given BookID
        public void RemBook(string BookID, string Reason, bool isBlack)
        {
            //Get TitleID from Book table
            string sqlBook = string.Format("SELECT TitleID FROM Book WHERE BookID = '{0}'", BookID);
            OleDbCommand cmdBook = new OleDbCommand(sqlBook, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drBook = cmdBook.ExecuteReader(); drBook.Read();
            string TitleID = drBook["TitleID"].ToString();

            //Select Price from Title Table with BookID
            string sqlTPrice = string.Format("SELECT Price FROM Title WHERE TitleID = '{0}'", TitleID);
            OleDbCommand cmdTPrice = new OleDbCommand(sqlTPrice, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drTPrice = cmdTPrice.ExecuteReader(); drTPrice.Read();
            double Price = double.Parse(drTPrice["Price"].ToString());

            //Count No. of books under Title
            string sqlBookCnt = string.Format("SELECT COUNT(BookID) as BookCnt FROM Book WHERE TitleID = '{0}'", TitleID);
            OleDbCommand cmdBookCnt = new OleDbCommand(sqlBookCnt, db.con); 
            OleDbDataReader drBookCnt = cmdBookCnt.ExecuteReader(); drBookCnt.Read();
            double BookCnt = double.Parse(drBookCnt["BookCnt"].ToString());

            //Check book in Book Table
            string sqlLendCheck = string.Format("SELECT MemberID FROM LenDstatus WHERE BookID = '{0}'", BookID);
            OleDbCommand cmdLendCheck = new OleDbCommand(sqlLendCheck, db.con);
            OleDbDataReader drLendCheck = cmdLendCheck.ExecuteReader(); drLendCheck.Read();

            //If book is lent, remove book from there.
            if (drLendCheck.HasRows)
            {
                if (isBlack)
                {
                    string MemID1 = drLendCheck["MemberID"].ToString();
                    DialogResult black = MessageBox.Show(string.Format("This book has been borrowed by Member '{0}'. \r\n\r\nIf you think the member has stolen the book, you may add him/her to blacklist and if the member checks in or tries to create another membership with same NIC number or Email, an alert will be raised. Do you want to add this member to blacklist?", MemID1), "Add to Blacklist?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (black == DialogResult.Yes)
                    {
                        string sqlBlack = string.Format("UPDATE Member SET MStatus = 'Blocked' WHERE MemberID = '{0}'", MemID1);
                        OleDbCommand cmdBlack = new OleDbCommand(sqlBlack, db.con);
                        cmdBlack.ExecuteNonQuery();
                    }
                }
                {
                    string sqlRemLend = string.Format("DELETE FROM LendStatus WHERE BookID = '{0}'", BookID);
                    OleDbCommand cmdRemLend = new OleDbCommand(sqlRemLend, db.con);
                    cmdRemLend.ExecuteNonQuery();
                }
            }
            //Remove book from Book Table
            string sqlRemBook = string.Format("DELETE FROM Book WHERE BookID = '{0}'", BookID);
            OleDbCommand cmdRemBook = new OleDbCommand(sqlRemBook, db.con);
            cmdRemBook.ExecuteNonQuery();

            // If only one book was under the title, remove the title also, since there are no books now.
            if (BookCnt == 1)
            {
                string sqlRemTitle = string.Format("DELETE FROM Title WHERE TitleID = '{0}'", TitleID);
                OleDbCommand cmdRemTitle = new OleDbCommand(sqlRemTitle, db.con);
                cmdRemTitle.ExecuteNonQuery();
            }
            
        }

        //Get Title Details of TitleID
        public void TitleInfo(string TitleID, out bool IsValidID, out string Title,out string Author,out string Genre,out string  Publish,out string  Pg,out string  ISBN,out string  Ty,out string  Price,out string  Popula,out string Times, out int NoAvail, out string NoBooks)
        {
            //Temporary Declarations
            Title = Author = Genre = Publish = Pg = ISBN = Ty = Price = Popula = Times = NoBooks = ""; NoAvail = 0;

            //Get Details from Title Table
            string sqlTitle = string.Format("SELECT * FROM Title WHERE TitleID = '{0}'", TitleID);
            OleDbCommand cmdTitle = new OleDbCommand(sqlTitle, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drTitle = cmdTitle.ExecuteReader(); drTitle.Read();

            //Disclaimer: If Invalid TitleID
            if (drTitle.HasRows) IsValidID = true; else { IsValidID = false; goto End;}

            //Declarations of Title Information

            Title = drTitle["BTitle"].ToString();
            Author = drTitle["Author"].ToString();
            Genre = drTitle["Genre"].ToString();
            Publish = drTitle["Publisher"].ToString();
            Pg = drTitle["Pg"].ToString();
            ISBN = drTitle["ISBN"].ToString();
            Ty = drTitle["BType"].ToString();
            if (Ty == "ALend") Ty = "Adult Lending"; else if (Ty == "CLend") Ty = "Children Lending"; else Ty = "Reference";
            Price = drTitle["Price"].ToString();
            Popul p = new Popul();
            Popula = p.BookCalc(null, TitleID, false).ToString();
            Times = drTitle["TimesBorrowed"].ToString();

            //Get Associated Book Details
            string sqlBookD = string.Format("SELECT COUNT(BookID) as BCount FROM Book WHERE TitleID = '{0}'", TitleID);
            OleDbCommand cmdBookD = new OleDbCommand(sqlBookD, db.con);
            OleDbDataReader drBookD = cmdBookD.ExecuteReader(); drBookD.Read();

            NoBooks = drBookD["BCount"].ToString(); 
            NoAvail = int.Parse(NoBooks);

            //Get BooksIDs associated with Title
            string sqlEachBookID = string.Format("SELECT BookID FROM Book WHERE TitleID = '{0}'", TitleID);
            OleDbCommand cmdEachBookID = new OleDbCommand(sqlEachBookID, db.con);
            OleDbDataReader drEachBookID = cmdEachBookID.ExecuteReader();

            //For Each BookID
            while (drEachBookID.Read())
            {

                string BookID = drEachBookID["BookID"].ToString();

                //Check wheather each book has been lent.
                string sqlLent = string.Format("SELECT BookID FROM LendStatus WHERE BookID = '{0}'", BookID);
                OleDbCommand cmdLent = new OleDbCommand(sqlLent, db.con);
                OleDbDataReader drLent = cmdLent.ExecuteReader(); drLent.Read();

                //IF lent, decrement the no. of available books 
                if (drLent.HasRows) NoAvail = NoAvail - 1;
            }
        End: ;
        }

        //Expire the members
        public void MemExpire()
        {
            //Declarations
            DateTime JDate, iDate, Now; string MemID, Mtype; int MTi, x = 0;

            Now = DateTime.Today; 

            //Read Each members
            string sqlMem = string.Format("SELECT MemberID, MType, DateJoined FROM Member WHERE MStatus = 'Valid'");
            OleDbCommand cmdMem = new OleDbCommand(sqlMem, db.con);
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drMem = cmdMem.ExecuteReader();

            //For each member
            while (drMem.Read())
            {
                //Declare
                MemID = drMem["MemberID"].ToString(); Mtype = drMem["MType"].ToString(); JDate = DateTime.Parse(drMem["DateJoined"].ToString());
                
                //Set Member Type index
                //Get the date, a member of such type should have joined, if his membership to be expired today.
                if (Mtype == "Adult") MTi = 0; else MTi = 1;
                iDate = Now.AddMonths(-set.Expire[MTi]);

                //Compare dates
                int i = DateTime.Compare(JDate, iDate); // if in past,
                if (i < 0)
                {
                    string sqlUMem = string.Format("UPDATE Member SET MStatus = 'Expired' WHERE MemberID = '{0}'", MemID) ;
                    OleDbCommand cmdUMem = new OleDbCommand(sqlUMem, db.con);
                    if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                    cmdUMem.ExecuteNonQuery(); x++;
                }
            }
            if (db.con.State.Equals(ConnectionState.Open)) db.con.Close(); 
            
        }
    }
}
