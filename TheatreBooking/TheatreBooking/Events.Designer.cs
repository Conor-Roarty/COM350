namespace TheatreBooking
{
    partial class Events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnBookingReturn = new System.Windows.Forms.Button();
            this.lblBookMovie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Items.AddRange(new object[] {
            "Monday Movies:\tHalf Price On All Movies During The Day (Before 7pm)",
            "",
            "Crazy Tuesdays:\tHalf Price After 7pm On Movies and Snacks",
            "",
            "Wild Wednesdays:\tKids Go Free Before 5pm",
            "",
            "Thirsty Thursdays:\tAll Popcorn Comes With a Free Drink",
            "",
            "Finally Fridays:\t25% Off When You Are In A Group Of 3 Or More",
            "",
            "Super Saturdays:\tGet Half Off Your Food and Drinks ALL DAY",
            "",
            "Student Sundays:\t40% Off Tickets If You Present Your Student Card"});
            this.listBox1.Location = new System.Drawing.Point(48, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(923, 508);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.listBox2.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 28;
            this.listBox2.Items.AddRange(new object[] {
            "50 Shades Of Saving (28th Of Febuary 2018):",
            "Matinee Of All Movies To Date and Get a Free Soveniuer Mask When You Book Here",
            "",
            "",
            "Infinity War Prep (20th-25th June 2018):",
            "Watch Our Shortened Movie Matinee Of All Important Marvel Moments Before The",
            "Release Of Infinity War and Get a Free Infinity War Ticket When You Buy NOW"});
            this.listBox2.Location = new System.Drawing.Point(1011, 147);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(867, 508);
            this.listBox2.TabIndex = 1;
            // 
            // btnBookingReturn
            // 
            this.btnBookingReturn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBookingReturn.Font = new System.Drawing.Font("Sitka Subheading", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnBookingReturn.Image")));
            this.btnBookingReturn.Location = new System.Drawing.Point(0, 961);
            this.btnBookingReturn.Name = "btnBookingReturn";
            this.btnBookingReturn.Padding = new System.Windows.Forms.Padding(500, 0, 500, 0);
            this.btnBookingReturn.Size = new System.Drawing.Size(1924, 100);
            this.btnBookingReturn.TabIndex = 31;
            this.btnBookingReturn.Text = "Return To Home Page";
            this.btnBookingReturn.UseVisualStyleBackColor = true;
            this.btnBookingReturn.Click += new System.EventHandler(this.btnBookingReturn_Click);
            // 
            // lblBookMovie
            // 
            this.lblBookMovie.AutoSize = true;
            this.lblBookMovie.Font = new System.Drawing.Font("Sitka Small", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBookMovie.Location = new System.Drawing.Point(40, 87);
            this.lblBookMovie.Name = "lblBookMovie";
            this.lblBookMovie.Size = new System.Drawing.Size(236, 43);
            this.lblBookMovie.TabIndex = 32;
            this.lblBookMovie.Text = "Weekly Offers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1003, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 43);
            this.label1.TabIndex = 33;
            this.label1.Text = "Upcoming Events";
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBookMovie);
            this.Controls.Add(this.btnBookingReturn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Events";
            this.Text = "Events";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnBookingReturn;
        private System.Windows.Forms.Label lblBookMovie;
        private System.Windows.Forms.Label label1;
    }
}