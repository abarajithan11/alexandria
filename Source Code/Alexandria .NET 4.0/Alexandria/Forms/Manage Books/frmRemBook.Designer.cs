namespace Alexandria
{
    partial class frmRemBook
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
            this.btnRBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.cboxNo = new System.Windows.Forms.ComboBox();
            this.btnRTitle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRBook
            // 
            this.btnRBook.BackColor = System.Drawing.Color.Firebrick;
            this.btnRBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRBook.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRBook.ForeColor = System.Drawing.Color.Snow;
            this.btnRBook.Location = new System.Drawing.Point(308, 187);
            this.btnRBook.Name = "btnRBook";
            this.btnRBook.Size = new System.Drawing.Size(217, 27);
            this.btnRBook.TabIndex = 4;
            this.btnRBook.Text = "Remove Book";
            this.btnRBook.UseVisualStyleBackColor = false;
            this.btnRBook.Click += new System.EventHandler(this.btnRBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.25F);
            this.label1.Location = new System.Drawing.Point(304, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "BookID  : ";
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(375, 118);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(150, 36);
            this.txtBookID.TabIndex = 2;
            this.txtBookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboxNo
            // 
            this.cboxNo.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxNo.FormattingEnabled = true;
            this.cboxNo.Items.AddRange(new object[] {
            "All"});
            this.cboxNo.Location = new System.Drawing.Point(780, 148);
            this.cboxNo.Name = "cboxNo";
            this.cboxNo.Size = new System.Drawing.Size(51, 26);
            this.cboxNo.TabIndex = 5;
            this.cboxNo.Text = "All";
            // 
            // btnRTitle
            // 
            this.btnRTitle.BackColor = System.Drawing.Color.Firebrick;
            this.btnRTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRTitle.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRTitle.ForeColor = System.Drawing.Color.Snow;
            this.btnRTitle.Location = new System.Drawing.Point(599, 187);
            this.btnRTitle.Name = "btnRTitle";
            this.btnRTitle.Size = new System.Drawing.Size(232, 27);
            this.btnRTitle.TabIndex = 4;
            this.btnRTitle.Text = "Remove Books";
            this.btnRTitle.UseVisualStyleBackColor = false;
            this.btnRTitle.Click += new System.EventHandler(this.btnRTitle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.25F);
            this.label3.Location = new System.Drawing.Point(596, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "No. of books to remove   :\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.25F);
            this.label2.Location = new System.Drawing.Point(596, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "TitleID    :";
            // 
            // txtTitleID
            // 
            this.txtTitleID.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleID.Location = new System.Drawing.Point(704, 105);
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(127, 36);
            this.txtTitleID.TabIndex = 2;
            this.txtTitleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alexandria.Properties.Resources.RemBook;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmRemBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 283);
            this.Controls.Add(this.cboxNo);
            this.Controls.Add(this.btnRBook);
            this.Controls.Add(this.btnRTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.txtTitleID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRemBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Books";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitleID;
        private System.Windows.Forms.Button btnRBook;
        private System.Windows.Forms.Button btnRTitle;
        private System.Windows.Forms.ComboBox cboxNo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}