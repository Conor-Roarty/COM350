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
            this.btnEventsReturn = new System.Windows.Forms.Button();
            this.lblBookMovie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEventsHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEventsReturn
            // 
            this.btnEventsReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEventsReturn.BackgroundImage")));
            this.btnEventsReturn.FlatAppearance.BorderSize = 0;
            this.btnEventsReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventsReturn.Font = new System.Drawing.Font("Eras Demi ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventsReturn.ForeColor = System.Drawing.Color.White;
            this.btnEventsReturn.Location = new System.Drawing.Point(0, 591);
            this.btnEventsReturn.Name = "btnEventsReturn";
            this.btnEventsReturn.Size = new System.Drawing.Size(1150, 90);
            this.btnEventsReturn.TabIndex = 31;
            this.btnEventsReturn.Text = "Home";
            this.btnEventsReturn.UseVisualStyleBackColor = true;
            this.btnEventsReturn.Click += new System.EventHandler(this.btnBookingReturn_Click);
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
            // btnEventsHelp
            // 
            this.btnEventsHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEventsHelp.BackgroundImage")));
            this.btnEventsHelp.FlatAppearance.BorderSize = 0;
            this.btnEventsHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventsHelp.Location = new System.Drawing.Point(1150, 592);
            this.btnEventsHelp.Name = "btnEventsHelp";
            this.btnEventsHelp.Size = new System.Drawing.Size(114, 90);
            this.btnEventsHelp.TabIndex = 36;
            this.btnEventsHelp.UseVisualStyleBackColor = true;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnEventsHelp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBookMovie);
            this.Controls.Add(this.btnEventsReturn);
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEventsReturn;
        private System.Windows.Forms.Label lblBookMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEventsHelp;
    }
}