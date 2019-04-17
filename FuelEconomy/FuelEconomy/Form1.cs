using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelEconomy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGallons.Text = "";
            txtMiles.Text = "";
            lblMPG.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dblMiles;
            double dblGallons;
            double dblMPG;

            dblMiles = double.Parse(txtMiles.Text);
            dblGallons = double.Parse(txtGallons.Text);

            dblMPG = dblMiles / dblGallons;

            lblMPG.Text = dblMPG.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
