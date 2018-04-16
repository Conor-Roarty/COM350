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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        #region Buttons
        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            this.Close();//same again
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullname.Clear();
            txtEmail.Clear();
            txtPostCode.Clear();
            cmbAddress.Items.Clear();
            cmbPhone.Items.Clear();
        }
        private void btnDetailsReturn_Click(object sender, EventArgs e)
        {
            TheatreBooking theatre = new TheatreBooking();
            theatre.Show();
            this.Close();
        }

        private void btnDetailsHelp_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
