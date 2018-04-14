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
    public partial class Listing : Form
    {
        public Listing()
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

        private void btnBookingHelp_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
