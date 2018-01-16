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
    public partial class frmViewCheckIO : Form
    {
        
        public frmViewCheckIO()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            //Declarations
            string MemID = txtMemID.Text, MStatus = cboxStatus.Text, Event = cboxEvent.Text, Time = cboxDate.Text, MType = cboxMType.Text; DateTime iDate;
            //Remove aingle double quotes in textboxes
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }

            //Check MemID Validity
            if (MemID != "")
            {
                string sqlIsMem = string.Format("SELECT MemberID FROM Member WHERE MemberID = '{0}'", MemID);
                OleDbCommand cmdIsMem = new OleDbCommand(sqlIsMem, db.con); if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drIsMem = cmdIsMem.ExecuteReader(); drIsMem.Read();

                //Disclaimer
                if (!drIsMem.HasRows) { MessageBox.Show("No member is found with such Member ID", "Invalid Member ID", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            }

            //Declare MemType
            if (MType == "Child Member") MType = "Child"; else if (MType == "Adult Member") MType = "Adult"; else MType = "";

            //Declare Date
            if (Time == "Today") iDate = DateTime.Parse(DateTime.Today.ToShortDateString());
            else if (Time == "Past Week") iDate = DateTime.Today.AddDays(-7);
            else if (Time == "Last Two Weeks") iDate = DateTime.Today.AddDays(-14);
            else if (Time == "Past Month") iDate = DateTime.Today.AddMonths(-1);
            else if (Time == "Last Two Months") iDate = DateTime.Today.AddMonths(-2);
            else if (Time == "Last Six Months") iDate = DateTime.Today.AddMonths(-6);
            else if (Time == "Past Year") iDate = DateTime.Today.AddYears(-1);
            else iDate = DateTime.Today;

            //Write Date sql
            string DateSQL;
            
            if (Time == "Today") DateSQL = string.Format(" AND CDate >= #{0}#", DateTime.Today.Date);
            else if (iDate == DateTime.Today) DateSQL = "";
            else DateSQL = string.Format(" AND CDate >= #{0}#", iDate);

            //Declare Event
            if (Event == "Check In") Event = "In";
            else if (Event == "Check Out") Event = "Out";
            else if (Event == "Not Logged") Event = "NotRec";
            else Event = "";

            //Declare MStatus
            if (MStatus == "All") MStatus = "";

            //Call Method
            GetLog(MemID, MType, MStatus, DateSQL, Event);

        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();

        }

        private void GetLog(string MemID, string MType, string MStatus, string DateSQL, string Event)
        {
            //Declarations
            string rEvent, rmMemID, rMemID, rDate, rTime, rMType, rMStatus, rMName;

            //Create Datatable
            DataTable dtAllLog = new DataTable();

            //Design Datatable
            dtAllLog.Columns.Add("Event");
            dtAllLog.Columns.Add("Date");
            dtAllLog.Columns.Add("Time");
            dtAllLog.Columns.Add("Member ID");
            dtAllLog.Columns.Add("Member Name");
            dtAllLog.Columns.Add("Type");
            dtAllLog.Columns.Add("Status");

            //Write Main SQL
            string sqlMain = string.Format("SELECT * FROM CheckInOut WHERE MemberID LIKE '%{0}%' AND Event LIKE '%{1}%'{2}", MemID, Event, DateSQL);
            OleDbCommand cmdMain = new OleDbCommand(sqlMain, db.con);
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drMain = cmdMain.ExecuteReader();

            //For each row in result
            while (drMain.Read())
            {
                //Temp. Declarations
                rMemID = drMain["MemberID"].ToString(); rDate = drMain["CDate"].ToString(); rEvent = drMain["Event"].ToString();

                if (rDate != "")
                {
                    rTime = DateTime.Parse(rDate).ToShortTimeString();
                    rDate = DateTime.Parse(rDate).ToString("dd MMMM yyyy");
                }
                else rTime = "";

                if (rEvent == "In") rEvent = "Check In"; else if (rEvent == "Out") rEvent = "Check Out"; else rEvent = "Not Logged";

                //Get Member Details
                string sqlMemD = string.Format("SELECT MType, MStatus, FName, LName FROM Member WHERE MemberID = '{0}' AND MStatus LIKE '%{1}%' AND MType LIKE '%{2}%'", rMemID, MStatus, MType);
                OleDbCommand cmdMemD = new OleDbCommand(sqlMemD, db.con);
                if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
                OleDbDataReader drMemD = cmdMemD.ExecuteReader();

                //For each row in Member result
                while (drMemD.Read())
                {
                    rmMemID = rMemID; rMName = drMemD["FName"].ToString() + " " + drMemD["LName"].ToString(); rMStatus = drMemD["MStatus"].ToString(); rMType = drMemD["MType"].ToString();

                    dtAllLog.Rows.Add(rEvent, rDate, rTime, rmMemID, rMName, rMType, rMStatus);
                }
            }

            //Show results in Data Grid
            if (dtAllLog.Rows.Count == 0) MessageBox.Show("There are no Member Logs with the specified details. Try removing or modifying few filters.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtResults.DataSource = dtAllLog;

        if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void frmViewCheckIO_Load(object sender, EventArgs e)
        {
            //Call Method
            GetLog("", "", "", "", "");
        }

        private void dtResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtResults.SelectedCells.Count != 0)
            {
                int NowCol = dtResults.SelectedCells[0].ColumnIndex;
                string NowValue = dtResults.Rows[dtResults.CurrentCell.RowIndex].Cells[3].Value.ToString();

                frmMemDetails f = new frmMemDetails();
                if (NowCol == 3 || NowCol == 4)
                { f.txtMemID.Text = NowValue; f.ShowDialog(); }
            }
        }

    }
}
