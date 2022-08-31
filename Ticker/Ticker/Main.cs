using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
  Range And Search By name using List.Find andf FindAll

 */
namespace Ticker
    
{
    internal class Template<T>
    {
        T storer;
    }
    public partial class Main : Form
    {
        List<int> x;
       

        public Main()
        {
         //   x.Find((x) => x > 4);
           // x.FindAll((x) => x > 4);
            InitializeComponent();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;

            if(active != null)
            {
                active.Close();
            }
            var form = new Form11();

            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //   MessageBox.Show("HELLO SOLIDER");
            Form active = this.ActiveMdiChild;

            if (active != null)
            {
                active.Close();
            }
            var form = new Form1();

            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }
    }
}
