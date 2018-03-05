namespace TheatreBooking
{
    partial class Booking
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
            System.Windows.Forms.Label lblSpecial;
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.btnBookingReturn = new System.Windows.Forms.Button();
            this.cmbMovieBook = new System.Windows.Forms.ComboBox();
            this.txtNoOfTicketsBooking = new System.Windows.Forms.TextBox();
            this.lblNoOdTicks = new System.Windows.Forms.Label();
            this.lblBookMovie = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblViewingTime = new System.Windows.Forms.Label();
            this.cmbBookingTime = new System.Windows.Forms.ComboBox();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbEnterBookingDets = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbNoWheelchair = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDisabilityBooking = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBookingHelp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            lblSpecial = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.gbEnterBookingDets.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSpecial
            // 
            lblSpecial.AutoSize = true;
            lblSpecial.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSpecial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblSpecial.Location = new System.Drawing.Point(14, 487);
            lblSpecial.Name = "lblSpecial";
            lblSpecial.Size = new System.Drawing.Size(213, 24);
            lblSpecial.TabIndex = 16;
            lblSpecial.Text = "Other Requirements";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label8.Location = new System.Drawing.Point(16, 369);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(126, 24);
            label8.TabIndex = 22;
            label8.Text = "Select Seats";
            // 
            // btnBookingReturn
            // 
            this.btnBookingReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookingReturn.BackgroundImage")));
            this.btnBookingReturn.FlatAppearance.BorderSize = 0;
            this.btnBookingReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingReturn.Font = new System.Drawing.Font("Eras Demi ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingReturn.ForeColor = System.Drawing.Color.White;
            this.btnBookingReturn.Location = new System.Drawing.Point(0, 591);
            this.btnBookingReturn.Name = "btnBookingReturn";
            this.btnBookingReturn.Size = new System.Drawing.Size(1150, 90);
            this.btnBookingReturn.TabIndex = 0;
            this.btnBookingReturn.Text = "Home";
            this.btnBookingReturn.UseCompatibleTextRendering = true;
            this.btnBookingReturn.UseVisualStyleBackColor = true;
            this.btnBookingReturn.Click += new System.EventHandler(this.btnBookingReturn_Click);
            // 
            // cmbMovieBook
            // 
            this.cmbMovieBook.FormattingEnabled = true;
            this.cmbMovieBook.Items.AddRange(new object[] {
            "Pulp Fiction",
            "Jumanji",
            "The Room",
            "Avengers: Infinity War"});
            this.cmbMovieBook.Location = new System.Drawing.Point(234, 118);
            this.cmbMovieBook.Name = "cmbMovieBook";
            this.cmbMovieBook.Size = new System.Drawing.Size(330, 39);
            this.cmbMovieBook.TabIndex = 1;
            this.cmbMovieBook.SelectedIndexChanged += new System.EventHandler(this.cmbMovieBook_SelectedIndexChanged);
            // 
            // txtNoOfTicketsBooking
            // 
            this.txtNoOfTicketsBooking.Location = new System.Drawing.Point(234, 56);
            this.txtNoOfTicketsBooking.Name = "txtNoOfTicketsBooking";
            this.txtNoOfTicketsBooking.Size = new System.Drawing.Size(330, 39);
            this.txtNoOfTicketsBooking.TabIndex = 2;
            // 
            // lblNoOdTicks
            // 
            this.lblNoOdTicks.AutoSize = true;
            this.lblNoOdTicks.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOdTicks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoOdTicks.Location = new System.Drawing.Point(16, 61);
            this.lblNoOdTicks.Name = "lblNoOdTicks";
            this.lblNoOdTicks.Size = new System.Drawing.Size(149, 24);
            this.lblNoOdTicks.TabIndex = 3;
            this.lblNoOdTicks.Text = "No Of Tickets ";
            // 
            // lblBookMovie
            // 
            this.lblBookMovie.AutoSize = true;
            this.lblBookMovie.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBookMovie.Location = new System.Drawing.Point(16, 123);
            this.lblBookMovie.Name = "lblBookMovie";
            this.lblBookMovie.Size = new System.Drawing.Size(120, 24);
            this.lblBookMovie.TabIndex = 4;
            this.lblBookMovie.Text = "Movie Title";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBookingDate.Location = new System.Drawing.Point(16, 230);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(146, 24);
            this.lblBookingDate.TabIndex = 6;
            this.lblBookingDate.Text = "Viewing Date";
            // 
            // lblViewingTime
            // 
            this.lblViewingTime.AutoSize = true;
            this.lblViewingTime.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewingTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblViewingTime.Location = new System.Drawing.Point(16, 296);
            this.lblViewingTime.Name = "lblViewingTime";
            this.lblViewingTime.Size = new System.Drawing.Size(147, 24);
            this.lblViewingTime.TabIndex = 8;
            this.lblViewingTime.Text = "Viewing Time";
            // 
            // cmbBookingTime
            // 
            this.cmbBookingTime.FormattingEnabled = true;
            this.cmbBookingTime.Items.AddRange(new object[] {
            "11:00 am",
            "12:30 pm",
            "2:00 pm",
            "4:00 pm",
            "6:00 pm",
            "8:00 pm",
            "10:00 pm",
            "12:00 am"});
            this.cmbBookingTime.Location = new System.Drawing.Point(234, 291);
            this.cmbBookingTime.Name = "cmbBookingTime";
            this.cmbBookingTime.Size = new System.Drawing.Size(330, 39);
            this.cmbBookingTime.TabIndex = 7;
            this.cmbBookingTime.SelectedIndexChanged += new System.EventHandler(this.cmbBookingTime_SelectedIndexChanged);
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Location = new System.Drawing.Point(234, 224);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(330, 39);
            this.dtpBookingDate.TabIndex = 9;
            this.dtpBookingDate.ValueChanged += new System.EventHandler(this.dtpBookingDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(188, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(188, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(188, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(188, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "*";
            // 
            // gbEnterBookingDets
            // 
            this.gbEnterBookingDets.BackColor = System.Drawing.Color.Transparent;
            this.gbEnterBookingDets.Controls.Add(label8);
            this.gbEnterBookingDets.Controls.Add(this.radioButton1);
            this.gbEnterBookingDets.Controls.Add(this.rbNoWheelchair);
            this.gbEnterBookingDets.Controls.Add(this.label2);
            this.gbEnterBookingDets.Controls.Add(this.lblDisabilityBooking);
            this.gbEnterBookingDets.Controls.Add(lblSpecial);
            this.gbEnterBookingDets.Controls.Add(this.textBox1);
            this.gbEnterBookingDets.Controls.Add(this.lblNoOdTicks);
            this.gbEnterBookingDets.Controls.Add(this.label5);
            this.gbEnterBookingDets.Controls.Add(this.cmbMovieBook);
            this.gbEnterBookingDets.Controls.Add(this.label4);
            this.gbEnterBookingDets.Controls.Add(this.txtNoOfTicketsBooking);
            this.gbEnterBookingDets.Controls.Add(this.label3);
            this.gbEnterBookingDets.Controls.Add(this.lblBookMovie);
            this.gbEnterBookingDets.Controls.Add(this.label1);
            this.gbEnterBookingDets.Controls.Add(this.lblBookingDate);
            this.gbEnterBookingDets.Controls.Add(this.dtpBookingDate);
            this.gbEnterBookingDets.Controls.Add(this.cmbBookingTime);
            this.gbEnterBookingDets.Controls.Add(this.lblViewingTime);
            this.gbEnterBookingDets.Font = new System.Drawing.Font("Eras Demi ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEnterBookingDets.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbEnterBookingDets.Location = new System.Drawing.Point(12, 12);
            this.gbEnterBookingDets.Name = "gbEnterBookingDets";
            this.gbEnterBookingDets.Size = new System.Drawing.Size(610, 550);
            this.gbEnterBookingDets.TabIndex = 15;
            this.gbEnterBookingDets.TabStop = false;
            this.gbEnterBookingDets.Text = "Booking Details";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Eras Demi ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(331, 174);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 32);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbNoWheelchair
            // 
            this.rbNoWheelchair.AutoSize = true;
            this.rbNoWheelchair.Font = new System.Drawing.Font("Eras Demi ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoWheelchair.Location = new System.Drawing.Point(234, 173);
            this.rbNoWheelchair.Name = "rbNoWheelchair";
            this.rbNoWheelchair.Size = new System.Drawing.Size(64, 32);
            this.rbNoWheelchair.TabIndex = 20;
            this.rbNoWheelchair.TabStop = true;
            this.rbNoWheelchair.Text = "No";
            this.rbNoWheelchair.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(188, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "*";
            // 
            // lblDisabilityBooking
            // 
            this.lblDisabilityBooking.AutoSize = true;
            this.lblDisabilityBooking.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisabilityBooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDisabilityBooking.Location = new System.Drawing.Point(14, 168);
            this.lblDisabilityBooking.Name = "lblDisabilityBooking";
            this.lblDisabilityBooking.Size = new System.Drawing.Size(131, 48);
            this.lblDisabilityBooking.TabIndex = 18;
            this.lblDisabilityBooking.Text = "Wheelchair \r\nAccess? ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 482);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 39);
            this.textBox1.TabIndex = 15;
            // 
            // btnBookingHelp
            // 
            this.btnBookingHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookingHelp.BackgroundImage")));
            this.btnBookingHelp.FlatAppearance.BorderSize = 0;
            this.btnBookingHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingHelp.Location = new System.Drawing.Point(1150, 592);
            this.btnBookingHelp.Name = "btnBookingHelp";
            this.btnBookingHelp.Size = new System.Drawing.Size(114, 90);
            this.btnBookingHelp.TabIndex = 21;
            this.btnBookingHelp.UseVisualStyleBackColor = true;
            this.btnBookingHelp.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblNumber);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Font = new System.Drawing.Font("Eras Demi ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(640, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 550);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirmation Details";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNumber.Location = new System.Drawing.Point(442, 152);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(52, 24);
            this.lblNumber.TabIndex = 29;
            this.lblNumber.Text = "N/A";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(25, 369);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(412, 48);
            this.label26.TabIndex = 27;
            this.label26.Text = "Further Details Such As Booking No will \r\nappear on ticket/confirmation email";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(430, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 74);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(20, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 74);
            this.button2.TabIndex = 24;
            this.button2.Text = "Proceeed To Payment";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Cyan;
            this.linkLabel1.Location = new System.Drawing.Point(325, 186);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(150, 24);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Screen Details";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Cyan;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label25.Location = new System.Drawing.Point(324, 152);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(111, 24);
            this.label25.TabIndex = 9;
            this.label25.Text = "Screen No";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label24.Location = new System.Drawing.Point(231, 152);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 24);
            this.label24.TabIndex = 8;
            this.label24.Text = "Screen :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 218);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label23.Location = new System.Drawing.Point(123, 38);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(270, 24);
            this.label23.TabIndex = 6;
            this.label23.Text = "Title Changing With Input";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(25, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 24);
            this.label22.TabIndex = 5;
            this.label22.Text = "Movie :";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBookingHelp);
            this.Controls.Add(this.gbEnterBookingDets);
            this.Controls.Add(this.btnBookingReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Booking";
            this.Text = "Booking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Booking_Load);
            this.gbEnterBookingDets.ResumeLayout(false);
            this.gbEnterBookingDets.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBookingReturn;
        private System.Windows.Forms.ComboBox cmbMovieBook;
        private System.Windows.Forms.TextBox txtNoOfTicketsBooking;
        private System.Windows.Forms.Label lblNoOdTicks;
        private System.Windows.Forms.Label lblBookMovie;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblViewingTime;
        private System.Windows.Forms.ComboBox cmbBookingTime;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbEnterBookingDets;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbNoWheelchair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisabilityBooking;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBookingHelp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
    }
}