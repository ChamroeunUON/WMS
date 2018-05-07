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

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;" +
                                      "Initial Catalog=ShopManagementCSharp;" +
                                       "User id=sa;" +
                                       "Password=123456;");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.AllCustomer", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            da.Dispose();
            dt.Dispose();
           
            con.Close();
            
        }
    }
}
