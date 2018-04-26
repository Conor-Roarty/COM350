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
    public partial class Seats : Form
    {
        int count = 0;
        int num = 0;
        public Seats(int tickets)
        {
            num = tickets;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void btnCancelReturn_Click(object sender, EventArgs e)
        {
            if (count >= num)
                this.Close();
            else
            {
                string message = "You did not allocate all seats. Do you wish to continue?";
                string caption = "Unallocated Seats";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                    this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox2.Image = null;
                pictureBox2.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox4.Image = null;
                pictureBox4.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox3.Image = null;
                pictureBox3.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox5.Image = null;
                pictureBox5.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox6.Image = null;
                pictureBox6.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox7.Image = null;
                pictureBox7.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox8.Image = null;
                pictureBox8.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox9.Image = null;
                pictureBox9.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox10.Image = null;
                pictureBox10.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox22.Image = null;
                pictureBox22.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox21.Image = null;
                pictureBox21.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox19.Image = null;
                pictureBox19.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox20.Image = null;
                pictureBox20.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox18.Image = null;
                pictureBox18.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox17.Image = null;
                pictureBox17.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox16.Image = null;
                pictureBox16.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox15.Image = null;
                pictureBox15.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox14.Image = null;
                pictureBox14.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox13.Image = null;
                pictureBox13.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox33.Image = null;
                pictureBox33.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox32.Image = null;
                pictureBox32.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox30.Image = null;
                pictureBox30.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox31.Image = null;
                pictureBox31.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox29.Image = null;
                pictureBox29.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox28.Image = null;
                pictureBox28.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox27.Image = null;
                pictureBox27.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox26.Image = null;
                pictureBox26.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox25.Image = null;
                pictureBox25.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox24.Image = null;
                pictureBox24.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox44.Image = null;
                pictureBox44.Image = Properties.Resources.red_x_icon_th;
            }
        }
        private void pictureBox43_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox43.Image = null;
                pictureBox43.Image = Properties.Resources.red_x_icon_th;
            }
        }
        private void pictureBox41_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox41.Image = null;
                pictureBox41.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox55.Image = null;
                pictureBox55.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox54.Image = null;
                pictureBox54.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox52.Image = null;
                pictureBox52.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox53.Image = null;
                pictureBox53.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox40.Image = null;
                pictureBox40.Image = Properties.Resources.red_x_icon_th;
            }
        }
        private void pictureBox51_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox51.Image = null;
                pictureBox51.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox39.Image = null;
                pictureBox39.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox50.Image = null;
                pictureBox50.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox49_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox49.Image = null;
                pictureBox49.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox37.Image = null;
                pictureBox37.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox48.Image = null;
                pictureBox48.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox36.Image = null;
                pictureBox36.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox47.Image = null;
                pictureBox47.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox35.Image = null;
                pictureBox35.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox46.Image = null;
                pictureBox46.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            count++;
            if (count <= num)
            {
                pictureBox42.Image = null;
                pictureBox42.Image = Properties.Resources.red_x_icon_th;
            }
        }

        private void btnWrongDetails_Click(object sender, EventArgs e)
        {
            Seats s = new Seats(num);
            s.Show();
            this.Close();
        }
        private void btnCancelHelp_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }
    }
}
