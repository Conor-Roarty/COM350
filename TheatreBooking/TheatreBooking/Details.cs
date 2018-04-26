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
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullname.Clear();
            txtEmail.Clear();
            txtPostCode.Clear();
            cmbAddress.SelectedIndex = -1;
            cmbAddress.Text = "";
            txtPhoneNo.Clear();
            txtInfo.Clear();
        }
        private void btnDetailsReturn_Click(object sender, EventArgs e)
        {
            TheatreBooking theatre = new TheatreBooking();
            theatre.Show();
            this.Close();
        }

        private void btnDetailsHelp_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }
        #endregion

        private void btnPayment_Click_1(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.Show();
        }

        private void cmbAddress_Enter(object sender, EventArgs e)
        {
            if(txtPostCode.Text.ToLower() == "bt82 9qh")
            {
                for(int i = 0; i < 10; i++)
                    cmbAddress.Items.Add(i+1 + " The Orchard");
            }
        }

        private void txtFullname_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Char.IsLetter((char)e.KeyValue))
                e.SuppressKeyPress = true;
        }
    }
}
