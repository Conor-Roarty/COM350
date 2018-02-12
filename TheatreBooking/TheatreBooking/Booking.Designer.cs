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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            lblSpecial = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.gbEnterBookingDets.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSpecial
            // 
            lblSpecial.AutoSize = true;
            lblSpecial.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSpecial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblSpecial.Location = new System.Drawing.Point(14, 487);
            lblSpecial.Name = "lblSpecial";
            lblSpecial.Size = new System.Drawing.Size(229, 31);
            lblSpecial.TabIndex = 16;
            lblSpecial.Text = "Other Requirements";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label8.Location = new System.Drawing.Point(16, 412);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(141, 31);
            label8.TabIndex = 22;
            label8.Text = "Select Seats";
            // 
            // btnBookingReturn
            // 
            this.btnBookingReturn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBookingReturn.Font = new System.Drawing.Font("Sitka Subheading", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnBookingReturn.Image")));
            this.btnBookingReturn.Location = new System.Drawing.Point(0, 912);
            this.btnBookingReturn.Name = "btnBookingReturn";
            this.btnBookingReturn.Padding = new System.Windows.Forms.Padding(500, 0, 500, 0);
            this.btnBookingReturn.Size = new System.Drawing.Size(1847, 100);
            this.btnBookingReturn.TabIndex = 0;
            this.btnBookingReturn.Text = "Return To Home Page";
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
            this.cmbMovieBook.Location = new System.Drawing.Point(288, 114);
            this.cmbMovieBook.Name = "cmbMovieBook";
            this.cmbMovieBook.Size = new System.Drawing.Size(330, 47);
            this.cmbMovieBook.TabIndex = 1;
            this.cmbMovieBook.SelectedIndexChanged += new System.EventHandler(this.cmbMovieBook_SelectedIndexChanged);
            // 
            // txtNoOfTicketsBooking
            // 
            this.txtNoOfTicketsBooking.Location = new System.Drawing.Point(288, 52);
            this.txtNoOfTicketsBooking.Name = "txtNoOfTicketsBooking";
            this.txtNoOfTicketsBooking.Size = new System.Drawing.Size(330, 41);
            this.txtNoOfTicketsBooking.TabIndex = 2;
            // 
            // lblNoOdTicks
            // 
            this.lblNoOdTicks.AutoSize = true;
            this.lblNoOdTicks.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOdTicks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoOdTicks.Location = new System.Drawing.Point(16, 61);
            this.lblNoOdTicks.Name = "lblNoOdTicks";
            this.lblNoOdTicks.Size = new System.Drawing.Size(165, 31);
            this.lblNoOdTicks.TabIndex = 3;
            this.lblNoOdTicks.Text = "No Of Tickets ";
            // 
            // lblBookMovie
            // 
            this.lblBookMovie.AutoSize = true;
            this.lblBookMovie.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBookMovie.Location = new System.Drawing.Point(16, 123);
            this.lblBookMovie.Name = "lblBookMovie";
            this.lblBookMovie.Size = new System.Drawing.Size(135, 31);
            this.lblBookMovie.TabIndex = 4;
            this.lblBookMovie.Text = "Movie Title";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBookingDate.Location = new System.Drawing.Point(16, 262);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(157, 31);
            this.lblBookingDate.TabIndex = 6;
            this.lblBookingDate.Text = "Viewing Date";
            // 
            // lblViewingTime
            // 
            this.lblViewingTime.AutoSize = true;
            this.lblViewingTime.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewingTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblViewingTime.Location = new System.Drawing.Point(16, 328);
            this.lblViewingTime.Name = "lblViewingTime";
            this.lblViewingTime.Size = new System.Drawing.Size(162, 31);
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
            this.cmbBookingTime.Location = new System.Drawing.Point(288, 319);
            this.cmbBookingTime.Name = "cmbBookingTime";
            this.cmbBookingTime.Size = new System.Drawing.Size(330, 47);
            this.cmbBookingTime.TabIndex = 7;
            this.cmbBookingTime.SelectedIndexChanged += new System.EventHandler(this.cmbBookingTime_SelectedIndexChanged);
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Location = new System.Drawing.Point(288, 252);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(330, 41);
            this.dtpBookingDate.TabIndex = 9;
            this.dtpBookingDate.ValueChanged += new System.EventHandler(this.dtpBookingDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(242, 49);
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
            this.label3.Location = new System.Drawing.Point(242, 316);
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
            this.label4.Location = new System.Drawing.Point(242, 249);
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
            this.label5.Location = new System.Drawing.Point(242, 111);
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
            this.gbEnterBookingDets.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEnterBookingDets.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbEnterBookingDets.Location = new System.Drawing.Point(38, 91);
            this.gbEnterBookingDets.Name = "gbEnterBookingDets";
            this.gbEnterBookingDets.Size = new System.Drawing.Size(644, 574);
            this.gbEnterBookingDets.TabIndex = 15;
            this.gbEnterBookingDets.TabStop = false;
            this.gbEnterBookingDets.Text = "Booking Details";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(385, 189);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 43);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbNoWheelchair
            // 
            this.rbNoWheelchair.AutoSize = true;
            this.rbNoWheelchair.Location = new System.Drawing.Point(288, 188);
            this.rbNoWheelchair.Name = "rbNoWheelchair";
            this.rbNoWheelchair.Size = new System.Drawing.Size(68, 43);
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
            this.label2.Location = new System.Drawing.Point(242, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "*";
            // 
            // lblDisabilityBooking
            // 
            this.lblDisabilityBooking.AutoSize = true;
            this.lblDisabilityBooking.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisabilityBooking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDisabilityBooking.Location = new System.Drawing.Point(16, 197);
            this.lblDisabilityBooking.Name = "lblDisabilityBooking";
            this.lblDisabilityBooking.Size = new System.Drawing.Size(227, 31);
            this.lblDisabilityBooking.TabIndex = 18;
            this.lblDisabilityBooking.Text = "Wheelchair Access? ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 478);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 41);
            this.textBox1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(720, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 574);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Details";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(291, 253);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 41);
            this.textBox2.TabIndex = 26;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(291, 405);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(21, 423);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(192, 31);
            this.label21.TabIndex = 24;
            this.label21.Text = "Via Phone/Email";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(19, 392);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(250, 31);
            this.label20.TabIndex = 23;
            this.label20.Text = "Recieve Special Offers";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(21, 538);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(150, 23);
            this.label19.TabIndex = 22;
            this.label19.Text = "Unless you select so";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(21, 508);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(437, 23);
            this.label18.TabIndex = 21;
            this.label18.Text = "You will not recieve special offers or promotion information ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 478);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(403, 23);
            this.label17.TabIndex = 20;
            this.label17.Text = "Email and Phone will be used for booking confirmation ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(245, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(19, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "PostCode";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(291, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(330, 41);
            this.textBox3.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(19, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 31);
            this.label9.TabIndex = 3;
            this.label9.Text = "Full Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(245, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 31);
            this.label10.TabIndex = 14;
            this.label10.Text = "*";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(291, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(330, 47);
            this.comboBox1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(245, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 31);
            this.label11.TabIndex = 13;
            this.label11.Text = "*";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(291, 52);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(330, 41);
            this.textBox5.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(245, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 31);
            this.label12.TabIndex = 12;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(19, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 31);
            this.label13.TabIndex = 4;
            this.label13.Text = "Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(245, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 31);
            this.label14.TabIndex = 10;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(19, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 31);
            this.label15.TabIndex = 6;
            this.label15.Text = "Email";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(291, 319);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(330, 47);
            this.comboBox2.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(19, 328);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 31);
            this.label16.TabIndex = 8;
            this.label16.Text = "Phone";
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
            this.groupBox2.Font = new System.Drawing.Font("Sitka Heading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(1381, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 574);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirmation Details";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(-1, 424);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(455, 19);
            this.label26.TabIndex = 27;
            this.label26.Text = "Further Details Such As Booking No will appear on ticket/confirmation email";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(286, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 74);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 74);
            this.button2.TabIndex = 24;
            this.button2.Text = "Proceeed To Payment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Cyan;
            this.linkLabel1.Location = new System.Drawing.Point(100, 369);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 30);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Screen Details";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Cyan;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label25.Location = new System.Drawing.Point(99, 335);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(122, 31);
            this.label25.TabIndex = 9;
            this.label25.Text = "Screen No";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label24.Location = new System.Drawing.Point(6, 335);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 31);
            this.label24.TabIndex = 8;
            this.label24.Text = "Screen :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 218);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label23.Location = new System.Drawing.Point(123, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(264, 28);
            this.label23.TabIndex = 6;
            this.label23.Text = "Title Changing With Input";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(6, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 31);
            this.label22.TabIndex = 5;
            this.label22.Text = "Movie :";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNumber.Location = new System.Drawing.Point(217, 335);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(56, 31);
            this.lblNumber.TabIndex = 29;
            this.lblNumber.Text = "N/A";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1847, 1012);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbEnterBookingDets);
            this.Controls.Add(this.btnBookingReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Booking";
            this.Text = "Booking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Booking_Load);
            this.gbEnterBookingDets.ResumeLayout(false);
            this.gbEnterBookingDets.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblNumber;
    }
}