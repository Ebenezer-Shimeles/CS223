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

        private void iconButton1_Click(object obj, EventArgs sender)
        {

        }
        public Form1()
        {
         
            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in Inventory.getAllEnvs())
            {
                var inv = new UserControl1();
                inv.Click += iconButton1_Click;
                inv.price = item.Price;
              //  inv.name = item.objectName;
            //    inv.date =  new DateTime();
                inv.inveNumber = item.Number;
                inv.objectName = item.objectName;
                inv.count = 0;
                inv.isAvalable = item.IsAvailable;
                inv.paymentWay = "Master Card";
                flowLayoutPanel1.Controls.Add(inv);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        
            
        }
    }
}
