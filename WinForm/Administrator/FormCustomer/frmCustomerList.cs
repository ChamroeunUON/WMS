using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.CustomerData;
using AttributeLayer;
using WinMessage;
using WinForm.Administrator;
using System.Data.SqlClient;
using DatabaseLayer;

namespace WinForm.Administrator
{
    public partial class frmCustomerList : DevComponents.DotNetBar.Office2007Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }
        public CustomerAttribute customerAttribute;
        public GetCustomer gcm;
        public CustomerAttribute SelectCustomer
        {
            get { return customerAttribute; }
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            List<CustomerAttribute> listCustomer = new List<CustomerAttribute>();

            try
            {
                gcm = new GetCustomer();
                DataTable dt = gcm.getAllCustomer;
                dataGridView1.DataSource = dt;
                dt.Dispose();
                //customerAttribute = new CustomerAttribute();
                //DataTable dt = gcm.listCustomer;
               
                    
                //foreach (DataRow row in dt.Rows)
                //{
                //    customerAttribute.ID = row["Id"].ToString();
                //    customerAttribute.Name = row["Name"].ToString();
                //    customerAttribute.Sex = row["Sex"].ToString();
                //    customerAttribute.Phone = row["Phone"].ToString();
                //    customerAttribute.Email = row["Email"].ToString();
                //    customerAttribute.Note = row["Note"].ToString();
                //    listCustomer.Add(customerAttribute);
                //}
               
                //    dataGridView1.DataSource = listCustomer;
            }
            catch (Exception E)
            {
                MyMessage.showMessage("frmCustomerLoad  : " + E);
            }

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedCells[1].Value.ToString();
                GetCustomer cus = new GetCustomer();
                customerAttribute = new CustomerAttribute();
                customerAttribute = cus.getCustomerById(id);
                this.Dispose();
                
              //  DataTable dt = gcm.showCustomerById(id);
               // List<CustomerAttribute> listCus = new List<CustomerAttribute>();
                //if (dt.Rows.Count >= 1)
                //{
                //    CustomerAttribute customerAtt = new CustomerAttribute();
                //    DataRow dr = dt.Rows[0];
                //    customerAtt.ID = dr[0].ToString();
                //    customerAtt.Name = dr[1].ToString();
                //    customerAtt.Sex = dr[2].ToString();
                //    customerAtt.Phone = dr[3].ToString();
                //    customerAtt.Email = dr[4].ToString();
                //    customerAtt.Note = dr[5].ToString();
                //    customerAtt.Address = dr[6].ToString();
                //}
               // this.Dispose();
                //foreach (DataRow dr in dt.Rows)
                //{
                //    MessageBox.Show("ID is : " + dr, "Data");
                //}
               
            }
            catch (Exception E)
            {
                MyMessage.showMessage("frmCustomer List : " + E);
            }
            
            //try
            //{
            //    String id = dataGridView1
            //    customer = Customer.getCustomer(id);
            //    this.Dispose();
            //}
            //catch (Exception E)
            //{
            //    MessageBox.Show("" + E);
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

} 

