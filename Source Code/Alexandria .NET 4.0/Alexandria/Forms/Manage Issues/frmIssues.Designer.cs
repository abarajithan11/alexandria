namespace Alexandria
{
    partial class frmIssues
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
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMemID
            // 
            this.txtMemID.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemID.Location = new System.Drawing.Point(91, 123);
            this.txtMemID.MaxLength = 5;
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(133, 30);
            this.txtMemID.TabIndex = 0;
            this.txtMemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member ID";
            // 
            // txtBookID
            // 
            this.txtBookID.Enabled = false;
            this.txtBookID.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(91, 204);
            this.txtBookID.MaxLength = 5;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(133, 30);
            this.txtBookID.TabIndex = 0;
            this.txtBookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBookID.Visible = false;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.lblBookID.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(132, 181);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(59, 20);
            this.lblBookID.TabIndex = 1;
            this.lblBookID.Text = "Book ID";
            this.lblBookID.Visible = false;
            // 
            // btnIssue
            // 
            this.btnIssue.Enabled = false;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(248, 204);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(118, 30);
            this.btnIssue.TabIndex = 2;
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Visible = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnSet
            // 
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(248, 123);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(118, 30);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "Check Member";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(277, 268);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 24);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alexandria.Properties.Resources.Lend;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 493);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 491);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIssues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Book";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}