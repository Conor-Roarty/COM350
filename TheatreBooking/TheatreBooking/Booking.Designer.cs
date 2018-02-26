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
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            lblSpecial = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.gbEnterBookingDets.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.btnBookingReturn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBookingReturn.FlatAppearance.BorderSize = 0;
            this.btnBookingReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingReturn.Font = new System.Drawing.Font("Eras Demi ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingReturn.ForeColor = System.Drawing.Color.White;
            this.btnBookingReturn.Location = new System.Drawing.Point(0, 591);
            this.btnBookingReturn.Name = "btnBookingReturn";
            this.btnBookingReturn.Padding = new System.Windows.Forms.Padding(500, 0, 500, 0);
            this.btnBookingReturn.Size = new System.Drawing.Size(1264, 90);
            this.btnBookingReturn.TabIndex = 0;
            this.btnBookingReturn.Text = "Home";
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label18);
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
            this.groupBox1.Font = new System.Drawing.Font("Eras Demi ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(647, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 550);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 39);
            this.textBox2.TabIndex = 26;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(517, 375);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(19, 369);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(444, 72);
            this.label20.TabIndex = 23;
            this.label20.Text = "Recieve Special Offers Via Phone/Email?\r\n(You will not recieve special offers or " +
    "\r\npromotion information unless you select so)";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(21, 450);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 24);
            this.label18.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(156, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(19, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "PostCode";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(202, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(330, 39);
            this.textBox3.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(19, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Full Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(156, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 31);
            this.label10.TabIndex = 14;
            this.label10.Text = "*";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(202, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(330, 39);
            this.comboBox1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(156, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 31);
            this.label11.TabIndex = 13;
            this.label11.Text = "*";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(202, 56);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(330, 39);
            this.textBox5.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(156, 307);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 31);
            this.label12.TabIndex = 12;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(19, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 24);
            this.label13.TabIndex = 4;
            this.label13.Text = "Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(156, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 31);
            this.label14.TabIndex = 10;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(19, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 24);
            this.label15.TabIndex = 6;
            this.label15.Text = "Email";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(202, 310);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(330, 39);
            this.comboBox2.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(19, 310);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 24);
            this.label16.TabIndex = 8;
            this.label16.Text = "Phone";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 74);
            this.button1.TabIndex = 27;
            this.button1.Text = "Proceed To Payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(420, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 74);
            this.button2.TabIndex = 28;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}