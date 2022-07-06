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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

           //x.Price = double.Parse(textBox2.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var inv = new Inventory(
                    int.Parse(textBox1.Text),
                    dateTimePicker1.Value,
                    int.Parse(textBox3.Text),
                    textBox4.Text,
                    int.Parse(textBox5.Text),
                    double.Parse(textBox2.Text)

                );
                inv.Save();
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            check(sender, e);
            if (textBox1.Text == "10") {
                textBox1.Text = "0";
                return;
            }

            textBox1.Text = Convert.ToString(Double.Parse(textBox1.Text) + 1);
        }
        private void check(object sender, EventArgs e)

        {
            if(textBox1.Text == textBox2.Text && textBox2.Text == textBox3.Text && textBox1.Text != "0" && timer1.Enabled)
            {
                button2_Click(sender, e);
                MessageBox.Show("Won at " + textBox1.Text);
               
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            check(sender, e);
            if (textBox3.Text == "10")
            {
                textBox3.Text = "0";
                return;
            }
           // check(sender, e);
            textBox3.Text = Convert.ToString(Double.Parse(textBox3.Text) + 1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            check(sender, e);
            if (textBox2.Text == "10")
            {
                textBox2.Text = "0";
                return;
            }
            textBox2.Text = Convert.ToString(Double.Parse(textBox2.Text) + 1);

        }
    }
}
