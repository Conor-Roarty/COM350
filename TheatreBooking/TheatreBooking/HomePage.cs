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
            this.Close();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            Events ev = new Events();
            ev.Show();
            this.Close();
        }

        private void btnListings_Click(object sender, EventArgs e)
        {
            Listing list = new Listing();
            list.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel c = new Cancel();
            c.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Close();
            timer1.Stop();
        }

    }
}
