namespace Alexandria
{
    partial class frmBookDetail
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
            this.txtTitleID = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetTitle = new System.Windows.Forms.Button();
            this.btnGetBook = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLLTimes = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblLLNoBooks = new System.Windows.Forms.Label();
            this.lblLLNoAvail = new System.Windows.Forms.Label();
            this.lblLLAvail = new System.Windows.Forms.Label();
            this.lblLLLentTo = new System.Windows.Forms.Label();
            this.lblLLLentOn = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPublish = new System.Windows.Forms.Label();
            this.lblPg = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTy = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPop = new System.Windows.Forms.Label();
            this.lblNoBooks = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.lblAvNo = new System.Windows.Forms.Label();
            this.lblAvail = new System.Windows.Forms.Label();
            this.lblLentTo = new System.Windows.Forms.Label();
            this.lblLentOn = new System.Windows.Forms.Label();
            this.btnRemtitle = new System.Windows.Forms.Button();
            this.btnRemBook = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLLFine = new System.Windows.Forms.Label();
            this.lblFine = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitleID
            // 
            this.txtTitleID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleID.Location = new System.Drawing.Point(369, 49);
            this.txtTitleID.MaxLength = 5;
            this.txtTitleID.Name = "txtTitleID";
            this.txtTitleID.Size = new System.Drawing.Size(110, 26);
            this.txtTitleID.TabIndex = 0;
            this.txtTitleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(600, 49);
            this.txtBookID.MaxLength = 5;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(107, 26);
            this.txtBookID.TabIndex = 0;
            this.txtBookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(77)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(522, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "BookID  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(77)))), ((int)(((byte)(20)))));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(292, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TitleID  :";
            // 
            // btnGetTitle
            // 
            this.btnGetTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(187)))), ((int)(((byte)(164)))));
            this.btnGetTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetTitle.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTitle.ForeColor = System.Drawing.Color.Black;
            this.btnGetTitle.Location = new System.Drawing.Point(296, 85);
            this.btnGetTitle.Name = "btnGetTitle";
            this.btnGetTitle.Size = new System.Drawing.Size(183, 28);
            this.btnGetTitle.TabIndex = 2;
            this.btnGetTitle.Text = "Get Title Details";
            this.btnGetTitle.UseVisualStyleBackColor = false;
            this.btnGetTitle.Click += new System.EventHandler(this.btnGetTitle_Click);
            // 
            // btnGetBook
            // 
            this.btnGetBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(187)))), ((int)(((byte)(164)))));
            this.btnGetBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetBook.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetBook.ForeColor = System.Drawing.Color.Black;
            this.btnGetBook.Location = new System.Drawing.Point(527, 85);
            this.btnGetBook.Name = "btnGetBook";
            this.btnGetBook.Size = new System.Drawing.Size(180, 28);
            this.btnGetBook.TabIndex = 2;
            this.btnGetBook.Text = "Get Book Details";
            this.btnGetBook.UseVisualStyleBackColor = false;
            this.btnGetBook.Click += new System.EventHandler(this.btnGetBook_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Title  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(619, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Genre  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(605, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Publisher  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(220)))));
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pages";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(329, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Type  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(220)))));
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(725, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(216)))));
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(793, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Popularity";
            // 
            // lblLLTimes
            // 
            this.lblLLTimes.AutoSize = true;
            this.lblLLTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(215)))));
            this.lblLLTimes.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLLTimes.Location = new System.Drawing.Point(329, 425);
            this.lblLLTimes.Name = "lblLLTimes";
            this.lblLLTimes.Size = new System.Drawing.Size(123, 18);
            this.lblLLTimes.TabIndex = 3;
            this.lblLLTimes.Text = "Times Borrowed    :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(225)))));
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(329, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "ISBN  :";
            // 
            // lblLLNoBooks
            // 
            this.lblLLNoBooks.AutoSize = true;
            this.lblLLNoBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(215)))));
            this.lblLLNoBooks.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLLNoBooks.Location = new System.Drawing.Point(349, 451);
            this.lblLLNoBooks.Name = "lblLLNoBooks";
            this.lblLLNoBooks.Size = new System.Drawing.Size(103, 18);
            this.lblLLNoBooks.TabIndex = 3;
            this.lblLLNoBooks.Text = "No. of Books    :";
            // 
            // lblLLNoAvail
            // 
            this.lblLLNoAvail.AutoSize = true;
            this.lblLLNoAvail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(215)))));
            this.lblLLNoAvail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLLNoAvail.Location = new System.Drawing.Point(332, 475);
            this.lblLLNoAvail.Name = "lblLLNoAvail";
            this.lblLLNoAvail.Size = new System.Drawing.Size(120, 18);
            this.lblLLNoAvail.TabIndex = 3;
            this.lblLLNoAvail.Text = "Available Books    :";
            // 
            // lblLLAvail
            // 
            this.lblLLAvail.AutoSize = true;
            this.lblLLAvail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(215)))));
            this.lblLLAvail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLLAvail.Location = new System.Drawing.Point(611, 427);
            this.lblLLAvail.Name = "lblLLAvail";
            this.lblLLAvail.Size = new System.Drawing.Size(73, 18);
            this.lblLLAvail.TabIndex = 3;
            this.lblLLAvail.Text = "Availability";
            // 
            // lblLLLentTo
            // 
            this.lblLLLentTo.AutoSize = true;
            this.lblLLLentTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(215)))));
            this.lblLLLentTo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLLLentTo.Location = new System.Drawing.Point(708, 466);
            this.lblLLLentTo.Name = "lblLLLentTo";
            this.lblLLLentTo.Size = new System.Drawing.Size(66, 18);
            this.lblLLLentTo.TabIndex = 3;
            this.lblLLLentTo.Text = "Lent To  :";
            // 
            // lblLLLentOn
            // 
            this.lblLLLentOn.AutoSize = true;
            this.lblLLLentOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(215)))));
            this.lblLLLentOn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLLLentOn.Location = new System.Drawing.Point(758, 407);
            this.lblLLLentOn.Name = "lblLLLentOn";
            this.lblLLLentOn.Size = new System.Drawing.Size(58, 18);
            this.lblLLLentOn.TabIndex = 3;
            this.lblLLLentOn.Text = "Lent On ";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(381, 201);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 39);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAuthor.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(685, 205);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(152, 27);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenre
            // 
            this.lblGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGenre.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(381, 317);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(170, 27);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPublish
            // 
            this.lblPublish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblPublish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPublish.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublish.Location = new System.Drawing.Point(685, 270);
            this.lblPublish.Name = "lblPublish";
            this.lblPublish.Size = new System.Drawing.Size(152, 27);
            this.lblPublish.TabIndex = 3;
            this.lblPublish.Text = "Publisher";
            this.lblPublish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPg
            // 
            this.lblPg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblPg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPg.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPg.Location = new System.Drawing.Point(614, 358);
            this.lblPg.Name = "lblPg";
            this.lblPg.Size = new System.Drawing.Size(64, 27);
            this.lblPg.TabIndex = 3;
            this.lblPg.Text = "Pages";
            this.lblPg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblISBN
            // 
            this.lblISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblISBN.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(381, 368);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(170, 27);
            this.lblISBN.TabIndex = 3;
            this.lblISBN.Text = "ISBN";
            this.lblISBN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTy
            // 
            this.lblTy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblTy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTy.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTy.Location = new System.Drawing.Point(381, 265);
            this.lblTy.Name = "lblTy";
            this.lblTy.Size = new System.Drawing.Size(170, 27);
            this.lblTy.TabIndex = 3;
            this.lblTy.Text = "Type";
            this.lblTy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(711, 358);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 27);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPop
            // 
            this.lblPop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblPop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPop.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPop.Location = new System.Drawing.Point(796, 358);
            this.lblPop.Name = "lblPop";
            this.lblPop.Size = new System.Drawing.Size(55, 27);
            this.lblPop.TabIndex = 3;
            this.lblPop.Text = "Popularity";
            this.lblPop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoBooks
            // 
            this.lblNoBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblNoBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNoBooks.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBooks.Location = new System.Drawing.Point(463, 451);
            this.lblNoBooks.Name = "lblNoBooks";
            this.lblNoBooks.Size = new System.Drawing.Size(53, 20);
            this.lblNoBooks.TabIndex = 3;
            this.lblNoBooks.Text = "No. of Books";
            this.lblNoBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimes
            // 
            this.lblTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblTimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimes.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimes.Location = new System.Drawing.Point(463, 425);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(53, 20);
            this.lblTimes.TabIndex = 3;
            this.lblTimes.Text = "Times Borrowed";
            this.lblTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvNo
            // 
            this.lblAvNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblAvNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvNo.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvNo.Location = new System.Drawing.Point(463, 477);
            this.lblAvNo.Name = "lblAvNo";
            this.lblAvNo.Size = new System.Drawing.Size(53, 20);
            this.lblAvNo.TabIndex = 3;
            this.lblAvNo.Text = "Available Books";
            this.lblAvNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvail
            // 
            this.lblAvail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblAvail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvail.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvail.Location = new System.Drawing.Point(608, 450);
            this.lblAvail.Name = "lblAvail";
            this.lblAvail.Size = new System.Drawing.Size(76, 24);
            this.lblAvail.TabIndex = 3;
            this.lblAvail.Text = "Availability";
            this.lblAvail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLentTo
            // 
            this.lblLentTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblLentTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLentTo.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLentTo.Location = new System.Drawing.Point(780, 466);
            this.lblLentTo.Name = "lblLentTo";
            this.lblLentTo.Size = new System.Drawing.Size(65, 20);
            this.lblLentTo.TabIndex = 3;
            this.lblLentTo.Text = "Lent To";
            this.lblLentTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLentTo.Click += new System.EventHandler(this.lblLentTo_Click);
            // 
            // lblLentOn
            // 
            this.lblLentOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblLentOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLentOn.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLentOn.Location = new System.Drawing.Point(720, 425);
            this.lblLentOn.Name = "lblLentOn";
            this.lblLentOn.Size = new System.Drawing.Size(125, 20);
            this.lblLentOn.TabIndex = 3;
            this.lblLentOn.Text = "Lent On";
            this.lblLentOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemtitle
            // 
            this.btnRemtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(211)))), ((int)(((byte)(198)))));
            this.btnRemtitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemtitle.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemtitle.Location = new System.Drawing.Point(314, 533);
            this.btnRemtitle.Name = "btnRemtitle";
            this.btnRemtitle.Size = new System.Drawing.Size(115, 30);
            this.btnRemtitle.TabIndex = 4;
            this.btnRemtitle.Text = "Remove Title";
            this.btnRemtitle.UseVisualStyleBackColor = false;
            this.btnRemtitle.Click += new System.EventHandler(this.btnRemtitle_Click);
            // 
            // btnRemBook
            // 
            this.btnRemBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(211)))), ((int)(((byte)(198)))));
            this.btnRemBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemBook.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemBook.Location = new System.Drawing.Point(435, 533);
            this.btnRemBook.Name = "btnRemBook";
            this.btnRemBook.Size = new System.Drawing.Size(120, 30);
            this.btnRemBook.TabIndex = 4;
            this.btnRemBook.Text = "Remove Book";
            this.btnRemBook.UseVisualStyleBackColor = false;
            this.btnRemBook.Click += new System.EventHandler(this.btnRemBook_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(211)))), ((int)(((byte)(198)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(741, 533);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLLFine
            // 
            this.lblLLFine.AutoSize = true;
            this.lblLLFine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(215)))));
            this.lblLLFine.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLLFine.Location = new System.Drawing.Point(669, 495);
            this.lblLLFine.Name = "lblLLFine";
            this.lblLLFine.Size = new System.Drawing.Size(105, 18);
            this.lblLLFine.TabIndex = 3;
            this.lblLLFine.Text = "Fines for Book  :";
            // 
            // lblFine
            // 
            this.lblFine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(215)))));
            this.lblFine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFine.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.Location = new System.Drawing.Point(780, 494);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(65, 20);
            this.lblFine.TabIndex = 3;
            this.lblFine.Text = "Fines";
            this.lblFine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(211)))), ((int)(((byte)(198)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(611, 533);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 30);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alexandria.Properties.Resources.Book_Details1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 590);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // frmBookDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 589);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemBook);
            this.Controls.Add(this.btnRemtitle);
            this.Controls.Add(this.lblFine);
            this.Controls.Add(this.lblLentOn);
            this.Controls.Add(this.lblLLFine);
            this.Controls.Add(this.lblLLLentOn);
            this.Controls.Add(this.lblLentTo);
            this.Controls.Add(this.lblLLLentTo);
            this.Controls.Add(this.lblAvail);
            this.Controls.Add(this.lblLLAvail);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblPg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAvNo);
            this.Controls.Add(this.lblLLNoAvail);
            this.Controls.Add(this.lblTimes);
            this.Controls.Add(this.lblLLTimes);
            this.Controls.Add(this.lblPublish);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNoBooks);
            this.Controls.Add(this.lblLLNoBooks);
            this.Controls.Add(this.lblPop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGetBook);
            this.Controls.Add(this.btnGetTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.txtTitleID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Details";
            this.Load += new System.EventHandler(this.frmBookDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetTitle;
        private System.Windows.Forms.Button btnGetBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblLLTimes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblLLNoBooks;
        private System.Windows.Forms.Label lblLLNoAvail;
        private System.Windows.Forms.Label lblLLAvail;
        private System.Windows.Forms.Label lblLLLentTo;
        private System.Windows.Forms.Label lblLLLentOn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPublish;
        private System.Windows.Forms.Label lblPg;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTy;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPop;
        private System.Windows.Forms.Label lblNoBooks;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.Label lblAvNo;
        private System.Windows.Forms.Label lblAvail;
        private System.Windows.Forms.Label lblLentTo;
        private System.Windows.Forms.Label lblLentOn;
        private System.Windows.Forms.Button btnRemtitle;
        private System.Windows.Forms.Button btnRemBook;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLLFine;
        private System.Windows.Forms.Label lblFine;
        public System.Windows.Forms.TextBox txtTitleID;
        public System.Windows.Forms.TextBox txtBookID;
        public System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}