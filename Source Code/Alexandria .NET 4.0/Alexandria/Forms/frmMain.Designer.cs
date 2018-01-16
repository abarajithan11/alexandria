namespace Alexandria
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Mem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Issues = new System.Windows.Forms.ToolStripMenuItem();
            this.bookIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReturnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MgBook = new System.Windows.Forms.ToolStripMenuItem();
            this.newBooksStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MgMem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewMembershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.projectDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemDesignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectCodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Notif = new System.Windows.Forms.ToolStripMenuItem();
            this.User = new System.Windows.Forms.ToolStripMenuItem();
            this.EditAcc = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Black;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mem,
            this.Issues,
            this.MgBook,
            this.MgMem,
            this.Admin,
            this.aboutToolStripMenuItem,
            this.Notif,
            this.User});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(1010, 26);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // Mem
            // 
            this.Mem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInOutToolStripMenuItem,
            this.bookSearchToolStripMenuItem});
            this.Mem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Mem.Name = "Mem";
            this.Mem.Size = new System.Drawing.Size(67, 22);
            this.Mem.Text = "Member";
            this.Mem.Visible = false;
            // 
            // checkInOutToolStripMenuItem
            // 
            this.checkInOutToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkInOutToolStripMenuItem.Name = "checkInOutToolStripMenuItem";
            this.checkInOutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.checkInOutToolStripMenuItem.Text = "Check In/Out";
            this.checkInOutToolStripMenuItem.Click += new System.EventHandler(this.checkInOutToolStripMenuItem_Click_1);
            // 
            // bookSearchToolStripMenuItem
            // 
            this.bookSearchToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bookSearchToolStripMenuItem.Name = "bookSearchToolStripMenuItem";
            this.bookSearchToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.bookSearchToolStripMenuItem.Text = "BookFinder";
            this.bookSearchToolStripMenuItem.Click += new System.EventHandler(this.bookSearchToolStripMenuItem_Click_1);
            // 
            // Issues
            // 
            this.Issues.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookIssuesToolStripMenuItem,
            this.bookReturnsToolStripMenuItem});
            this.Issues.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issues.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Issues.Name = "Issues";
            this.Issues.Size = new System.Drawing.Size(137, 22);
            this.Issues.Text = "Manage Book Issues";
            this.Issues.Visible = false;
            // 
            // bookIssuesToolStripMenuItem
            // 
            this.bookIssuesToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bookIssuesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.bookIssuesToolStripMenuItem.Name = "bookIssuesToolStripMenuItem";
            this.bookIssuesToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.bookIssuesToolStripMenuItem.Text = "Lend Books";
            this.bookIssuesToolStripMenuItem.Click += new System.EventHandler(this.bookIssuesToolStripMenuItem_Click);
            // 
            // bookReturnsToolStripMenuItem
            // 
            this.bookReturnsToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bookReturnsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.bookReturnsToolStripMenuItem.Name = "bookReturnsToolStripMenuItem";
            this.bookReturnsToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.bookReturnsToolStripMenuItem.Text = "Receive / Extend / Report Loss";
            this.bookReturnsToolStripMenuItem.Click += new System.EventHandler(this.bookReturnsToolStripMenuItem_Click);
            // 
            // MgBook
            // 
            this.MgBook.BackColor = System.Drawing.Color.Black;
            this.MgBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBooksStockToolStripMenuItem,
            this.removeBooksToolStripMenuItem,
            this.bookDetailsToolStripMenuItem});
            this.MgBook.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MgBook.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MgBook.Name = "MgBook";
            this.MgBook.Size = new System.Drawing.Size(103, 22);
            this.MgBook.Text = "Manage Books";
            this.MgBook.Visible = false;
            // 
            // newBooksStockToolStripMenuItem
            // 
            this.newBooksStockToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newBooksStockToolStripMenuItem.Name = "newBooksStockToolStripMenuItem";
            this.newBooksStockToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newBooksStockToolStripMenuItem.Text = "New Books Stock";
            this.newBooksStockToolStripMenuItem.Click += new System.EventHandler(this.newBooksStockToolStripMenuItem_Click);
            // 
            // removeBooksToolStripMenuItem
            // 
            this.removeBooksToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.removeBooksToolStripMenuItem.Name = "removeBooksToolStripMenuItem";
            this.removeBooksToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.removeBooksToolStripMenuItem.Text = "Remove Books";
            this.removeBooksToolStripMenuItem.Click += new System.EventHandler(this.removeBooksToolStripMenuItem_Click);
            // 
            // bookDetailsToolStripMenuItem
            // 
            this.bookDetailsToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bookDetailsToolStripMenuItem.Name = "bookDetailsToolStripMenuItem";
            this.bookDetailsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.bookDetailsToolStripMenuItem.Text = "Book Details";
            this.bookDetailsToolStripMenuItem.Click += new System.EventHandler(this.bookDetailsToolStripMenuItem_Click);
            // 
            // MgMem
            // 
            this.MgMem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMembershipToolStripMenuItem,
            this.updateMembershipToolStripMenuItem,
            this.deleteMemberToolStripMenuItem,
            this.renewMembershipToolStripMenuItem,
            this.memberDetailsToolStripMenuItem});
            this.MgMem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MgMem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MgMem.Name = "MgMem";
            this.MgMem.Size = new System.Drawing.Size(122, 22);
            this.MgMem.Text = "Manage Members";
            this.MgMem.Visible = false;
            // 
            // newMembershipToolStripMenuItem
            // 
            this.newMembershipToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newMembershipToolStripMenuItem.Name = "newMembershipToolStripMenuItem";
            this.newMembershipToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.newMembershipToolStripMenuItem.Text = "New Membership";
            this.newMembershipToolStripMenuItem.Click += new System.EventHandler(this.newMembershipToolStripMenuItem_Click);
            // 
            // updateMembershipToolStripMenuItem
            // 
            this.updateMembershipToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.updateMembershipToolStripMenuItem.Name = "updateMembershipToolStripMenuItem";
            this.updateMembershipToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.updateMembershipToolStripMenuItem.Text = "Update Membership";
            this.updateMembershipToolStripMenuItem.Click += new System.EventHandler(this.updateMembershipToolStripMenuItem_Click);
            // 
            // deleteMemberToolStripMenuItem
            // 
            this.deleteMemberToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            this.deleteMemberToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.deleteMemberToolStripMenuItem.Text = "Delete member";
            this.deleteMemberToolStripMenuItem.Click += new System.EventHandler(this.deleteMemberToolStripMenuItem_Click);
            // 
            // renewMembershipToolStripMenuItem
            // 
            this.renewMembershipToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.renewMembershipToolStripMenuItem.Name = "renewMembershipToolStripMenuItem";
            this.renewMembershipToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.renewMembershipToolStripMenuItem.Text = "Renew Membership";
            this.renewMembershipToolStripMenuItem.Click += new System.EventHandler(this.renewMembershipToolStripMenuItem_Click);
            // 
            // memberDetailsToolStripMenuItem
            // 
            this.memberDetailsToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.memberDetailsToolStripMenuItem.Name = "memberDetailsToolStripMenuItem";
            this.memberDetailsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.memberDetailsToolStripMenuItem.Text = "Member Details";
            this.memberDetailsToolStripMenuItem.Click += new System.EventHandler(this.memberDetailsToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionsToolStripMenuItem,
            this.memberLogToolStripMenuItem,
            this.extrasToolStripMenuItem,
            this.preferancesToolStripMenuItem});
            this.Admin.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(107, 22);
            this.Admin.Text = "Administration";
            this.Admin.Visible = false;
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // memberLogToolStripMenuItem
            // 
            this.memberLogToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.memberLogToolStripMenuItem.Name = "memberLogToolStripMenuItem";
            this.memberLogToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.memberLogToolStripMenuItem.Text = "Member Log";
            this.memberLogToolStripMenuItem.Click += new System.EventHandler(this.memberLogToolStripMenuItem_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.extrasToolStripMenuItem.Text = "Statistics";
            this.extrasToolStripMenuItem.Click += new System.EventHandler(this.extrasToolStripMenuItem_Click);
            // 
            // preferancesToolStripMenuItem
            // 
            this.preferancesToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.preferancesToolStripMenuItem.Name = "preferancesToolStripMenuItem";
            this.preferancesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.preferancesToolStripMenuItem.Text = "Preferences";
            this.preferancesToolStripMenuItem.Click += new System.EventHandler(this.preferancesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.projectDocumentsToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            this.userGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // projectDocumentsToolStripMenuItem
            // 
            this.projectDocumentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemDesignToolStripMenuItem,
            this.projectDocumentationToolStripMenuItem,
            this.projectCodingToolStripMenuItem});
            this.projectDocumentsToolStripMenuItem.Name = "projectDocumentsToolStripMenuItem";
            this.projectDocumentsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.projectDocumentsToolStripMenuItem.Text = "Project Documents";
            // 
            // systemDesignToolStripMenuItem
            // 
            this.systemDesignToolStripMenuItem.Name = "systemDesignToolStripMenuItem";
            this.systemDesignToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.systemDesignToolStripMenuItem.Text = "System Design Blueprints";
            this.systemDesignToolStripMenuItem.Click += new System.EventHandler(this.systemDesignToolStripMenuItem_Click);
            // 
            // projectDocumentationToolStripMenuItem
            // 
            this.projectDocumentationToolStripMenuItem.Name = "projectDocumentationToolStripMenuItem";
            this.projectDocumentationToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.projectDocumentationToolStripMenuItem.Text = "Documentation";
            this.projectDocumentationToolStripMenuItem.Click += new System.EventHandler(this.projectDocumentationToolStripMenuItem_Click);
            // 
            // projectCodingToolStripMenuItem
            // 
            this.projectCodingToolStripMenuItem.Name = "projectCodingToolStripMenuItem";
            this.projectCodingToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.projectCodingToolStripMenuItem.Text = "Project Coding";
            this.projectCodingToolStripMenuItem.Click += new System.EventHandler(this.projectCodingToolStripMenuItem_Click);
            // 
            // Notif
            // 
            this.Notif.ForeColor = System.Drawing.Color.White;
            this.Notif.Name = "Notif";
            this.Notif.Size = new System.Drawing.Size(87, 22);
            this.Notif.Text = "Notifications";
            this.Notif.Visible = false;
            this.Notif.Click += new System.EventHandler(this.notificationsToolStripMenuItem_Click);
            // 
            // User
            // 
            this.User.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.User.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAcc,
            this.logOutToolStripMenuItem});
            this.User.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(95, 22);
            this.User.Text = "Not Logged In";
            // 
            // EditAcc
            // 
            this.EditAcc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EditAcc.Name = "EditAcc";
            this.EditAcc.Size = new System.Drawing.Size(147, 22);
            this.EditAcc.Text = "Edit Accounts";
            this.EditAcc.Visible = false;
            this.EditAcc.Click += new System.EventHandler(this.EditAcc_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Help
            // 
            this.Help.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(46, 22);
            this.Help.Text = "Help";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alexandria.Properties.Resources.Main_Large;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1010, 320);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alexandria : The Integrated Library System [ALPHA]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        public System.Windows.Forms.ToolStripMenuItem Help;
        public System.Windows.Forms.ToolStripMenuItem Mem;
        public System.Windows.Forms.ToolStripMenuItem Admin;
        public System.Windows.Forms.ToolStripMenuItem Issues;
        public System.Windows.Forms.ToolStripMenuItem MgMem;
        public System.Windows.Forms.ToolStripMenuItem MgBook;
        public System.Windows.Forms.ToolStripMenuItem Notif;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookIssuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReturnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBooksStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMembershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem User;
        private System.Windows.Forms.ToolStripMenuItem EditAcc;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem projectDocumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemDesignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectDocumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectCodingToolStripMenuItem;
        
        
    }
}

