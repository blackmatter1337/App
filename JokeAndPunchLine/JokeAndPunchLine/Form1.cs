using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokeAndPunchLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnSetup i forgot to name before i accidentaly double clicked again im horrible at this... but this is to setup the joke.
            lblOutput.Text = "Here's how I feel about gay marriage. I don't understand why people care whether you marry a man or a woman. ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //damn forgot to name my button first again. but this is for the puchline.
            lblOutput.Text = "'Cause if you've ever seen a couple over 65, it is very hard to tell who is who";
        }
    }
}
