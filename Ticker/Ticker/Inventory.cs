using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
enum InvColor
{
    Blue,
    Yellow,
    Red,
    Green
}
enum Size {
  Small,
  Medium,
  Large
}

namespace Ticker
{
    internal class Inventory
    {
        private int _number;
        private DateTime _date;
        private int inventoryNumber;
        public string objectName;
        private int _count;
        private double _price;
        private static List<Inventory> _invs = new List<Inventory>();
        private  bool _isAvailable;
        private Size _size;
        private InvColor _Color;

        public string color
        {
            get
            {
                return this._Color.ToString();
            }
            set
            {
                if (value == "Blue") this._Color = InvColor.Blue;
                else if (value == "Green") this._Color = InvColor.Green;
                else if (value == "Yellow") this._Color = InvColor.Yellow;
                else if (value == "Red") this._Color = InvColor.Red;
            }
        }
        public string size
        {
            get
            {
                return _size.ToString();
            }
            set
            {
                if (value == "Small") _size = Size.Small;
                else if (value == "Medium") _size = Size.Medium;
                else if (value == "Large") _size = Size.Large;
            }
        }


        internal Inventory(int n,
            DateTime d, int invN, string o, int c, double p, bool i,
            string size, string color
            ) {
            _number = n;
            _date = d;
            inventoryNumber= invN;
            _price = p;
            _count = c;
            objectName = o;
            _isAvailable = i;
            this.size = size;
            this.color = color;
           
        }
        public bool IsAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }
        }
        public void Save()
        {
            Console.Write($"Saving {this}");
             _invs.Add(this);
            foreach(Inventory inventory in _invs)
            {
                Console.WriteLine(inventory);
            }
        }
        public override string ToString()
        {
            return $"Number: {Number} Date {Date} Price {Price}";
        }


        public static List<Inventory> getAllEnvs()
        {
            return _invs;
        }
        public int Number{
            get { return _number; }
            set { 
                _number = value;
                if (value < 0)
                {
                    MessageBox.Show("Error in values given");
                    return;
                }
            }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public int Count { 
            get { return _count; }
            set { 
                if(value < 0)
                {
                    MessageBox.Show("Error in values given");
                    return;
                }
                _count = value; 
            } 
         }
        public double Price { get { return _price;} 
            set {
                if (value < 0)
                {
                    MessageBox.Show("Error in values given");
                    return;
                }
                _price = value; 
            } 
       }
    }
}
