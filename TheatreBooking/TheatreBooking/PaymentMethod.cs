using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace TheatreBooking
{
    public partial class PaymentMethod : Form
    {
        public PaymentMethod()
        {
            InitializeComponent();
        }

        private void PaymentMethod_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Payment p = new Payment();
                p.Visible = true;
            }
            else if (radioButton5.Checked)
            {
                System.Diagnostics.Process.Start("http://www.paypal.com");
            }
            else if (radioButton4.Checked)
            {
                ConfirmedBooking cb = new ConfirmedBooking();
                cb.Visible = true;
            }
            else
                MessageBox.Show("Must Cancel Or Make A Selection");
        }
    }
}
