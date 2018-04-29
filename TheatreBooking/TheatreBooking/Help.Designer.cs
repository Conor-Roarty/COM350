namespace TheatreBooking
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.lblHelpTitle = new System.Windows.Forms.Label();
            this.lblHelpInfo = new System.Windows.Forms.Label();
            this.btnBookingReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelpTitle
            // 
            this.lblHelpTitle.AutoSize = true;
            this.lblHelpTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHelpTitle.Font = new System.Drawing.Font("Eras Demi ITC", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHelpTitle.Location = new System.Drawing.Point(0, -1);
            this.lblHelpTitle.Name = "lblHelpTitle";
            this.lblHelpTitle.Size = new System.Drawing.Size(252, 33);
            this.lblHelpTitle.TabIndex = 41;
            this.lblHelpTitle.Text = "Help Information";
            // 
            // lblHelpInfo
            // 
            this.lblHelpInfo.AutoSize = true;
            this.lblHelpInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblHelpInfo.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpInfo.ForeColor = System.Drawing.Color.White;
            this.lblHelpInfo.Location = new System.Drawing.Point(2, 50);
            this.lblHelpInfo.Name = "lblHelpInfo";
            this.lblHelpInfo.Size = new System.Drawing.Size(1247, 504);
            this.lblHelpInfo.TabIndex = 40;
            this.lblHelpInfo.Text = resources.GetString("lblHelpInfo.Text");
            this.lblHelpInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBookingReturn
            // 
            this.btnBookingReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnBookingReturn.BackgroundImage = global::TheatreBooking.Properties.Resources.ReturnButton;
            this.btnBookingReturn.FlatAppearance.BorderSize = 0;
            this.btnBookingReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingReturn.Font = new System.Drawing.Font("Eras Demi ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingReturn.ForeColor = System.Drawing.Color.White;
            this.btnBookingReturn.Location = new System.Drawing.Point(-4, 592);
            this.btnBookingReturn.Name = "btnBookingReturn";
            this.btnBookingReturn.Size = new System.Drawing.Size(1272, 90);
            this.btnBookingReturn.TabIndex = 42;
            this.btnBookingReturn.Text = "Return";
            this.btnBookingReturn.UseVisualStyleBackColor = false;
            this.btnBookingReturn.Click += new System.EventHandler(this.btnBookingReturn_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheatreBooking.Properties.Resources.backgroundImageBlank;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnBookingReturn);
            this.Controls.Add(this.lblHelpTitle);
            this.Controls.Add(this.lblHelpInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookingReturn;
        private System.Windows.Forms.Label lblHelpTitle;
        private System.Windows.Forms.Label lblHelpInfo;
    }
}