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
    public partial class Cancel : Form
    {
        public Cancel()
        {
            InitializeComponent();
            dtpBookingDate.Value = DateTime.Today.AddDays(1);//tomorrow
            dtpBookingDate.MinDate = DateTime.Today;
            dtpBookingDate.MaxDate = DateTime.Today.AddMonths(2);
            cmbMovieTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBookingTime.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #region Buttons
        private void btnBookingReturn_Click(object sender, EventArgs e)
        {
            TheatreBooking theatre = new TheatreBooking();
            theatre.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBookingNo.Text.ToLower() == "b001")
            {
                lblInfo.Text = "Conor Roarty\n\nconorroarty@ulster.com\n\n1\n\nPulp Fiction\n\n" + dtpBookingDate.Value.Date.ToShortDateString() + "  at 10:00pm" + "\n\nA1\n\nNot Specified\n\n£5.50";
                btnWrongDetails.Enabled = true;
                btnCancelBooking.Enabled = true;
            }
            else
                MessageBox.Show("We could not find your booking, please try again.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookingNo.Clear();
            txtEmail.Clear();
            txtName.Clear();
            cmbMovieTitle.Items.Clear();
            cmbBookingTime.Items.Clear();
            btnWrongDetails.Enabled = false;
            btnCancelBooking.Enabled = false;
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (lblInfo.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Cancel This Booking", "Cancellation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Please take your money. Have a nice day.");
                    this.Close();
                }
            }
            else
                MessageBox.Show("Sorry, we could not find the booking to cancel, please try to search agin.");
        }
        private void btnWrongDetails_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            btnClear_Click(sender, e);
        }
        private void btnCancelHelp_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }
        #endregion
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Char.IsLetter((char)e.KeyValue))
                e.SuppressKeyPress = true;
        }
    }
}
