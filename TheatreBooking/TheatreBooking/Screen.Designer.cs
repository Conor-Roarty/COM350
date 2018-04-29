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
            this.lblScreenInfo2 = new System.Windows.Forms.Label();
            this.lblScreenInfo1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBookingReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScreenInfo2
            // 
            this.lblScreenInfo2.AutoSize = true;
            this.lblScreenInfo2.BackColor = System.Drawing.Color.Transparent;
            this.lblScreenInfo2.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenInfo2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScreenInfo2.Location = new System.Drawing.Point(103, 498);
            this.lblScreenInfo2.Name = "lblScreenInfo2";
            this.lblScreenInfo2.Size = new System.Drawing.Size(0, 24);
            this.lblScreenInfo2.TabIndex = 42;
            // 
            // lblScreenInfo1
            // 
            this.lblScreenInfo1.AutoSize = true;
            this.lblScreenInfo1.BackColor = System.Drawing.Color.Transparent;
            this.lblScreenInfo1.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenInfo1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScreenInfo1.Location = new System.Drawing.Point(253, 374);
            this.lblScreenInfo1.Name = "lblScreenInfo1";
            this.lblScreenInfo1.Size = new System.Drawing.Size(0, 24);
            this.lblScreenInfo1.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(307, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 353);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(106, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1052, 72);
            this.label1.TabIndex = 44;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(256, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 96);
            this.label2.TabIndex = 43;
            this.label2.Text = "This Screen number: 12\r\n   \r\nThis Screen has a total of 40 seats available at any" +
    "one time, including\r\nwheelchair accessable seats for those who requie such facil" +
    "ities.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBookingReturn
            // 
            this.btnBookingReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnBookingReturn.BackgroundImage = global::TheatreBooking.Properties.Resources.ReturnButton;
            this.btnBookingReturn.FlatAppearance.BorderSize = 0;
            this.btnBookingReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingReturn.Font = new System.Drawing.Font("Eras Demi ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingReturn.ForeColor = System.Drawing.Color.White;
            this.btnBookingReturn.Location = new System.Drawing.Point(0, 593);
            this.btnBookingReturn.Name = "btnBookingReturn";
            this.btnBookingReturn.Size = new System.Drawing.Size(1272, 90);
            this.btnBookingReturn.TabIndex = 47;
            this.btnBookingReturn.Text = "Return";
            this.btnBookingReturn.UseVisualStyleBackColor = false;
            this.btnBookingReturn.Click += new System.EventHandler(this.btnBookingReturn_Click_1);
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::TheatreBooking.Properties.Resources.backgroundImageBlank;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnBookingReturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScreenInfo2);
            this.Controls.Add(this.lblScreenInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblScreenInfo2;
        private System.Windows.Forms.Label lblScreenInfo1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBookingReturn;
    }
}