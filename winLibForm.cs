using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using exampleClassLibrary;
namespace WindowsClassLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculate c = new Calculate();
        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numbertxt.Text);
            outputtxt.Text = c.Remainder(number);
        }

        private void outputtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
