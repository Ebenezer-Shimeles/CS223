using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;



namespace Ticker
{
    public partial class Form11 : Form
    {
        public Form11()
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
                var colorItem = groupBox1.Controls
                    .OfType<RadioButton>()
                    .FirstOrDefault(r => r.Checked);

                var sizeItem = groupBox2.Controls.OfType<RadioButton>()
                    .FirstOrDefault(r => r.Checked);
                var inv = new Inventory(
                    int.Parse(textBox1.Text),
                    dateTimePicker1.Value,
                    int.Parse(textBox3.Text),
                    textBox4.Text,
                    int.Parse(textBox5.Text),
                    double.Parse(textBox2.Text),
                    checkBox1.Checked,

                    colorItem.Text,
                    sizeItem.Text


                );
              

                var inventoryPattren = new Regex(@"[0-9]{3}");
                //must be three digits
                var objectNamePattern = new Regex(@"[A-Z]{1}[a-z]+");
                //must begin with a capital letter and all others must be smalle

                if (textBox4.Text.Length == 0)
                {
                    errorProvider1.SetError(textBox4, "Error This must not be empty");
                    
                    //throw new Exception("Empty String Game");
                }
                else errorProvider1.Clear();
                if (!inventoryPattren.IsMatch(textBox3.Text))
                {
                    throw new Exception("Error in inventory format");
                }
                if (!objectNamePattern.IsMatch(textBox4.Text))
                {
                    throw new Exception("Object Name Should Start " +
                        "with Capital letter and the rest should be small letter");
                }
                inv.Save();
                dataGridView1.DataSource = Inventory.getAllEnvs();
            }
            catch(Exception ex)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
