namespace Alexandria
{
    partial class frmLogin
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.lbLLUN = new System.Windows.Forms.Label();
            this.lbLLPW = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboxTy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxCred = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboxCred.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(102, 24);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(143, 26);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(102, 65);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(143, 26);
            this.txtPW.TabIndex = 1;
            this.txtPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPW.UseSystemPasswordChar = true;
            // 
            // lbLLUN
            // 
            this.lbLLUN.AutoSize = true;
            this.lbLLUN.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLLUN.ForeColor = System.Drawing.Color.Black;
            this.lbLLUN.Location = new System.Drawing.Point(13, 28);
            this.lbLLUN.Name = "lbLLUN";
            this.lbLLUN.Size = new System.Drawing.Size(74, 18);
            this.lbLLUN.TabIndex = 2;
            this.lbLLUN.Text = "User Name";
            // 
            // lbLLPW
            // 
            this.lbLLPW.AutoSize = true;
            this.lbLLPW.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLLPW.ForeColor = System.Drawing.Color.Black;
            this.lbLLPW.Location = new System.Drawing.Point(21, 69);
            this.lbLLPW.Name = "lbLLPW";
            this.lbLLPW.Size = new System.Drawing.Size(66, 18);
            this.lbLLPW.TabIndex = 2;
            this.lbLLPW.Text = "Password";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogIn.Enabled = false;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Black;
            this.btnLogIn.Location = new System.Drawing.Point(437, 436);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(124, 28);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(567, 436);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(65, 28);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboxTy
            // 
            this.cboxTy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTy.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTy.FormattingEnabled = true;
            this.cboxTy.Items.AddRange(new object[] {
            "Member",
            "Librarian",
            "Administrator"});
            this.cboxTy.Location = new System.Drawing.Point(468, 269);
            this.cboxTy.Name = "cboxTy";
            this.cboxTy.Size = new System.Drawing.Size(164, 27);
            this.cboxTy.TabIndex = 3;
            this.cboxTy.SelectedIndexChanged += new System.EventHandler(this.cboxTy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(383, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Type";
            // 
            // gboxCred
            // 
            this.gboxCred.BackColor = System.Drawing.Color.White;
            this.gboxCred.Controls.Add(this.lbLLUN);
            this.gboxCred.Controls.Add(this.txtUser);
            this.gboxCred.Controls.Add(this.lbLLPW);
            this.gboxCred.Controls.Add(this.txtPW);
            this.gboxCred.Enabled = false;
            this.gboxCred.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxCred.ForeColor = System.Drawing.Color.Black;
            this.gboxCred.Location = new System.Drawing.Point(366, 312);
            this.gboxCred.Name = "gboxCred";
            this.gboxCred.Size = new System.Drawing.Size(266, 106);
            this.gboxCred.TabIndex = 4;
            this.gboxCred.TabStop = false;
            this.gboxCred.Text = "Credentials";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(366, 436);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alexandria.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 528);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 527);
            this.ControlBox = false;
            this.Controls.Add(this.gboxCred);
            this.Controls.Add(this.cboxTy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.gboxCred.ResumeLayout(false);
            this.gboxCred.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label lbLLUN;
        private System.Windows.Forms.Label lbLLPW;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboxTy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboxCred;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
    }
}