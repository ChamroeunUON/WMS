using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace ShopManagementCSharp.CustomerInfo
{
    public partial class frmCustomer : Form
    {
      
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Customer cus = new Customer();
            cus.ID = txtId.Text;
            cus.Name = txtName.Text;
            cus.Gender = txtName.Text;
            cus.Phone = txtPhone.Text;
            if (cus.save())
            {
                  MessageBox.Show("Success..");
            }

          
        }
    }
}
