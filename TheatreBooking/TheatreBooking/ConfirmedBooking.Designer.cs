namespace TheatreBooking
{
    partial class ConfirmedBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmedBooking));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBookingReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(451, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank You For Booking With Lunar Cinemas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(451, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Booking No: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(451, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(653, 53);
            this.label3.TabIndex = 2;
            this.label3.Text = "We Look Forward To Seeing You :)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(451, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1045, 53);
            this.label4.TabIndex = 3;
            this.label4.Text = "Full Booking Details WIll Be In The Confirmation Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 657);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1719, 47);
            this.label5.TabIndex = 4;
            this.label5.Text = "For Further Queries Or Assistance Please Call : 02871885000 Or Email bookingqueri" +
    "es@lunarcinemas.co.uk";
            // 
            // btnBookingReturn
            // 
            this.btnBookingReturn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBookingReturn.Font = new System.Drawing.Font("Sitka Subheading", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnBookingReturn.Image")));
            this.btnBookingReturn.Location = new System.Drawing.Point(0, 1081);
            this.btnBookingReturn.Name = "btnBookingReturn";
            this.btnBookingReturn.Padding = new System.Windows.Forms.Padding(500, 0, 500, 0);
            this.btnBookingReturn.Size = new System.Drawing.Size(1924, 100);
            this.btnBookingReturn.TabIndex = 5;
            this.btnBookingReturn.Text = "Return To Home Page";
            this.btnBookingReturn.UseVisualStyleBackColor = true;
            // 
            // ConfirmedBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1181);
            this.Controls.Add(this.btnBookingReturn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmedBooking";
            this.Text = "ConfirmedBooking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBookingReturn;
    }
}