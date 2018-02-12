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
            book.Visible = true;
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            Events ev = new Events();
            ev.Visible = true;
        }

        private void btnListings_Click(object sender, EventArgs e)
        {
            Listing l = new Listing();
            l.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel c = new Cancel();
            c.Visible = true;
        }
    }
}
