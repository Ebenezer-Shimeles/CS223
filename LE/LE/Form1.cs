using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                totalText.Text = "" + (Double.Parse(ammountText.Text) *  Double.Parse(vatText.Text) + Double.Parse(ammountText.Text));
            }catch(FormatException )
            {
                MessageBox.Show("Error in number format!");
            }
        }

        private void ammountText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
