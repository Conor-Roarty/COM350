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
           
        }

        private void btnBookingReturn_Click(object sender, EventArgs e)
        {
            TheatreBooking theatre = new TheatreBooking();
            theatre.Show();
            this.Hide();
        }

        private void radBtnCard_CheckedChanged(object sender, EventArgs e)
        {
            grpCashPayment.Visible = false;
            grpCardDetails.Visible = true;
        }

        private void radBtnCash_CheckedChanged(object sender, EventArgs e)
        {
            grpCardDetails.Visible = false;
            grpCashPayment.Visible = true;
        }

        private void radBtnCOA_CheckedChanged(object sender, EventArgs e)
        {
            grpCardDetails.Visible = false;
            grpCashPayment.Visible = true;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Booking back = new Booking();
            back.Show();
            this.Hide();
        }
    }
}
