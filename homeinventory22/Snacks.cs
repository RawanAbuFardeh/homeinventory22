﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeinventory22
{
    public partial class Snacks : Form
    {
        public Snacks()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frminventory frm = new frminventory();
            frm.Show();
            this.Hide();
        }
    }
}
