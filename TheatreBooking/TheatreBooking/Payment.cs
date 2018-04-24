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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            radBtnCard.Select();
            grpCashPayment.Visible = false;
            grpCardDetails.Visible = true;
            gbArrival.Visible = false;
            gbCardReader.Visible = false;
        }

        private void btnBookingReturn_Click(object sender, EventArgs e)
        {
            TheatreBooking theatre = new TheatreBooking();
            theatre.Show();
            this.Close();
        }

        private void radBtnCard_CheckedChanged(object sender, EventArgs e)
        {
            grpCashPayment.Visible = false;
            grpCardDetails.Visible = true;
            gbArrival.Visible = false;
            gbCardReader.Visible = false;
        }

        private void radBtnCash_CheckedChanged(object sender, EventArgs e)
        {
            grpCardDetails.Visible = false;
            grpCashPayment.Visible = true;
            gbArrival.Visible = false;
            gbCardReader.Visible = false;
        }

        private void radBtnCOA_CheckedChanged(object sender, EventArgs e)
        {
            grpCardDetails.Visible = false;
            grpCashPayment.Visible = false;
            gbArrival.Visible = true;
            gbCardReader.Visible = false;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            ConfirmedBooking cb = new ConfirmedBooking();
            cb.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Booking back = new Booking();
            back.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmedBooking cb = new ConfirmedBooking();
            cb.Show();
            this.Close();
        }

        private void rbCardEnter_CheckedChanged(object sender, EventArgs e)
        {
            grpCardDetails.Visible = false;
            grpCashPayment.Visible = false;
            gbArrival.Visible = false;
            gbCardReader.Visible = true;
        }

        private void btnCardHelp_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }
    }
}
