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
            this.btnBookingReturn = new System.Windows.Forms.Button();
            this.lblBookMovie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnBookingReturn.TabIndex = 31;
            this.btnBookingReturn.Text = "Home";
            this.btnBookingReturn.UseVisualStyleBackColor = true;
            this.btnBookingReturn.Click += new System.EventHandler(this.btnBookingReturn_Click);
            // 
            // lblBookMovie
            // 
            this.lblBookMovie.AutoSize = true;
            this.lblBookMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblBookMovie.Font = new System.Drawing.Font("Eras Demi ITC", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBookMovie.Location = new System.Drawing.Point(294, 25);
            this.lblBookMovie.Name = "lblBookMovie";
            this.lblBookMovie.Size = new System.Drawing.Size(209, 33);
            this.lblBookMovie.TabIndex = 32;
            this.lblBookMovie.Text = "Weekly Offers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(843, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "Upcoming Events";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(705, 312);
            this.label2.TabIndex = 34;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(759, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 240);
            this.label3.TabIndex = 35;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBookMovie);
            this.Controls.Add(this.btnBookingReturn);
            this.Name = "Events";
            this.Text = "Events";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBookingReturn;
        private System.Windows.Forms.Label lblBookMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}