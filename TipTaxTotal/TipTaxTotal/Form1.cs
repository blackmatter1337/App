using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipTaxTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the app
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //variables
            double dblTip;
            double dblTax;
            double dblTotal;
            double dblPrice;
            //calculations
            dblPrice = double.Parse(txtPrice.Text);
            
            dblTip = dblPrice * 0.15;
            dblTax = dblPrice * 0.07;
            dblTotal = dblTax + dblTip + dblPrice;
            //display results
            lblTip.Text = dblTip.ToString("c");
            lblTax.Text = dblTax.ToString("c");
            lblTotal.Text = dblTotal.ToString("c");
        }
    }
}
