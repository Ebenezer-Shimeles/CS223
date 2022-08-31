using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;
            if(username != "admin")
            {
                MessageBox.Show("Account does not exist");
                return;
            }
            if(password != "1234")
            {
                MessageBox.Show("Padsword invalid");
                return;

            }
            var form = new Main();
            this.Visible = false;
            form.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
