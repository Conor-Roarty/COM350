namespace TheatreBooking
{
    partial class Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen));
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookingReturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblScreenInfo2 = new System.Windows.Forms.Label();
            this.lblScreenInfo1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(431, 176);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(331, 24);
            this.label20.TabIndex = 24;
            this.label20.Text = "This Screen Is Bleak, Unlucky m9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(247, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 48);
            this.label1.TabIndex = 25;
            this.label1.Text = "Just text here saying what the screen has like number of seats, \r\nwheelchair acce" +
    "ss and all that and they can just return, no interaction";
            // 
            // btnBookingReturn
            // 
            this.btnBookingReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnBookingReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookingReturn.BackgroundImage")));
            this.btnBookingReturn.FlatAppearance.BorderSize = 0;
            this.btnBookingReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingReturn.Font = new System.Drawing.Font("Eras Demi ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingReturn.ForeColor = System.Drawing.Color.White;
            this.btnBookingReturn.Location = new System.Drawing.Point(-4, 573);
            this.btnBookingReturn.Name = "btnBookingReturn";
            this.btnBookingReturn.Size = new System.Drawing.Size(1272, 90);
            this.btnBookingReturn.TabIndex = 44;
            this.btnBookingReturn.Text = "Return";
            this.btnBookingReturn.UseVisualStyleBackColor = false;
            this.btnBookingReturn.Click += new System.EventHandler(this.btnBookingReturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 353);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // lblScreenInfo2
            // 
            this.lblScreenInfo2.AutoSize = true;
            this.lblScreenInfo2.BackColor = System.Drawing.Color.Transparent;
            this.lblScreenInfo2.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenInfo2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScreenInfo2.Location = new System.Drawing.Point(103, 498);
            this.lblScreenInfo2.Name = "lblScreenInfo2";
            this.lblScreenInfo2.Size = new System.Drawing.Size(1052, 72);
            this.lblScreenInfo2.TabIndex = 42;
            this.lblScreenInfo2.Text = resources.GetString("lblScreenInfo2.Text");
            // 
            // lblScreenInfo1
            // 
            this.lblScreenInfo1.AutoSize = true;
            this.lblScreenInfo1.BackColor = System.Drawing.Color.Transparent;
            this.lblScreenInfo1.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenInfo1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScreenInfo1.Location = new System.Drawing.Point(253, 374);
            this.lblScreenInfo1.Name = "lblScreenInfo1";
            this.lblScreenInfo1.Size = new System.Drawing.Size(694, 96);
            this.lblScreenInfo1.TabIndex = 41;
            this.lblScreenInfo1.Text = resources.GetString("lblScreenInfo1.Text");
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnBookingReturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblScreenInfo2);
            this.Controls.Add(this.lblScreenInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Name = "Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookingReturn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblScreenInfo2;
        private System.Windows.Forms.Label lblScreenInfo1;
    }
}