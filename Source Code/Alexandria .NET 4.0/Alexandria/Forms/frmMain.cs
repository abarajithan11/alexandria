using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Alexandria
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent(); menu.Renderer = new MyRenderer();
        }

        private void newBooksStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBook f = new frmAddBook(); f.MdiParent = this; f.Show();
        }

        private void testFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest f = new frmTest(); f.MdiParent = this; f.Show();
        }

        private void newMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemNew f = new frmMemNew(); f.MdiParent = this; f.Show();
        }

        private void memberDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemDetails f = new frmMemDetails(); f.MdiParent = this; f.Show();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            set s = new set(); s.recall();
            Methods m = new Methods(); m.MemExpire();


            if (db.con.State.Equals(ConnectionState.Open)) db.con.Close();

            //Open login form
            frmLogin f = new frmLogin(); f.ShowDialog();

            if (cvar.UType == "Mem") { Mem.Visible = true; User.Text = "Member"; }
            else if (cvar.UType == "Lib") { Issues.Visible = MgBook.Visible = MgMem.Visible = Notif.Visible = true; }
            else if (cvar.UType == "Admin") { Mem.Visible = Issues.Visible = MgBook.Visible = MgMem.Visible = Admin.Visible = Notif.Visible = EditAcc.Visible = true; }

            if (cvar.UType == "Admin" || cvar.UType == "Lib")
            {
                User.Text = cvar.UText; 

                //Check for Notifications
                if(db.con.State.Equals(ConnectionState.Closed)) db.con.Open();

                int N = 0; DateTime[] nLend = new DateTime[] { }; ; string[] nMemID = new string[] { }; string[] nMemType = new string[] { }; string[] nBookID = new string[] { }; string[] nTitleID = new string[] { }; string[] nTitle = new string[] { }; double[] nPrice = new double[] { }; bool NError = false;
                m.Notif(ref N, ref nLend, ref nMemID, ref nMemType, ref nBookID, ref nTitleID, ref nTitle, ref nPrice, ref NError);

                if (N > 0) // If notifications are there.
                {
                    Notif.BackColor = Color.Red;
                    DialogResult notif = MessageBox.Show(string.Format("There are {0} alert notifications about the books which have not been returned for a long time. Do you want to check the notification window?", N), "Alert Notifications Pending", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (notif == DialogResult.Yes) { frmNotif n = new frmNotif(); n.ShowDialog(); }
                }
                if (db.con.State.Equals(ConnectionState.Closed)) db.con.Open();
            }
        }

        private void bookIssuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssues f = new frmIssues(); f.MdiParent = this; f.Show();
            
        }

        private void loadSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            set s = new set(); s.recall();
        }

        private void bookReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnExt f = new frmReturnExt(); f.MdiParent = this; f.Show();
            
        }

        private void bookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookDetail f = new frmBookDetail(); f.MdiParent = this;
            f.Show(); 
        }

        private void removeBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemBook f = new frmRemBook(); f.MdiParent = this; f.Show();
        }

        private void preferancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetting f = new frmSetting(); f.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCash f = new frmCash(); f.MdiParent = this; f.Show();
        }

        private void notificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotif f = new frmNotif(); f.MdiParent = this; f.Show();
        }

        private void memberLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewCheckIO f = new frmViewCheckIO(); f.MdiParent = this; f.Show();
        }

        private void extrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtra f = new frmExtra(); f.MdiParent = this; f.Show();
        }

        private void bookDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmBookDetail f = new frmBookDetail(); f.Show();
        }

        private void checkInOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCheckIO f = new frmCheckIO(); f.MdiParent = this; f.Show();
        }

        private void bookSearchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmBSearch f = new frmBSearch(); f.MdiParent = this; f.Show();
        }

        //Menu selected color

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.LightGray; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.DarkGray; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.DarkSlateGray; }
            }
            public override Color MenuItemPressedGradientBegin
            {
                get
                { return Color.LightGray; }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                { return Color.DimGray; }
            }

        }

        private void updateMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemDetails f = new frmMemDetails(); f.MdiParent = this;

            f.btnUpdate.Size = f.lblButtons.Size;
            f.btnUpdate.Location = f.lblButtons.Location;
            f.btnRemove.Visible = f.btnRenew.Visible = false;
            f.Text = "Update Membership";

            f.Show();
        }

        private void renewMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemDetails f = new frmMemDetails(); f.MdiParent = this;

            f.btnRenew.Size = f.lblButtons.Size;
            f.btnRenew.Location = f.lblButtons.Location;
            f.btnRemove.Visible = f.btnUpdate.Visible = false;
            f.Text = "Renew Membership";
            f.TlblMiD.Text = " Old Member ID";

            f.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemDetails f = new frmMemDetails(); f.MdiParent = this;

            f.btnRemove.Size = f.lblButtons.Size;
            f.btnRemove.Location = f.lblButtons.Location;
            f.btnRenew.Visible = f.btnUpdate.Visible = false;
            f.Text = "Delete Membership";
            f.TlblMiD.Text = "Enter Member ID";

            f.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin(); f.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout(); f.ShowDialog();
        }

        private void EditAcc_Click(object sender, EventArgs e)
        {
            //Open User accounts in preferences.
            frmSetting f = new frmSetting();
            
            f.tabControl1.SelectedIndex = 2;
            f.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Logging off involves closing all the open windows in the application. This might result in loss of any unsaved data. Are you sure you want to continue logging off?", "Are yous sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sure == DialogResult.Yes) Application.Restart();
        }

        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opens the User guide

            string path = Path.Combine(Directory.GetCurrentDirectory(), "UserGuide.pdf");

            try
            { System.IO.File.WriteAllBytes(path, global::Alexandria.Properties.Resources.User_Guide); }
            catch { }

            try
            {
                System.Diagnostics.Process.Start(path);
                MessageBox.Show("Opening the User Guide may take a few seconds. Please wait...", "Please Wait", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("The User Guide cannot be opened at the moment"); }
        }

        private void systemDesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open System Design

            string path = Path.Combine(Directory.GetCurrentDirectory(), "SDesign.pdf");
            try {System.IO.File.WriteAllBytes(path, global::Alexandria.Properties.Resources.System_Design); }
            catch { }
            try { System.Diagnostics.Process.Start(path);
            MessageBox.Show("Opening the System Design may take a few seconds. Please wait...", "Please Wait", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            catch { MessageBox.Show("The System Design cannot be opened at the moment"); }
            
        }

        private void projectDocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Documentation
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Documentation.pdf");
            try { System.IO.File.WriteAllBytes(path, global::Alexandria.Properties.Resources.Documentation);}
            catch { } 
            
            try { System.Diagnostics.Process.Start(path); MessageBox.Show("Opening the Documentation may take a few seconds. Please wait...", "Please Wait", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            catch { MessageBox.Show("The Documentation cannot be opened at the moment"); }
            
            
            
            
        }

        private void projectCodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Coding
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Code.pdf");
            
            try {System.IO.File.WriteAllBytes(path, global::Alexandria.Properties.Resources.Project_Coding); }
            catch { } 
            try {System.Diagnostics.Process.Start(path); 
            MessageBox.Show("Opening the Project Coding may take a few seconds. Please wait...", "Please Wait", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("The Coding cannot be opened at the moment"); }
            
            
            

            
        }

    }


}
