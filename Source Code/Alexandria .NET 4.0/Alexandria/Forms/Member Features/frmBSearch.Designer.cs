namespace Alexandria
{
    partial class frmBSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPg2 = new System.Windows.Forms.TextBox();
            this.txtPg1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.txtPub = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtResults = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboxSort = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResults)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtPg2);
            this.groupBox2.Controls.Add(this.txtPg1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(833, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 51);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "No. of pages between";
            // 
            // txtPg2
            // 
            this.txtPg2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPg2.Location = new System.Drawing.Point(98, 22);
            this.txtPg2.Name = "txtPg2";
            this.txtPg2.Size = new System.Drawing.Size(57, 24);
            this.txtPg2.TabIndex = 1;
            this.txtPg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPg1
            // 
            this.txtPg1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPg1.Location = new System.Drawing.Point(6, 22);
            this.txtPg1.Name = "txtPg1";
            this.txtPg1.Size = new System.Drawing.Size(57, 24);
            this.txtPg1.TabIndex = 1;
            this.txtPg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "and";
            // 
            // cboxType
            // 
            this.cboxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxType.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Items.AddRange(new object[] {
            "Adult Lending",
            "Child Lending",
            "Reference",
            "All"});
            this.cboxType.Location = new System.Drawing.Point(621, 412);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(99, 25);
            this.cboxType.TabIndex = 2;
            // 
            // txtPub
            // 
            this.txtPub.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPub.Location = new System.Drawing.Point(728, 412);
            this.txtPub.Name = "txtPub";
            this.txtPub.Size = new System.Drawing.Size(99, 24);
            this.txtPub.TabIndex = 1;
            this.txtPub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(535, 412);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(79, 24);
            this.txtGenre.TabIndex = 1;
            this.txtGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(414, 412);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(115, 24);
            this.txtAuthor.TabIndex = 1;
            this.txtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(273, 412);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(135, 24);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(741, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Publisher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(640, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Book Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(556, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1000, 429);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search Titles";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtResults
            // 
            this.dtResults.AllowUserToAddRows = false;
            this.dtResults.AllowUserToDeleteRows = false;
            this.dtResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtResults.BackgroundColor = System.Drawing.Color.White;
            this.dtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtResults.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtResults.ColumnHeadersHeight = 25;
            this.dtResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtResults.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtResults.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtResults.Location = new System.Drawing.Point(244, 26);
            this.dtResults.MultiSelect = false;
            this.dtResults.Name = "dtResults";
            this.dtResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtResults.RowHeadersVisible = false;
            this.dtResults.RowHeadersWidth = 20;
            this.dtResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dtResults.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtResults.Size = new System.Drawing.Size(939, 226);
            this.dtResults.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cboxSort);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1000, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 43);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort by";
            // 
            // cboxSort
            // 
            this.cboxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSort.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSort.FormattingEnabled = true;
            this.cboxSort.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Genre",
            "Popularity",
            "Pages",
            "Book Type",
            "Publisher"});
            this.cboxSort.Location = new System.Drawing.Point(13, 16);
            this.cboxSort.Name = "cboxSort";
            this.cboxSort.Size = new System.Drawing.Size(97, 24);
            this.cboxSort.TabIndex = 2;
            this.cboxSort.SelectedIndexChanged += new System.EventHandler(this.cboxSort_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alexandria.Properties.Resources.BookFinder;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 493);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmBSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtResults);
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPub);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1204, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1204, 520);
            this.Name = "frmBSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Finder";
            this.Load += new System.EventHandler(this.frmBSearch_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResults)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPg2;
        private System.Windows.Forms.TextBox txtPg1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.TextBox txtPub;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dtResults;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboxSort;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}