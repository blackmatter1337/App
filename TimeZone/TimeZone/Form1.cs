using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeZone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string strCity;

            if(lstCity.SelectedIndex != -1)
            {
                strCity = lstCity.SelectedItem.ToString();
                switch (strCity)
                {
                    case "Honolulu":
                        lblTimeZone.Text = "Hawaii-Aleutian";
                        break;
                    case "Denver":
                        lblTimeZone.Text = "Mountain";
                        break;
                    case "New York":
                        lblTimeZone.Text = "Eastern";
                        break;
                    case "Minneapolis":
                        lblTimeZone.Text = "Central";
                        break;
                    case "San Francisco":
                        lblTimeZone.Text = "Pacific";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a city.");
            }
        }
    }
}
