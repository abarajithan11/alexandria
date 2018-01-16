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
    public partial class frmLogin : Form
    {
        string Type;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); frmLogin f = new frmLogin(); f.ShowDialog();
        }

        public void btnLogIn_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();

            //Remove single & double quoteswhich cause sql troubles
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }
            
            //If member

            if (Type == "Member") { cvar.UType = "Mem"; this.Close(); goto End; }

            //Check Null
            if ((txtPW.Text == "" || txtUser.Text == ""))
            { MessageBox.Show("Username and password fields cannot be left blank", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning); goto End; }

            //Declaratioons
            string UN = txtUser.Text, PW = txtPW.Text;

            //Check in db.
            string sqlUser = string.Format("SELECT UName FROM UserAccount WHERE UName = '{0}' AND UType = '{1}' AND Pwd = '{2}'", UN, Type, PW);
            OleDbCommand cmdUser = new OleDbCommand(sqlUser, db.con);
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drUser = cmdUser.ExecuteReader();

            //If UN, UT and PW mismatch, Error
            if (!(drUser.Read() && drUser.HasRows)) { MessageBox.Show("Username, Password and User Type mismatch. Please try again.", "Credentials Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            //Else continue


            if (Type == "Admin") cvar.UType = "Admin"; else if (Type == "Librarian") cvar.UType = "Lib"; else { goto End; };
            if (Type == "Admin" || Type == "Librarian") cvar.UText = string.Format("{0} ({1})", UN, cboxTy.Text);

        
    this.Close();
        
        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void cboxTy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTy.SelectedIndex == 0) { Type = "Member"; btnLogIn.Enabled = true; cboxTy.Enabled = false; }
            else if (cboxTy.SelectedIndex == 1) { Type = "Librarian"; gboxCred.Enabled = true; btnLogIn.Enabled = true; cboxTy.Enabled = false; }
            else if (cboxTy.SelectedIndex == 2) { Type = "Admin"; gboxCred.Enabled = true; btnLogIn.Enabled = true; cboxTy.Enabled = false; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
