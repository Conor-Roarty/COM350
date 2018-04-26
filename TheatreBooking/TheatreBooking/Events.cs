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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        private void btnBookingReturn_Click(object sender, EventArgs e)
        {
            TheatreBooking theatre = new TheatreBooking();
            theatre.Show();
            this.Close();
        }
        private void btnMondayOffer_Click(object sender, EventArgs e)
        {
            lblEvents.Text = "Monday Movies:\n	Half Price On All Movies During The Day (Before 7pm)";
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void btnTuesdayOffer_Click(object sender, EventArgs e)
        {
            lblEvents.Text = "Crazy Tuesdays:\n   Half Price After 7pm On Movies and Snacks";
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void btnWednesdayOffer_Click(object sender, EventArgs e)
        {
            lblEvents.Text = "Wild Wednesdays:\n	Kids Go Free Before 5pm";
            if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void btnThursdayOffer_Click(object sender, EventArgs e)
        {
            lblEvents.Text = "Thirsty Thursdays:\n	All Popcorn Comes With a Free Drink";
            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void btnFridayOffer_Click(object sender, EventArgs e)
        {
            lblEvents.Text = "Finally Fridays:\n	25% Off When You Are In A Group Of 3 Or More";
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void btnSaturdayOffer_Click(object sender, EventArgs e)
        {
            lblEvents.Text = "Super Saturdays:\n	Get Half Off Your Food and Drinks ALL DAY";
            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void btnSundayOffer_Click(object sender, EventArgs e)
        {
            lblEvents.Text = "Student Sundays:\n	40% Off Tickets If You Present Your Student Card";
            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void btnEvent1_Click(object sender, EventArgs e)
        {
            lblEvents.Text = "50 Shades Of Saving (28th Of Febuary 2018): \nMatinee Of All Movies To Date and Get a\n Free Soveniuer Mask When You Book Here";
            button1.Enabled = true;
        }

        private void btnEvent2_Click(object sender, EventArgs e)
        {
            lblEvents.Text = "Infinity War Prep(20th - 25th June 2018):\n Watch Our Shortened Movie Matinee Of\n All Important Marvel Moments Before The\n Release Of Infinity War and Get a Free Infinity\n War Ticket When You Buy NOW";
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking b = new Booking();
            b.Show();
            this.Close();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }

        private void btnEventsHelp_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }
    }
}
