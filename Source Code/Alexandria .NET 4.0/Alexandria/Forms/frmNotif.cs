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
    public partial class frmNotif : Form
    {
        //Create Datatable

        public DataTable dtAllNotif = new DataTable();
        
        public frmNotif()
        {
            InitializeComponent();
        }

        private void frmNotif_Load(object sender, EventArgs e)
        {
            fillAllNotif();
        }

        private void fillAllNotif()
        {
            //Call Notif Method

            Methods m = new Methods();
            int N = 0; DateTime[] nLend = new DateTime[] { }; ; string[] nMemID = new string[] { }; string[] nMemType = new string[] { }; string[] nBookID = new string[] { }; string[] nTitleID = new string[] { }; string[] nTitle = new string[] {}; double[] nPrice = new double[] { }; bool NError = false;
            m.Notif(ref N, ref nLend, ref nMemID, ref nMemType, ref nBookID, ref nTitleID, ref nTitle, ref nPrice, ref NError);

            if (NError) { MessageBox.Show("There was an error reading notifications"); goto End; }
            if (N == 0) { MessageBox.Show("There are no alerts to be displayed", "No Alerts", MessageBoxButtons.OK, MessageBoxIcon.Information); goto End; }
            this.Text = this.Text + string.Format(" [{0}]", N);

            // Design DataTable
            dtAllNotif.Columns.Add("DTDate");
            dtAllNotif.Columns[0].DataType = System.Type.GetType("System.DateTime");
            

            dtAllNotif.Columns.Add("Date_Lent");
            dtAllNotif.Columns.Add("Title");
            dtAllNotif.Columns.Add("Price");
            dtAllNotif.Columns.Add("MemberID");
            dtAllNotif.Columns.Add("Member_Type");
            dtAllNotif.Columns.Add("Title ID");
            dtAllNotif.Columns.Add("Book ID");

            //Add contents in loop

            for (int i = 0; i < nLend.Length; i++)
            {
                dtAllNotif.Rows.Add(nLend[i], DateTime.Parse(nLend[i].ToString()).ToString("dd-MM-yyyy"), nTitle[i], nPrice[i], nMemID[i], nMemType[i], nTitleID[i], nBookID[i]);
            }
            dtResults.DataSource = dtAllNotif;
            lblNo.Text = dtAllNotif.Rows.Count.ToString();

            //Design Data View
            dtResults.Columns[1].HeaderText = "Date Lent";
            dtResults.Columns[4].HeaderText = "Member ID";
            dtResults.Columns[5].HeaderText = "Member Type";
            dtResults.Columns[0].Visible = false;

        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void FilterNoif(string MemID, string MType, string DateSQL)
        {
            if (dtAllNotif.Rows.Count == 0) { MessageBox.Show("There are no alterts to filter.", "No Alerts", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            
            string Filter = string.Format("MemberID LIKE '%{0}%' AND Member_Type LIKE '%{1}%'{2}", MemID, MType, DateSQL);

            DataView dvresults = new DataView(dtAllNotif, Filter , "", DataViewRowState.CurrentRows);
            
            //Show Results
            dtResults.DataSource = dvresults;

            //Design Data View
            dtResults.Columns[1].HeaderText = "Date Lent";
            dtResults.Columns[4].HeaderText = "Member ID";
            dtResults.Columns[5].HeaderText = "Member Type";

        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //Remove single & double quoteswhich cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }

            //Declarations
            string MemID = txtMemID.Text, MType = cboxMType.Text, Time = cboxDate.Text; ; DateTime iDate;

            if (MemID == "") { }
            else
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
            if (iDate == DateTime.Today) DateSQL = "";
            else DateSQL = string.Format(" AND DTDate >= #{0}#", iDate);

            
            //Call Filter Method
            FilterNoif(MemID, MType, DateSQL);

            if (dtResults.Rows.Count == 0) MessageBox.Show("There are no Notifications within the given filters. Try removing some filters.", "No Notifications", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void dtResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtResults.SelectedCells.Count != 0)
            {
                string NowValue = dtResults.CurrentCell.Value.ToString(); 
                int NowCol = dtResults.SelectedCells[0].ColumnIndex;
                string NowBook = dtResults.Rows[dtResults.CurrentCell.RowIndex].Cells[7].Value.ToString();

                frmBookDetail b = new frmBookDetail();
                frmMemDetails m = new frmMemDetails();
                if (NowCol == 4)
                { m.txtMemID.Text = NowValue; m.ShowDialog(); }
                else if (NowCol == 6)
                { b.txtTitleID.Text = NowValue; b.btnGetTitle_Click(sender, e); b.ShowDialog(); }
                else if (NowCol == 7 || NowCol == 2)
                { b.txtBookID.Text = NowBook; b.btnGetBook_Click(sender, e);  b.ShowDialog();}
            }
        }

        private void frmNotif_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Call Notif Method

            Methods m = new Methods(); frmMain f = new frmMain();
            int N = 0; DateTime[] nLend = new DateTime[] { }; ; string[] nMemID = new string[] { }; string[] nMemType = new string[] { }; string[] nBookID = new string[] { }; string[] nTitleID = new string[] { }; string[] nTitle = new string[] { }; double[] nPrice = new double[] { }; bool NError = false;
            m.Notif(ref N, ref nLend, ref nMemID, ref nMemType, ref nBookID, ref nTitleID, ref nTitle, ref nPrice, ref NError);
            if (N == 0) f.Notif.BackColor = Color.Black;
        }
        
    }
}
