﻿using System;
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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void btnBookingReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}