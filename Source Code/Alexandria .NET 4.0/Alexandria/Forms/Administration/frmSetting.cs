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
    public partial class frmSetting : Form
    {
        bool isSave = false;


        public frmSetting()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                //Call method to save
                setSave();
            }
        }

        private void setSave()
        {
            //Disclaim free boxes
            if (AtxtBTime.Text == "" || CtxtBTime.Text == "" || AtxtNoBooks.Text == "" || CtxtNoBooks.Text == "" || AtxtExpire.Text == "" || CtxtExpire.Text == "" || AtxtAlert.Text == "" || CtxtAlert.Text == "" || AtxtLostBookTimes.Text == "" || CtxtLostBookTimes.Text == "" || AtxtNewC.Text == "" || CtxtNewC.Text == "" || AtxtRenewC.Text == "" || CtxtRenewC.Text == "")
            { MessageBox.Show("No fields should be left blank. Fill all fields with numbers and try again", "Blank values", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            //Remove aingle double quotes in textboxes
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }

            //Declarations, move all text to two string arrays and variable
            string[,] SValueSI = new string[,] { { AtxtBTime.Text, CtxtBTime.Text }, { AtxtNoBooks.Text, CtxtNoBooks.Text }, { AtxtExpire.Text, CtxtExpire.Text }, { AtxtAlert.Text, CtxtAlert.Text }, { AtxtLostBookTimes.Text, CtxtLostBookTimes.Text } };
            string[,] SValueSD = new string[,] { { AtxtFine.Text, CtxtFine.Text }, { AtxtRenewC.Text, CtxtRenewC.Text }, { AtxtNewC.Text, CtxtNewC.Text } };
            string AgeMinS = AtxtAgeMin.Text;

            //Declare arrays of column names of Setting table for DB purposes.
            string[] SType = new string[] { "A", "C" };
            string[] SNameI = new string[] { "Btime", "NoBooks", "Expire", "Alert", "LostBookTimes" };
            string[] SNameD = new string[] { "Fine", "RenewC", "NewC" };

            //Create a double and int arrays and variable
            int[,] SValueI = new int[,] { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 } };
            double[,] SValueD = new double[,] { { 0, 0 }, { 0, 0 }, { 0, 0 } };
            int AgeMinI;

            //Try Parsing in Main for loop for each dimension set in SValueSI
            for (int i = 0; i < SValueSI.Length / 2; i++)
            {
                //Try parsing each item of each dimension set of SValueSI
                for (int j = 0; j < 2; j++)
                {
                    //Try to parse respective values to int and move them to integer array.
                    bool isNum = int.TryParse(SValueSI[i, j], out SValueI[i, j]);

                    //If not an integer, raise message and stop.
                    if (isNum == false) { MessageBox.Show("One or many of the values you entered is invalid. Please correct them and and try saving agian.", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
                }
            }

            //Try Parsing in Main for loop for each dimension set in SValueSI
            for (int i = 0; i < SValueSD.Length / 2; i++)
            {
                //Try parsing each item of each dimension set of SValueSI
                for (int j = 0; j < 2; j++)
                {
                    //Try to parse respective values to int and move them to double array.
                    bool isNum = double.TryParse(SValueSD[i, j], out SValueD[i, j]);

                    //If not a double, raise message and stop.
                    if (isNum == false) { MessageBox.Show("One or many of the values you entered is invalid. Please correct them and and try saving agian.", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
                }
            }
            //Try Parsing AgeMin
            bool isNum1 = int.TryParse(AgeMinS, out AgeMinI);
            if (isNum1 == false) { MessageBox.Show("The mimum age value you entered is not a valid number. Please correct it and and try saving agian.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }

            //Disclaimer
            DialogResult sure = MessageBox.Show("Are you sure you want to update the preference data with these values?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sure == DialogResult.No) goto End; // If disagree, stop.




            //     If agree, continue, add values to database

            //Open connection
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();

            // Main For loop of Int to repeatedly add interger values to DB (using SNameI) and add values from SValue[*,_] 10 times.
            for (int iSN = 0; iSN < SNameI.Length; iSN++)
            {
                // Sub for loop to repeatedly add values to DB (using SType) and add from SValue[_,*] twice during each main loop.
                for (int iST = 0; iST < SType.Length; iST++)
                {
                    string sqlSet = string.Format("UPDATE Setting SET SValue = {0} WHERE SName = '{1}' AND SType = '{2}'", SValueI[iSN, iST], SNameI[iSN], SType[iST]);
                    OleDbCommand cmdSet = new OleDbCommand(sqlSet, db.con); cmdSet.ExecuteNonQuery();
                }
            }

            // Main For loop of double to repeatedly retrive double values from DB (using SNameD) and add values to SValue[*,_] 15 times.
            for (int iSN = 0; iSN < SNameD.Length; iSN++)
            {
                // Sub for loop to repeatedly add values from DB (using SType) and add to SValue[_,*] twice during each main loop.
                for (int iST = 0; iST < SType.Length; iST++)
                {
                    string sqlSet = string.Format("UPDATE Setting SET SValue = {0} WHERE SName = '{1}' AND SType = '{2}'", SValueD[iSN, iST], SNameD[iSN], SType[iST]);
                    OleDbCommand cmdSet = new OleDbCommand(sqlSet, db.con); cmdSet.ExecuteNonQuery();
                }
            }

            string sqlSetAge = string.Format("UPDATE Setting SET SValue = {0} WHERE SName = 'AgeMin'", AgeMinI);
            OleDbCommand cmdSetAge = new OleDbCommand(sqlSetAge, db.con); cmdSetAge.ExecuteNonQuery();

            //Recall The new settings
            set s = new set(); s.recall();

            //All successfull
            MessageBox.Show("Preferences have been saved succesfully", "Saving successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            isSave = true;

        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close(); ;
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            //Load settings from set vaiables to textboxes

            AtxtAgeMin.Text = set.AgeMin.ToString();
            AtxtAlert.Text = set.Alert[0].ToString();
            AtxtBTime.Text = set.Btime[0].ToString();
            AtxtExpire.Text = set.Expire[0].ToString();
            AtxtFine.Text = set.Fine[0].ToString();
            AtxtLostBookTimes.Text = set.LostBookTimes[0].ToString();
            AtxtNewC.Text = set.NewC[0].ToString();
            AtxtNoBooks.Text = set.NoBooks[0].ToString();
            AtxtRenewC.Text = set.RenewC[0].ToString();

            CtxtAlert.Text = set.Alert[1].ToString();
            CtxtBTime.Text = set.Btime[1].ToString();
            CtxtExpire.Text = set.Expire[1].ToString();
            CtxtFine.Text = set.Fine[1].ToString();
            CtxtLostBookTimes.Text = set.LostBookTimes[1].ToString();
            CtxtNewC.Text = set.NewC[1].ToString();
            CtxtNoBooks.Text = set.NoBooks[1].ToString();
            CtxtRenewC.Text = set.RenewC[1].ToString();

            isSave = true;
            
        }

        private void frmSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSave == false)
            {
                //Disclaimer
                DialogResult sure = MessageBox.Show("Do you want to exit without saving these preferences?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sure == DialogResult.Yes){ }
                else e.Cancel = true; // If disagree, stop closing.
            }
        if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void falseSave(object sender, EventArgs e)
        {
            isSave = false;
        }

        private void btnExit_Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            //Check Null
            if(cboxUTy.Text =="" || txtPW.Text == "" || txtUN.Text == "")
            { MessageBox.Show("Required fields cannot not be left blank.", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            //Remove aingle double quotes in textboxes
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }

            //Declarations
            string UN = txtUN.Text, PW = txtPW.Text, Ty = cboxUTy.Text;
            if (Ty == "Administrator") Ty = "Admin";

            //Check Valid
            string sqlCheck = string.Format("SELECT * FROM UserAccount WHERE UName = '{0}' AND UType = '{1}' AND Pwd = '{2}'", UN, Ty, PW);
            OleDbCommand cmdCheck = new OleDbCommand(sqlCheck, db.con);
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drCheck = cmdCheck.ExecuteReader(); drCheck.Read();

            if (!drCheck.HasRows) { MessageBox.Show("No User account with such combination exists.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }

            //Verify Delete
            DialogResult sure = MessageBox.Show("Are you sure you want to remove this account? This action cannot be undone.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sure != DialogResult.Yes) goto End;

            string sqlRem = string.Format("DELETE FROM UserAccount WHERE UName = '{0}' AND UType = '{1}' AND Pwd = '{2}'", UN, Ty, PW);
            OleDbCommand cmdRem = new OleDbCommand(sqlRem, db.con); cmdRem.ExecuteNonQuery();

            //Success
            MessageBox.Show("The user account has been deleted successfully.", "Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset Controls
            txtPW.Text = txtUN.Text = cboxUTy.Text = "";

        End: if(db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Check Null
            if (cboxUTy.Text == "" || txtPW.Text == "" || txtUN.Text == "")
            { MessageBox.Show("Required fields cannot not be left blank.", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            //Remove aingle double quotes in textboxes
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }

            //Declarations
            string UN = txtUN.Text, PW = txtPW.Text, Ty = cboxUTy.Text;
            if (Ty == "Administrator") Ty = "Admin";

            //Check If already present
            string sqlCheck = string.Format("SELECT UName FROM UserAccount WHERE UName = '{0}'", UN);
            OleDbCommand cmdCheck = new OleDbCommand(sqlCheck, db.con);
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drCheck = cmdCheck.ExecuteReader(); drCheck.Read();

            if (drCheck.HasRows) { MessageBox.Show("This username is already in use. Please choose a new username", "Username in use.", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }


            string sqlNew = string.Format("INSERT INTO UserAccount (UName, UType, Pwd) VALUES ('{0}', '{1}', '{2}')", UN, Ty, PW);
            OleDbCommand cmdNew = new OleDbCommand(sqlNew, db.con); cmdNew.ExecuteNonQuery();

            //Success
            MessageBox.Show("New User account has been created successfully.", "Creation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset Controls
            txtPW.Text = txtUN.Text = cboxUTy.Text = "";


        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            //Check Null
            if (cboxUTyCh.Text == "" || txtPWOld.Text == "" || txtUNOld.Text == "")
            { MessageBox.Show("Required fields cannot not be left blank.", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            //Remove aingle double quotes in textboxes
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }

            //Declarations
            string UNold = txtUNOld.Text, PWold = txtPWOld.Text, Ty = cboxUTyCh.Text;
            if (Ty == "Administrator") Ty = "Admin";

            //Check Valid
            string sqlCheck = string.Format("SELECT UName FROM UserAccount WHERE UName = '{0}' AND UType = '{1}' AND Pwd = '{2}'", UNold, Ty, PWold);
            OleDbCommand cmdCheck = new OleDbCommand(sqlCheck, db.con);
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            OleDbDataReader drCheck = cmdCheck.ExecuteReader(); drCheck.Read();

            if (!drCheck.HasRows) { MessageBox.Show("No User account with such combination exists.", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            //If valid, continue..

            btnSet.Enabled = txtPWOld.Enabled = txtUNOld.Enabled = cboxUTyCh.Enabled = false;
            btnUpdate.Enabled = txtUNNew.Enabled = txtPWNew1.Enabled = txtPWNew2.Enabled = true;
            txtUNNew.Text = UNold;


        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Check Null
            if (txtPWNew1.Text == "" || txtUNNew.Text == "" || txtPWNew2.Text == "")
            { MessageBox.Show("Required fields cannot not be left blank.", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            //Remove aingle double quotes in textboxes
            foreach (Control c in this.Controls) { if (c is TextBox || c is ComboBox) { c.Text = c.Text.Replace("'", ""); c.Text = c.Text.Replace("\"", ""); } }

            //Check both new passwords
            if (txtPWNew1.Text != txtPWNew2.Text) { MessageBox.Show("Passwords mismatch. Repeated Password should be Identical to the new password. Try again.", "Passwords Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error); goto End; }
            
            //Declarations
            string PW = txtPWNew1.Text, UNnew = txtUNNew.Text, UNold = txtUNOld.Text;

            string sqlUpdate = string.Format("UPDATE UserAccount SET UName = '{0}', Pwd = '{1}' WHERE UName = '{2}'", UNnew, PW, UNold);
            OleDbCommand cmdUpdate = new OleDbCommand(sqlUpdate, db.con);
            if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open(); cmdUpdate.ExecuteNonQuery();

            //Success
            MessageBox.Show("User account has been updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset Form
            cboxUTyCh.Text = txtPWNew1.Text = txtPWNew2.Text = txtPWOld.Text = txtUNNew.Text = txtUNOld.Text = "";
            btnSet.Enabled = txtPWOld.Enabled = txtUNOld.Enabled = cboxUTyCh.Enabled = true;
            btnUpdate.Enabled = txtUNNew.Enabled = txtPWNew1.Enabled = txtPWNew2.Enabled = false;

        End: if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();
        }


    }
}
