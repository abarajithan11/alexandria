namespace Alexandria
{
    partial class frmCash
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAmnt2 = new System.Windows.Forms.TextBox();
            this.txtAmnt1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxDate = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboxEvent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtResults = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtResults)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.groupBox2.Controls.Add(this.txtAmnt2);
            this.groupBox2.Controls.Add(this.txtAmnt1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(553, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 61);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amount between";
            // 
            // txtAmnt2
            // 
            this.txtAmnt2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmnt2.Location = new System.Drawing.Point(113, 27);
            this.txtAmnt2.Name = "txtAmnt2";
            this.txtAmnt2.Size = new System.Drawing.Size(57, 23);
            this.txtAmnt2.TabIndex = 1;
            this.txtAmnt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmnt1
            // 
            this.txtAmnt1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmnt1.Location = new System.Drawing.Point(6, 27);
            this.txtAmnt1.Name = "txtAmnt1";
            this.txtAmnt1.Size = new System.Drawing.Size(57, 23);
            this.txtAmnt1.TabIndex = 1;
            this.txtAmnt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "and";
            // 
            // cboxDate
            // 
            this.cboxDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboxDate.FormattingEnabled = true;
            this.cboxDate.Items.AddRange(new object[] {
            "Today",
            "Past Week",
            "Last Two Weeks",
            "Past Month",
            "Last Two Months",
            "Last Six Months",
            "Past Year",
            "All"});
            this.cboxDate.Location = new System.Drawing.Point(742, 69);
            this.cboxDate.Name = "cboxDate";
            this.cboxDate.Size = new System.Drawing.Size(133, 21);
            this.cboxDate.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Ivory;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(405, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(470, 28);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Filter Transactions";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboxEvent
            // 
            this.cboxEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEvent.FormattingEnabled = true;
            this.cboxEvent.Items.AddRange(new object[] {
            "New Stock",
            "New Membership",
            "Membership Renewal",
            "Fine",
            "Paid for Lost Books",
            "All"});
            this.cboxEvent.Location = new System.Drawing.Point(405, 70);
            this.cboxEvent.Name = "cboxEvent";
            this.cboxEvent.Size = new System.Drawing.Size(133, 21);
            this.cboxEvent.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(792, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Event";
            // 
            // lblTot
            // 
            this.lblTot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(253)))), ((int)(((byte)(234)))));
            this.lblTot.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.Location = new System.Drawing.Point(641, 474);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(80, 23);
            this.lblTot.TabIndex = 10;
            this.lblTot.Text = "0";
            this.lblTot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filter Transactions by:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alexandria.Properties.Resources.ViewCash;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(914, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // dtResults
            // 
            this.dtResults.AllowUserToAddRows = false;
            this.dtResults.AllowUserToDeleteRows = false;
            this.dtResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(235)))));
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
            this.dtResults.Location = new System.Drawing.Point(91, 186);
            this.dtResults.MultiSelect = false;
            this.dtResults.Name = "dtResults";
            this.dtResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtResults.RowHeadersVisible = false;
            this.dtResults.RowHeadersWidth = 20;
            this.dtResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dtResults.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtResults.Size = new System.Drawing.Size(630, 250);
            this.dtResults.TabIndex = 15;
            // 
            // frmCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 520);
            this.Controls.Add(this.dtResults);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboxDate);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboxEvent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Details";
            this.Load += new System.EventHandler(this.frmCash_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAmnt2;
        private System.Windows.Forms.TextBox txtAmnt1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxDate;
        private System.Windows.Forms.ComboBox cboxEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtResults;
    }
}