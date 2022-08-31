using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//System.Data.SqlClien

namespace Ticker
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void ConnectSql()
        {
            SqlConnection conn = new SqlConnection("Data Source = .; Database=Ecomm; Integrated Security = true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"select * from users", conn); 
            
            SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("IT is working");
            MessageBox.Show("It is working bitch");
            while (reader.Read())
            {
               // MessageBox.Show(reader.GetString(1));

            }
        }
        
        [STAThread]
        static void Main()
        {
            ConnectSql();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}
