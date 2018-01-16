namespace Alexandria
{
    partial class frmViewCheckIO
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
            this.cboxDate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.cboxEvent = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboxStatus = new System.Windows.Forms.ComboBox();
            this.cboxMType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dtResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtResults)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxDate
            // 
            this.cboxDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDate.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cboxDate.Location = new System.Drawing.Point(866, 80);
            this.cboxDate.Name = "cboxDate";
            this.cboxDate.Size = new System.Drawing.Size(114, 25);
            this.cboxDate.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(210)))));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(906, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date";
            // 
            // txtMemID
            // 
            this.txtMemID.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemID.Location = new System.Drawing.Point(379, 79);
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(101, 28);
            this.txtMemID.TabIndex = 10;
            this.txtMemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboxEvent
            // 
            this.cboxEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEvent.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEvent.FormattingEnabled = true;
            this.cboxEvent.Items.AddRange(new object[] {
            "Check In",
            "Check Out",
            "Not Logged",
            "All"});
            this.cboxEvent.Location = new System.Drawing.Point(739, 80);
            this.cboxEvent.Name = "cboxEvent";
            this.cboxEvent.Size = new System.Drawing.Size(108, 25);
            this.cboxEvent.TabIndex = 5;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Cornsilk;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(1003, 55);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(96, 37);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Filter Log";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cboxStatus
            // 
            this.cboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStatus.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxStatus.FormattingEnabled = true;
            this.cboxStatus.Items.AddRange(new object[] {
            "Valid",
            "Expired",
            "Blocked",
            "All"});
            this.cboxStatus.Location = new System.Drawing.Point(617, 80);
            this.cboxStatus.Name = "cboxStatus";
            this.cboxStatus.Size = new System.Drawing.Size(107, 25);
            this.cboxStatus.TabIndex = 5;
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
            this.cboxMType.Location = new System.Drawing.Point(495, 80);
            this.cboxMType.Name = "cboxMType";
            this.cboxMType.Size = new System.Drawing.Size(107, 25);
            this.cboxMType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(210)))));
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(772, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Event";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(210)))));
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(628, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Member Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(210)))));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Member ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(210)))));
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(506, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Member Type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alexandria.Properties.Resources.ViewLog;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1113, 519);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(213)))));
            this.label21.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(643, 435);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(337, 18);
            this.label21.TabIndex = 14;
            this.label21.Text = "[Tip: Click on a MemberID or Name to view relevant details]";
            // 
            // dtResults
            // 
            this.dtResults.AllowUserToAddRows = false;
            this.dtResults.AllowUserToDeleteRows = false;
            this.dtResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(213)))));
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
            this.dtResults.Location = new System.Drawing.Point(280, 168);
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
            this.dtResults.Size = new System.Drawing.Size(737, 254);
            this.dtResults.TabIndex = 15;
            this.dtResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtResults_CellClick);
            // 
            // frmViewCheckIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 519);
            this.Controls.Add(this.dtResults);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cboxDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemID);
            this.Controls.Add(this.cboxEvent);
            this.Controls.Add(this.cboxMType);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewCheckIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Logbook";
            this.Load += new System.EventHandler(this.frmViewCheckIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cboxMType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dtResults;
    }
}