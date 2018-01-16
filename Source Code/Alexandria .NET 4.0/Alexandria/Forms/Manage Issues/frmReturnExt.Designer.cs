namespace Alexandria
{
    partial class frmReturnExt
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.btnExtend = new System.Windows.Forms.Button();
            this.btnLoss = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(257, 364);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(188, 32);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Receive Book";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(243)))));
            this.lblBookID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(330, 211);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(64, 22);
            this.lblBookID.TabIndex = 4;
            this.lblBookID.Text = "Book ID";
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.txtBookID.Location = new System.Drawing.Point(257, 236);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(206, 30);
            this.txtBookID.TabIndex = 3;
            this.txtBookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExtend
            // 
            this.btnExtend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExtend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtend.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtend.Location = new System.Drawing.Point(257, 402);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(188, 32);
            this.btnExtend.TabIndex = 5;
            this.btnExtend.Text = "Extend Book";
            this.btnExtend.UseVisualStyleBackColor = false;
            this.btnExtend.Visible = false;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // btnLoss
            // 
            this.btnLoss.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoss.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoss.Location = new System.Drawing.Point(257, 441);
            this.btnLoss.Name = "btnLoss";
            this.btnLoss.Size = new System.Drawing.Size(188, 36);
            this.btnLoss.TabIndex = 5;
            this.btnLoss.Text = "Report Loss and Pay";
            this.btnLoss.UseVisualStyleBackColor = false;
            this.btnLoss.Visible = false;
            this.btnLoss.Click += new System.EventHandler(this.btnLoss_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(301, 290);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(133, 29);
            this.btnSet.TabIndex = 5;
            this.btnSet.Text = "Check Book ID";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(358, 486);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 24);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alexandria.Properties.Resources.Return;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 524);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmReturnExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 522);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLoss);
            this.Controls.Add(this.btnExtend);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(754, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(754, 550);
            this.Name = "frmReturnExt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return / Extend / Report Books";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Button btnLoss;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}