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
    public partial class UserControl1 : UserControl
    {
        private int _count;

        public int count
        {
            get { return _count; }
            set { }
        }

        private int _inveNumber;

        public int inveNumber
        {
            get { return _inveNumber; }
            set { _inveNumber = value; label2.Text = value.ToString(); }
        }
        private string _name;

        public string name
        {
            get { return _name; }
         //   set { _name = value; label3.Text = value; }
        }
        private string _date;

        public string date
        {
            get { return _date; }
           // set { _date = value; label4.Text = value; }
        }

        private string _objectName;

        public string objectName
        {
            get { return _objectName; }
            set { _objectName = value; label5.Text = value; }
        }

        private double _price;

        public double price
        {
            get { return _price; }
            set { _price = value; label6.Text = value.ToString(); }
        }

        private bool _isAvalable;

        public bool isAvalable
        {
            get { return _isAvalable; }
            set { _isAvalable = value; label7.Text = value.ToString(); }
        }

        private string _payment;

        public string paymentWay
        {
            get { return _payment; }
            set { _payment = value; label8.Text = value; }
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
