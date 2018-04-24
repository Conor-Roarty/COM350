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
            dtpBookingDate.Value = DateTime.Today;
            dtpBookingDate.MinDate = DateTime.Today;
            dtpBookingDate.MaxDate = DateTime.Today.AddMonths(2);
            cmbBookingTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMovieBook.DropDownStyle = ComboBoxStyle.DropDownList;
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
            //change to deatils page so we have details for ticket printing, payment to come last
            int parse;
            bool valid = true;

            if (!int.TryParse(txtNoOfTicketsBooking.Text, out parse))
            {
                epNoOfTickets.SetError(txtNoOfTicketsBooking, "Only Valid Numbers Can Be Entered");
                valid = false;
            }
            else if (txtNoOfTicketsBooking.Text == "")
            {
                epNoOfTickets.SetError(txtNoOfTicketsBooking, "This Is A Required Field");
                valid = false;
            }
            else
                epNoOfTickets.Clear();

            if (cmbBookingTime.SelectedIndex == -1)
            {
                epTime.SetError(cmbBookingTime, "This Is A Required Field");
                valid = false;
            }
            else
                epTime.Clear();

            if (cmbMovieBook.SelectedIndex == -1)
            {
                epMovie.SetError(cmbMovieBook, "This Is A Required Field");
                valid = false;
            }
            else
                epMovie.Clear();


            if (valid)
            {
                Details d = new Details();
                d.Show();
                //this.Close();//do not close, keep running so details stay and not everything has to be re-entered, just editted
            }
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
                btnScreenDets.Enabled = true;
                lblNumber.Text = "69";
            }
            else
            {
                btnScreenDets.Enabled = false;
                lblNumber.Text = "N/A";
            }
        }
        #endregion

        #region OtherControls
        private void dtpBookingDate_ValueChanged(object sender, EventArgs e)
        {//usually search db for actual screen and IF FOUND set to that value but here just set to random number
            if (cmbBookingTime.SelectedIndex != -1)
            {
                btnScreenDets.Enabled = true;
                lblNumber.Text = "69";
            }
            else
            {
                btnScreenDets.Enabled = false;
                lblNumber.Text = "N/A";
            }
        }


        #endregion

        private void btnScreenDets_Click(object sender, EventArgs e)
        {
            Screen s = new Screen();
            s.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Seats s = new Seats(Convert.ToInt32(txtNoOfTicketsBooking.Text));
                s.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Esnure You Have Entered A Valid Number Of Tickets Before Selecting Seat(s)");
            }
        }
    }
}
