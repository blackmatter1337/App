using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Constants

            const decimal decPACKAGE_COST = 99m;
            const decimal decDISC_10_TO_19 = 0.2m;
            const decimal decDISC_20_TO_49 = 0.3m;
            const decimal decDISC_50_TO_99 = 0.4m;
            const decimal decDISC_100_OR_MORE = 0.5m;

            //Variables
            int intQuantiy;
            decimal decTotalBeforeDiscount;
            decimal decDiscount;
            decimal decAmount;
            decimal decAfterDiscount;

            if (int.TryParse(txtQuantity.Text, out intQuantiy))
            {
                if(intQuantiy >= 100)
                {
                    decDiscount = decDISC_100_OR_MORE;
                }
                else if (intQuantiy >= 50)
                {
                    decDiscount = decDISC_50_TO_99;
                }
                else if (intQuantiy >= 20)
                {
                    decDiscount = decDISC_20_TO_49;
                }
                else if (intQuantiy >= 10)
                {
                    decDiscount = decDISC_10_TO_19;
                }
               else
                {
                    decDiscount = 0m;
                }
                //calculate total before discount
                decTotalBeforeDiscount = intQuantiy * decPACKAGE_COST;
                decAmount = decTotalBeforeDiscount * decDiscount;
                decAfterDiscount = decTotalBeforeDiscount - decAmount;

                //display results 
                lblBeforeDiscount.Text = decTotalBeforeDiscount.ToString("c");
                lblDiscount.Text = decAmount.ToString("c");
                lblAfterDiscount.Text = decAfterDiscount.ToString("c");
            }
            else
            {
                MessageBox.Show("Input Values are incorrect!");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblAfterDiscount.Text = "";
            lblDiscount.Text = "";
            lblBeforeDiscount.Text = "";
            txtQuantity.Text = "";
        }
    }
}
