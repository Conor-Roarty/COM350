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
            this.components = new System.ComponentModel.Container();
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
            this.grpBoxEnterBooking = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.radBtnYesWheelchair = new System.Windows.Forms.RadioButton();
            this.radBtnNoWheelchair = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDisabilityBooking = new System.Windows.Forms.Label();
            this.txtOtherReqs = new System.Windows.Forms.TextBox();
            this.btnBookingHelp = new System.Windows.Forms.Button();
            this.grpBoxConfirmation = new System.Windows.Forms.GroupBox();
            this.btnScreenDets = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.epNoOfTickets = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMovie = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTime = new System.Windows.Forms.ErrorProvider(this.components);
            lblSpecial = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.grpBoxEnterBooking.SuspendLayout();
            this.grpBoxConfirmation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNoOfTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTime)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSpecial
            // 
            lblSpecial.AutoSize = true;
            lblSpecial.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSpecial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblSpecial.Location = new System.Drawing.Point(14, 429);
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
            this.btnBookingReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnBookingReturn.BackgroundImage = global::TheatreBooking.Properties.Resources.HomeButtonLeftOfCenter;
            this.btnBookingReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBookingReturn.FlatAppearance.BorderSize = 0;
            this.btnBookingReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookingReturn.Font = new System.Drawing.Font("Eras Demi ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingReturn.ForeColor = System.Drawing.Color.White;
            this.btnBookingReturn.Location = new System.Drawing.Point(0, 591);
            this.btnBookingReturn.Name = "btnBookingReturn";
            this.btnBookingReturn.Size = new System.Drawing.Size(1150, 90);
            this.btnBookingReturn.TabIndex = 0;
            this.btnBookingReturn.Text = "Home";
            this.btnBookingReturn.UseCompatibleTextRendering = true;
            this.btnBookingReturn.UseVisualStyleBackColor = false;
            this.btnBookingReturn.Click += new System.EventHandler(this.btnBookingReturn_Click);
            // 
            // cmbMovieBook
            // 
            this.cmbMovieBook.FormattingEnabled = true;
            this.cmbMovieBook.Items.AddRange(new object[] {
            "------- Select A Movie -------",
            "Pulp Fiction",
            "Jumanji",
            "The Room",
            "Avengers: Infinity War",
            "The Shape of Water"});
            this.cmbMovieBook.Location = new System.Drawing.Point(234, 118);
            this.cmbMovieBook.Name = "cmbMovieBook";
            this.cmbMovieBook.Size = new System.Drawing.Size(356, 39);
            this.cmbMovieBook.TabIndex = 1;
            this.cmbMovieBook.Text = "--------Select A Movie--------";
            this.cmbMovieBook.SelectedIndexChanged += new System.EventHandler(this.cmbMovieBook_SelectedIndexChanged);
            this.cmbMovieBook.Click += new System.EventHandler(this.cmbMovieBook_Click);
            // 
            // txtNoOfTicketsBooking
            // 
            this.txtNoOfTicketsBooking.Location = new System.Drawing.Point(234, 56);
            this.txtNoOfTicketsBooking.Name = "txtNoOfTicketsBooking";
            this.txtNoOfTicketsBooking.Size = new System.Drawing.Size(356, 39);
            this.txtNoOfTicketsBooking.TabIndex = 2;
            this.txtNoOfTicketsBooking.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNoOfTicketsBooking_KeyDown);
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
            "--------Select A Time--------",
            "12:30 pm",
            "2:00 pm",
            "4:00 pm",
            "6:00 pm",
            "8:00 pm",
            "10:00 pm",
            "12:00 am"});
            this.cmbBookingTime.Location = new System.Drawing.Point(234, 291);
            this.cmbBookingTime.Name = "cmbBookingTime";
            this.cmbBookingTime.Size = new System.Drawing.Size(356, 39);
            this.cmbBookingTime.TabIndex = 7;
            this.cmbBookingTime.Text = "--------Select A Time--------";
            this.cmbBookingTime.SelectedIndexChanged += new System.EventHandler(this.cmbBookingTime_SelectedIndexChanged);
            this.cmbBookingTime.Click += new System.EventHandler(this.cmbBookingTime_Click);
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Location = new System.Drawing.Point(234, 224);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(356, 39);
            this.dtpBookingDate.TabIndex = 9;
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
            // grpBoxEnterBooking
            // 
            this.grpBoxEnterBooking.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxEnterBooking.Controls.Add(this.linkLabel1);
            this.grpBoxEnterBooking.Controls.Add(label8);
            this.grpBoxEnterBooking.Controls.Add(this.radBtnYesWheelchair);
            this.grpBoxEnterBooking.Controls.Add(this.radBtnNoWheelchair);
            this.grpBoxEnterBooking.Controls.Add(this.label2);
            this.grpBoxEnterBooking.Controls.Add(this.lblDisabilityBooking);
            this.grpBoxEnterBooking.Controls.Add(lblSpecial);
            this.grpBoxEnterBooking.Controls.Add(this.txtOtherReqs);
            this.grpBoxEnterBooking.Controls.Add(this.lblNoOdTicks);
            this.grpBoxEnterBooking.Controls.Add(this.label5);
            this.grpBoxEnterBooking.Controls.Add(this.cmbMovieBook);
            this.grpBoxEnterBooking.Controls.Add(this.label4);
            this.grpBoxEnterBooking.Controls.Add(this.txtNoOfTicketsBooking);
            this.grpBoxEnterBooking.Controls.Add(this.label3);
            this.grpBoxEnterBooking.Controls.Add(this.lblBookMovie);
            this.grpBoxEnterBooking.Controls.Add(this.label1);
            this.grpBoxEnterBooking.Controls.Add(this.lblBookingDate);
            this.grpBoxEnterBooking.Controls.Add(this.dtpBookingDate);
            this.grpBoxEnterBooking.Controls.Add(this.cmbBookingTime);
            this.grpBoxEnterBooking.Controls.Add(this.lblViewingTime);
            this.grpBoxEnterBooking.Font = new System.Drawing.Font("Eras Demi ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxEnterBooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpBoxEnterBooking.Location = new System.Drawing.Point(12, 12);
            this.grpBoxEnterBooking.Name = "grpBoxEnterBooking";
            this.grpBoxEnterBooking.Size = new System.Drawing.Size(610, 550);
            this.grpBoxEnterBooking.TabIndex = 15;
            this.grpBoxEnterBooking.TabStop = false;
            this.grpBoxEnterBooking.Text = "Booking Details";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Cyan;
            this.linkLabel1.Location = new System.Drawing.Point(230, 345);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(267, 72);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "\r\nTouch Here To Select Seat\r\n\r\n";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Cyan;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // radBtnYesWheelchair
            // 
            this.radBtnYesWheelchair.AutoSize = true;
            this.radBtnYesWheelchair.Font = new System.Drawing.Font("Eras Demi ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnYesWheelchair.Location = new System.Drawing.Point(331, 174);
            this.radBtnYesWheelchair.Name = "radBtnYesWheelchair";
            this.radBtnYesWheelchair.Size = new System.Drawing.Size(68, 32);
            this.radBtnYesWheelchair.TabIndex = 21;
            this.radBtnYesWheelchair.TabStop = true;
            this.radBtnYesWheelchair.Text = "Yes";
            this.radBtnYesWheelchair.UseVisualStyleBackColor = true;
            // 
            // radBtnNoWheelchair
            // 
            this.radBtnNoWheelchair.AutoSize = true;
            this.radBtnNoWheelchair.Checked = true;
            this.radBtnNoWheelchair.Font = new System.Drawing.Font("Eras Demi ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnNoWheelchair.Location = new System.Drawing.Point(234, 173);
            this.radBtnNoWheelchair.Name = "radBtnNoWheelchair";
            this.radBtnNoWheelchair.Size = new System.Drawing.Size(64, 32);
            this.radBtnNoWheelchair.TabIndex = 20;
            this.radBtnNoWheelchair.TabStop = true;
            this.radBtnNoWheelchair.Text = "No";
            this.radBtnNoWheelchair.UseVisualStyleBackColor = true;
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
            // txtOtherReqs
            // 
            this.txtOtherReqs.Location = new System.Drawing.Point(234, 424);
            this.txtOtherReqs.Name = "txtOtherReqs";
            this.txtOtherReqs.Size = new System.Drawing.Size(356, 39);
            this.txtOtherReqs.TabIndex = 15;
            // 
            // btnBookingHelp
            // 
            this.btnBookingHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnBookingHelp.BackgroundImage = global::TheatreBooking.Properties.Resources.helpButton3;
            this.btnBookingHelp.FlatAppearance.BorderSize = 0;
            this.btnBookingHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookingHelp.Location = new System.Drawing.Point(1150, 592);
            this.btnBookingHelp.Name = "btnBookingHelp";
            this.btnBookingHelp.Size = new System.Drawing.Size(114, 90);
            this.btnBookingHelp.TabIndex = 21;
            this.btnBookingHelp.UseVisualStyleBackColor = false;
            this.btnBookingHelp.Click += new System.EventHandler(this.btnBookingHelp_Click_1);
            // 
            // grpBoxConfirmation
            // 
            this.grpBoxConfirmation.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxConfirmation.Controls.Add(this.btnScreenDets);
            this.grpBoxConfirmation.Controls.Add(this.lblNumber);
            this.grpBoxConfirmation.Controls.Add(this.label26);
            this.grpBoxConfirmation.Controls.Add(this.btnClear);
            this.grpBoxConfirmation.Controls.Add(this.btnProceed);
            this.grpBoxConfirmation.Controls.Add(this.label25);
            this.grpBoxConfirmation.Controls.Add(this.label24);
            this.grpBoxConfirmation.Controls.Add(this.pictureBox1);
            this.grpBoxConfirmation.Controls.Add(this.label23);
            this.grpBoxConfirmation.Controls.Add(this.label22);
            this.grpBoxConfirmation.Font = new System.Drawing.Font("Eras Demi ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxConfirmation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpBoxConfirmation.Location = new System.Drawing.Point(640, 12);
            this.grpBoxConfirmation.Name = "grpBoxConfirmation";
            this.grpBoxConfirmation.Size = new System.Drawing.Size(610, 550);
            this.grpBoxConfirmation.TabIndex = 25;
            this.grpBoxConfirmation.TabStop = false;
            this.grpBoxConfirmation.Text = "Confirmation Details";
            // 
            // btnScreenDets
            // 
            this.btnScreenDets.BackgroundImage = global::TheatreBooking.Properties.Resources.buttons;
            this.btnScreenDets.Enabled = false;
            this.btnScreenDets.FlatAppearance.BorderSize = 0;
            this.btnScreenDets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreenDets.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenDets.ForeColor = System.Drawing.Color.White;
            this.btnScreenDets.Location = new System.Drawing.Point(360, 164);
            this.btnScreenDets.Name = "btnScreenDets";
            this.btnScreenDets.Size = new System.Drawing.Size(162, 42);
            this.btnScreenDets.TabIndex = 30;
            this.btnScreenDets.Text = "Screen Details";
            this.btnScreenDets.UseVisualStyleBackColor = true;
            this.btnScreenDets.Click += new System.EventHandler(this.btnScreenDets_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNumber.Location = new System.Drawing.Point(470, 115);
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
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = global::TheatreBooking.Properties.Resources.buttonCancel;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(430, 460);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(162, 74);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.Transparent;
            this.btnProceed.BackgroundImage = global::TheatreBooking.Properties.Resources.buttons;
            this.btnProceed.FlatAppearance.BorderSize = 0;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProceed.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(20, 460);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(162, 74);
            this.btnProceed.TabIndex = 24;
            this.btnProceed.Text = "Proceeed To Your Details";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label25.Location = new System.Drawing.Point(352, 115);
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
            this.label24.Location = new System.Drawing.Point(259, 115);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 24);
            this.label24.TabIndex = 8;
            this.label24.Text = "Screen :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            // epNoOfTickets
            // 
            this.epNoOfTickets.ContainerControl = this;
            // 
            // epMovie
            // 
            this.epMovie.ContainerControl = this;
            // 
            // epTime
            // 
            this.epTime.ContainerControl = this;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::TheatreBooking.Properties.Resources.backgroundImageBlank;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.grpBoxConfirmation);
            this.Controls.Add(this.btnBookingHelp);
            this.Controls.Add(this.grpBoxEnterBooking);
            this.Controls.Add(this.btnBookingReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.grpBoxEnterBooking.ResumeLayout(false);
            this.grpBoxEnterBooking.PerformLayout();
            this.grpBoxConfirmation.ResumeLayout(false);
            this.grpBoxConfirmation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNoOfTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTime)).EndInit();
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
        private System.Windows.Forms.GroupBox grpBoxEnterBooking;
        private System.Windows.Forms.RadioButton radBtnYesWheelchair;
        private System.Windows.Forms.RadioButton radBtnNoWheelchair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisabilityBooking;
        private System.Windows.Forms.TextBox txtOtherReqs;
        private System.Windows.Forms.Button btnBookingHelp;
        private System.Windows.Forms.GroupBox grpBoxConfirmation;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ErrorProvider epNoOfTickets;
        private System.Windows.Forms.ErrorProvider epMovie;
        private System.Windows.Forms.ErrorProvider epTime;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnScreenDets;
    }
}