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
            radBtnNoWheelchair.Select();
        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        #region Buttons
        private void btnBookingReturn_Click(object sender, EventArgs e)
        {
            TheatreBooking theatre = new TheatreBooking();
            theatre.Show();
            this.Close();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNoOfTicketsBooking.Clear();
            txtOtherReqs.Clear();
            cmbBookingTime.Items.Clear();
            cmbMovieBook.Items.Clear();
            radBtnNoWheelchair.Checked = true;
            radBtnYesWheelchair.Checked = false;
        }
        #endregion

        #region ComboBoxes
        private void cmbMovieBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            label23.Text = cmbMovieBook.SelectedItem.ToString();
            if (cmbMovieBook.SelectedIndex == 0)
            {
                pictureBox1.Image = Properties.Resources.ForceAwakens;
            }
            else if (cmbMovieBook.SelectedIndex == 1)
            {
                pictureBox1.Image = Properties.Resources.PulpFiction;
            }
            else if (cmbMovieBook.SelectedIndex == 2)
            {
                pictureBox1.Image = Properties.Resources.Jumanji;
            }
            else if (cmbMovieBook.SelectedIndex == 3)
            {
                pictureBox1.Image = Properties.Resources.The_Room;
            }
            else if (cmbMovieBook.SelectedIndex == 4)
            {
                pictureBox1.Image = Properties.Resources.Avengers;
            }
            else if (cmbMovieBook.SelectedIndex == 5)
            {
                pictureBox1.Image = Properties.Resources.shapeofwater;
            }
        }

        private void cmbBookingTime_SelectedIndexChanged(object sender, EventArgs e)
        {//usually search db for actual screen but here just set to random number
            if (dtpBookingDate.Value != null)
            {
                lnkLblScreenDetails.Enabled = true;
                lblNumber.Text = "69";
            }
            else
            {
                lnkLblScreenDetails.Enabled = false;
                lblNumber.Text = "N/A";
            }
        }
        #endregion

        #region OtherControls
        private void dtpBookingDate_ValueChanged(object sender, EventArgs e)
        {//usually search db for actual screen and IF FOUND set to that value but here just set to random number
            if (cmbBookingTime.SelectedIndex != -1)
            {
                lnkLblScreenDetails.Enabled = true;
                lblNumber.Text = "69";
            }
            else
            {
                lnkLblScreenDetails.Enabled = false;
                lblNumber.Text = "N/A";
            }
        }

        private void lnkLblScreenDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Screen s = new Screen();
            s.Show();
            this.Hide();
        }

        #endregion
    }
}
