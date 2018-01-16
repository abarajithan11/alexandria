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
    public partial class frmCash : Form
    {
        public frmCash()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Remove single & double quoteswhich cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }

            //Call method
            CashSearch();
        }

        private void CashSearch()
        {
            //Declarations
            string TransID, Time, TDate, TTime, TAmount, TDetail, Event, sEvent, AmntSQL; double[] Amnt = new double[2]; DateTime iDate;
            
            //Disclaim for Amount
            if (txtAmnt1.Text == "" && txtAmnt2.Text == "") AmntSQL = "";
            else
            {
                bool isNum1 = double.TryParse(txtAmnt1.Text, out Amnt[0]);
                bool isNum2 = double.TryParse(txtAmnt2.Text, out Amnt[1]);
                if (!(isNum1 || isNum1)) { MessageBox.Show("Please insert valid numbers into amounts or leave the fields blank.", "Invalid Amounts", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }

                //Design the SQL for filter by pages.
                AmntSQL = string.Format(" AND Amount BETWEEN {0} AND {1} ", Amnt[0], Amnt[1]);
            }

            // Disclaimers end

            //Declarations
            Time = cboxDate.Text; sEvent = cboxEvent.Text;

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
            if (Time == "Today") DateSQL = string.Format(" AND TDate >= #{0}#", iDate);
            else if(iDate == DateTime.Today) DateSQL = "";
            else DateSQL = string.Format(" AND TDate >= #{0}#", iDate);

            //Modify Event to suit Database
            if (sEvent == "New Stock") sEvent = "NewStock";
            else if (sEvent == "Remove Books") sEvent = "RemBook";
            else if (sEvent == "New Membership") sEvent = "NewMem";
            else if (sEvent == "Membership Renewal") sEvent = "MemRenew";
            else if (sEvent == "Fine") sEvent = "Fine";
            else if (sEvent == "Paid for Lost Books") sEvent = "LostPaid";
            else sEvent = "";

            //Datatable
            DataTable Results = new DataTable();
            Results.Columns.Add("ID");
            Results.Columns.Add("Event");
            Results.Columns.Add("Amount (Rs)");
            Results.Columns.Add("Date");
            Results.Columns.Add("Time");
            Results.Columns.Add("Detail");


            //Declarations end


            //Write Main SQL

            string sqlMain = string.Format("SELECT * FROM Cash WHERE Event LIKE '%{0}%'{1}{2}", sEvent, DateSQL, AmntSQL);
            OleDbCommand cmdMain = new OleDbCommand(sqlMain, db.con); 
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drMain = cmdMain.ExecuteReader();

            //For each row in result
            while (drMain.Read())
            {
                TransID = drMain["TransID"].ToString(); TDate = drMain["TDate"].ToString(); TAmount = drMain["Amount"].ToString(); TDetail = drMain["TDetail"].ToString(); Event = drMain["Event"].ToString();
                TTime = DateTime.Parse(TDate).ToShortTimeString(); TDate = DateTime.Parse(TDate).ToString("dd MMMM yyyy"); ;

                if (Event == "NewStock") Event = "New Stock";
                else if (Event == "RemBook") Event = "Book Removed";
                else if (Event == "NewMem") Event = "New Membership";
                else if (Event == "MemRenew") Event = "Membership Renewal";
                else if (Event == "Fine") Event = "Fine";
                else if (Event == "LostPaid") Event = "Paid for Lost Book";
                else if (Event == "AccFinePaid") Event = "Paid for Fines in Account";
                
                Results.Rows.Add(TransID, Event, TAmount, TDate, TTime, TDetail);
            }

            //Find total Transaction
            double sum = 0;
            for (int i = 0; i < Results.Rows.Count; i++)
            {
                sum = sum + double.Parse(Results.Rows[i][2].ToString());
            }

            //Show total
           lblTot.Text = sum.ToString();


            //Show results in Data Grid
            if (Results.Rows.Count == 0) MessageBox.Show("There are no transactions with the specified details. Try removing or modifying few filters.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dtResults.DataSource = Results;


        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void frmCash_Load(object sender, EventArgs e)
        {
            //Call method
            CashSearch();
            cboxDate.SelectedIndex = 7; cboxEvent.SelectedIndex = 5; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
