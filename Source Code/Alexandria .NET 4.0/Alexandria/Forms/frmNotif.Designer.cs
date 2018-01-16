namespace Alexandria
{
    partial class frmNotif
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.cboxDate = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboxMType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dtResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtResults)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMemID
            // 
            this.txtMemID.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemID.Location = new System.Drawing.Point(328, 445);
            this.txtMemID.MaxLength = 5;
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(141, 28);
            this.txtMemID.TabIndex = 10;
            this.txtMemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboxDate
            // 
            this.cboxDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxDate.FormattingEnabled = true;
            this.cboxDate.Items.AddRange(new object[] {
            "Last Two Months",
            "Last Six Months",
            "Past Year",
            "Last Two Years",
            "All"});
            this.cboxDate.Location = new System.Drawing.Point(681, 449);
            this.cboxDate.Name = "cboxDate";
            this.cboxDate.Size = new System.Drawing.Size(135, 25);
            this.cboxDate.TabIndex = 5;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.LightYellow;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(848, 424);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(115, 49);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Filter Notifications";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cboxMType
            // 
            this.cboxMType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMType.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMType.FormattingEnabled = true;
            this.cboxMType.Items.AddRange(new object[] {
            "Adult Member",
            "Child Member",
            "All"});
            this.cboxMType.Location = new System.Drawing.Point(502, 449);
            this.cboxMType.Name = "cboxMType";
            this.cboxMType.Size = new System.Drawing.Size(147, 25);
            this.cboxMType.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(231)))));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(728, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(231)))));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Member ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(231)))));
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Member Type";
            // 
            // lblNo
            // 
            this.lblNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(8)))), ((int)(((byte)(9)))));
            this.lblNo.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.Color.White;
            this.lblNo.Location = new System.Drawing.Point(784, 49);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(53, 30);
            this.lblNo.TabIndex = 12;
            this.lblNo.Text = "0";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = global::Alexandria.Properties.Resources.Notif;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1010, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.label21.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(428, 323);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(420, 18);
            this.label21.TabIndex = 13;
            this.label21.Text = "[Tip: Click on a Title, MemberID, BookID or TitleID to view relevant details]";
            // 
            // dtResults
            // 
            this.dtResults.AllowUserToAddRows = false;
            this.dtResults.AllowUserToDeleteRows = false;
            this.dtResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.dtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtResults.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtResults.ColumnHeadersHeight = 25;
            this.dtResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtResults.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtResults.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtResults.Location = new System.Drawing.Point(45, 94);
            this.dtResults.MultiSelect = false;
            this.dtResults.Name = "dtResults";
            this.dtResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtResults.RowHeadersVisible = false;
            this.dtResults.RowHeadersWidth = 20;
            this.dtResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dtResults.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtResults.Size = new System.Drawing.Size(800, 226);
            this.dtResults.TabIndex = 14;
            this.dtResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtResults_CellClick);
            // 
            // frmNotif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 526);
            this.Controls.Add(this.dtResults);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.txtMemID);
            this.Controls.Add(this.cboxDate);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cboxMType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNotif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alert Notifications";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNotif_FormClosed);
            this.Load += new System.EventHandler(this.frmNotif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cboxMType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dtResults;
    }
}