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
        }

        #region Buttons
        private void btnBookingReturn_Click(object sender, EventArgs e)
        {
            TheatreBooking theatre = new TheatreBooking();
            theatre.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookingNo.Clear();
            txtEmail.Clear();
            txtName.Clear();
            cmbMovieTitle.Items.Clear();
            cmbBookingTime.Items.Clear();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {

        }

        private void btnWrongDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelHelp_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
