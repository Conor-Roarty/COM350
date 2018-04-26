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
    public partial class ConfirmedBooking : Form
    {
        public ConfirmedBooking()
        {
            InitializeComponent();
        }
        #region Buttons
        private void ConfirmedBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmedReturn_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Welcome")
                    Application.OpenForms[i].Close();
            }
            timer1.Stop();
        }

        private void btnConfirmedHelp_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            for (int i = Application.OpenForms.Count -1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Welcome")
                    Application.OpenForms[i].Close();
            }
            timer1.Stop();
        }
    }
}
