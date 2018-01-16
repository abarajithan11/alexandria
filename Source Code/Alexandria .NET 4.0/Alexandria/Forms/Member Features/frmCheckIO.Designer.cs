namespace Alexandria
{
    partial class frmCheckIO
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
            this.btnIn = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMemID
            // 
            this.txtMemID.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemID.Location = new System.Drawing.Point(380, 73);
            this.txtMemID.MaxLength = 5;
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(133, 33);
            this.txtMemID.TabIndex = 0;
            this.txtMemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(237)))), ((int)(((byte)(219)))));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member ID  :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(282, 143);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(118, 29);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "Check In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(406, 143);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(118, 29);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Check Out";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alexandria.Properties.Resources.CheckIO;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(695, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmCheckIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 373);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCheckIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In, Check Out";
            this.Load += new System.EventHandler(this.frmCheckIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}