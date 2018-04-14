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
    public partial class TheatreBooking : Form
    {
        public TheatreBooking()
        {
            InitializeComponent();
        }

        private void TheatreBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Booking book = new Booking();
            book.Show();
            this.Hide();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            Events ev = new Events();
            ev.Show();
            this.Hide();
        }

        private void btnListings_Click(object sender, EventArgs e)
        {
            Listing list = new Listing();
            list.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel c = new Cancel();
            c.Show();
            this.Hide();
        }
    }
}
