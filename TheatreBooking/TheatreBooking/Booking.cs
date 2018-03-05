using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheatreBooking
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
            rbNoWheelchair.Select();
        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void btnBookingReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Screen s = new Screen();
            s.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaymentMethod p = new PaymentMethod();
            p.Visible = true;
        }

        private void cmbMovieBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            label23.Text = cmbMovieBook.SelectedItem.ToString();
        }

        private void cmbBookingTime_SelectedIndexChanged(object sender, EventArgs e)
        {//usually search db for actual screen but here just set to random number
            if (dtpBookingDate.Value != null)
            {
                linkLabel1.Enabled = true;
                lblNumber.Text = "69";
            }
            else
            {
                linkLabel1.Enabled = false;
                lblNumber.Text = "N/A";
            }
        }

        private void dtpBookingDate_ValueChanged(object sender, EventArgs e)
        {//usually search db for actual screen and IF FOUND set to that value but here just set to random number
            if (cmbBookingTime.SelectedIndex != -1)
            {
                linkLabel1.Enabled = true;
                lblNumber.Text = "69";
            }
            else
            {
                linkLabel1.Enabled = false;
                lblNumber.Text = "N/A";
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmationPage confirmation = new ConfirmationPage();
            confirmation.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
