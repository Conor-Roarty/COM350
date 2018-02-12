using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical1
{
    public partial class Practical1_Easy : Form
    {
        public Practical1_Easy()
        {
            InitializeComponent();
        }

        private void Practical1_Easy_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Clicked");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Cancelled");
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Random AF");
        }
    }
}
