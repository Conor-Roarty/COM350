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
        #region Initializations

        //Initializing Certain UI elements
        public Booking()
        {
            InitializeComponent();
            radBtnNoWheelchair.Select();
            dtpBookingDate.Value = DateTime.Today;
            dtpBookingDate.MinDate = DateTime.Today;
            dtpBookingDate.MaxDate = DateTime.Today.AddMonths(2);
            cmbBookingTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMovieBook.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBookingTime.SelectedIndex = 0;
            cmbMovieBook.SelectedIndex = 0;
        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Buttons

        //Button to go to screen Details
        private void btnScreenDets_Click(object sender, EventArgs e)
        {
            Screen s = new Screen();
            s.Show();
        }

        //Button to return to homepage
        private void btnBookingReturn_Click(object sender, EventArgs e)
        {
            TheatreBooking theatre = new TheatreBooking();
            theatre.Show();
            this.Close();
        }

        //Button to proceed to details page
        private void btnProceed_Click(object sender, EventArgs e)
        {
            //Change to details page so we have details for ticket printing, payment to come last
            int parse;
            bool valid = true;

            //Validation Checker for various fields
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

            if (cmbBookingTime.SelectedIndex == -1 || cmbBookingTime.SelectedIndex == 0)
            {
                epTime.SetError(cmbBookingTime, "This Is A Required Field");
                valid = false;
            }
            else
                epTime.Clear();

            if (cmbMovieBook.SelectedIndex == -1 || cmbMovieBook.SelectedIndex == 0)
            {
                epMovie.SetError(cmbMovieBook, "This Is A Required Field");
                valid = false;
            }
            epMovie.Clear();

            if (valid)
            {
                Details d = new Details();
                d.Show();
                //this.Close();//do not close, keep running so details stay and not everything has to be re-entered, just editted
            }
        }

        //Clear the current fields
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNoOfTicketsBooking.Clear();
            txtOtherReqs.Clear();
            cmbBookingTime.SelectedIndex = 0;
            cmbMovieBook.SelectedIndex = 0;
            radBtnNoWheelchair.Checked = true;
            radBtnYesWheelchair.Checked = false;
        }

        private void btnBookingHelp_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }
        #endregion

        #region ComboBoxes

        //If statement checks which movie is selected by index value and displays appropriate poster
        private void cmbMovieBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            label23.Text = cmbMovieBook.SelectedItem.ToString();

            if (cmbMovieBook.SelectedIndex != 0 && cmbBookingTime.SelectedIndex != 0)
            {
                btnScreenDets.Enabled = true;
                lblNumber.Text = "12";
            }
            else if (cmbMovieBook.SelectedIndex == 1)
            {
                pictureBox1.Image = Properties.Resources.ForceAwakens;
            }
            else if (cmbMovieBook.SelectedIndex == 2)
            {
                pictureBox1.Image = Properties.Resources.PulpFiction;
            }
            else if (cmbMovieBook.SelectedIndex == 3)
            {
                pictureBox1.Image = Properties.Resources.Jumanji;
            }
            else if (cmbMovieBook.SelectedIndex == 4)
            {
                pictureBox1.Image = Properties.Resources.The_Room;
            }
            else if (cmbMovieBook.SelectedIndex == 5)
            {
                pictureBox1.Image = Properties.Resources.Avengers;
            }
            else if (cmbMovieBook.SelectedIndex == 6)
            {
                pictureBox1.Image = Properties.Resources.shapeofwater;
            }
        }

        private void cmbBookingTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMovieBook.SelectedIndex != 0 && cmbBookingTime.SelectedIndex != 0)
            {
                btnScreenDets.Enabled = true;
                lblNumber.Text = "12";
            }
        }

        #endregion

        #region otherControls
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

        private void txtNoOfTicketsBooking_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Char.IsDigit((char)e.KeyValue))
                e.SuppressKeyPress = true;
        }

        private void btnBookingHelp_Click_1(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }
        #endregion
    }
}
