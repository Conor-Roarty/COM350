﻿namespace TheatreBooking
{
    partial class TheatreBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheatreBooking));
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnListings = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnBooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBooking.BackgroundImage")));
            this.btnBooking.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBooking.Font = new System.Drawing.Font("Eras Demi ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.Transparent;
            this.btnBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnBooking.Image")));
            this.btnBooking.Location = new System.Drawing.Point(27, 520);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(270, 120);
            this.btnBooking.TabIndex = 2;
            this.btnBooking.Text = "Book \r\nTicket(s)";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.BackColor = System.Drawing.Color.Transparent;
            this.btnEvents.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEvents.BackgroundImage")));
            this.btnEvents.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEvents.Font = new System.Drawing.Font("Eras Demi ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.White;
            this.btnEvents.Location = new System.Drawing.Point(650, 520);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(270, 120);
            this.btnEvents.TabIndex = 3;
            this.btnEvents.Text = "View \r\nEvents";
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnListings
            // 
            this.btnListings.BackColor = System.Drawing.Color.Transparent;
            this.btnListings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListings.BackgroundImage")));
            this.btnListings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListings.FlatAppearance.BorderSize = 0;
            this.btnListings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListings.Font = new System.Drawing.Font("Eras Demi ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListings.ForeColor = System.Drawing.Color.White;
            this.btnListings.Location = new System.Drawing.Point(341, 520);
            this.btnListings.Name = "btnListings";
            this.btnListings.Size = new System.Drawing.Size(270, 120);
            this.btnListings.TabIndex = 4;
            this.btnListings.Text = "View \r\nListings";
            this.btnListings.UseVisualStyleBackColor = false;
            this.btnListings.Click += new System.EventHandler(this.btnListings_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Eras Demi ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(958, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(270, 120);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel Reservation";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TheatreBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheatreBooking.Properties.Resources.Background_Image;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnListings);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "TheatreBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunar Cinemas";
            this.Load += new System.EventHandler(this.TheatreBooking_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnListings;
        private System.Windows.Forms.Button btnCancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}

