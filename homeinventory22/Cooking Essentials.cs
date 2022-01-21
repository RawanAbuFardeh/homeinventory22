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
    public partial class Cooking_Essentials : Form
    {
        public Cooking_Essentials()
        {
            InitializeComponent();
        }

        private void Cooking_Essentials_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frminventory frm = new frminventory();
            frm.Show();
            this.Hide();
        }

        private void btnBeets_Click(object sender, EventArgs e)
        {
            string message = "Beets added successfuly to the cart";
                
            MessageBox.Show(message);

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnBroccoli_Click(object sender, EventArgs e)
        {
            string message = "Brocoli added successfuly to the cart";

            MessageBox.Show(message);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCabbage_Click(object sender, EventArgs e)
        {
            string message = "Cabbage added successfuly to the cart";

            MessageBox.Show(message);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCarrots_Click(object sender, EventArgs e)
        {
            string message = "Carrots added successfuly to the cart";

            MessageBox.Show(message);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCucumbers_Click(object sender, EventArgs e)
        {
            string message = "Cucumbers added successfuly to the cart";

            MessageBox.Show(message);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGarlic_Click(object sender, EventArgs e)
        {
            string message = "Garlic added successfuly to the cart";

            MessageBox.Show(message);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLettuce_Click(object sender, EventArgs e)
        {
            string message = "lettuce added successfuly to the cart";

            MessageBox.Show(message);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnOnion_Click(object sender, EventArgs e)
        {
            string message = "Onion added successfuly to the cart";

            MessageBox.Show(message);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnPeppers_Click(object sender, EventArgs e)
        {
            string message = "Peppers added successfuly to the cart";

            MessageBox.Show(message);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnPotatoe_Click(object sender, EventArgs e)
        {
            string message = "Potato added successfuly to the cart";

            MessageBox.Show(message);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnTomtoes_Click(object sender, EventArgs e)
        {
            string message = " tomato added successfuly to the cart";

            MessageBox.Show(message);

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnSpinach_Click(object sender, EventArgs e)
        {
            string message = "Spinach added successfuly to the cart";

            MessageBox.Show(message);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnCorn_Click(object sender, EventArgs e)
        {
            string message = "Corn added successfuly to the cart";

            MessageBox.Show(message);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnMushrooms_Click(object sender, EventArgs e)
        {
            string message = "Mushrooms added successfuly to the cart";

            MessageBox.Show(message);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnPea_Click(object sender, EventArgs e)
        {
            string message = "Peas added successfuly to the cart";

            MessageBox.Show(message);

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
