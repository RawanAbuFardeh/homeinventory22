using System;
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
    public partial class frminventory : Form
    {
        public frminventory()
        {
            InitializeComponent();
        }

        private void frminventory_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCooking_Click(object sender, EventArgs e)
        {
            Cooking_Essentials frm2 = new Cooking_Essentials();
            frm2.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBath_Click(object sender, EventArgs e)
        {
            Bath_essentials frm3 = new Bath_essentials();
            frm3.Show();
            this.Hide();
        }

        private void btnElectronics_Click(object sender, EventArgs e)
        {
            Home_electronics frm4 = new Home_electronics();
            frm4.Show();
            this.Hide();

        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            Snacks frm5 = new Snacks();
            frm5.Show();
            this.Hide();
        }
    }

}
