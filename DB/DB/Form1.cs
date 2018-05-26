using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DB
{
    public partial class Form1 : Form
    {
        private SqlConnection cn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader rd;
        private string cnstr =
            @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            @"AttachDbFilename=|DataDirectory|\Database1.mdf;" +
            "Integrated Security=True;" +
            "Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = cnstr;
            cn.Open();

            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Table]";

            rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                listBox1.Items.Add(
                    String.Format("[{0}] {1,-10} {2,-10} {3,-30} 【Tel】{4}",
                    rd["Id"], rd["Name"], rd["ZipCode"],
                    rd["Address"], rd["Tel"]));
            }
            rd.Close();
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
