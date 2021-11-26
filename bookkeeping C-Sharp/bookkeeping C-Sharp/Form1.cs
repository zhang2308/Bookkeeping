using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bookkeeping_C_Sharp
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlcon;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand sqlcom = new SqlCommand("select * from AssetTable;", sqlcon);
            SqlDataReader sqlr = sqlcom.ExecuteReader();
            if(sqlr.Read())
            {
                MessageBox.Show(Convert.ToString(sqlr.FieldCount), "title");
            }
            else
            {
                MessageBox.Show("no", "title");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Asset;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlcon = new SqlConnection(sql);
            sqlcon.Open();
        }
    }
}
