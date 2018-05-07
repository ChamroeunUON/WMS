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
using BusinessLayer.CustomerData;
using WinForm.Administrator;
using AttributeLayer;
using WinMessage;




namespace WinForm.Administrator
{
    public partial class frmCustomer : DevComponents.DotNetBar.Office2007Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        CustomerAttribute cusAtt = new CustomerAttribute();
        private String status = "";

        private void frmCustomer_Load(object sender, EventArgs e)
        {
       
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            saveCustomerType("insertCus");
          }

        private void saveCustomerType(String type)
        {
            try
            {
                cusAtt = new CustomerAttribute();
                cusAtt.ID = txtId.Text;
                cusAtt.Name = txtName.Text;
                cusAtt.Sex = cboSex.SelectedItem.ToString();
                cusAtt.Phone = txtPhone.Text;
                cusAtt.Email = txtEmail.Text;
                cusAtt.Note = txtNote.Text;
                cusAtt.Address = txtAddress.Text;
                OperationCustomer cus = new OperationCustomer();
                cus.ID = cusAtt.ID;
                cus.Name = cusAtt.Name;
                cus.Sex = cusAtt.Sex;
                cus.Phone = cusAtt.Phone;
                cus.Email = cusAtt.Email;
                cus.Note = cusAtt.Note;
                cus.Address = cusAtt.Address;
                cus.saveType(type);
            }
            catch (Exception E)
            {
                MyMessage.showMessage("frmCustomer :  " + E);
                return;
            }
        }

      
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmCustomerList frmCustomerList = new frmCustomerList();
            frmCustomerList.ShowDialog();
            if (frmCustomerList.SelectCustomer != null)
            {
                cusAtt=frmCustomerList.SelectCustomer;
                txtId.Text = cusAtt.ID;
                txtName.Text = cusAtt.Name;
                cboSex.Text = cusAtt.Sex;
                txtPhone.Text = cusAtt.Phone;
                txtEmail.Text = cusAtt.Email;
                txtNote.Text = cusAtt.Note;
                txtAddress.Text = cusAtt.Address;
                
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OperationCustomer cus = adapterPropertie();
            cus.saveType("updateCus");
            
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            OperationCustomer cus = adapterPropertie();
            cus.saveType("deleteCus");
        }

        private OperationCustomer adapterPropertie()
        {
            OperationCustomer cus = new OperationCustomer();
            cus.ID = txtId.Text;
            cus.Name = txtName.Text;
            cus.Sex = cboSex.SelectedText.ToString();
            cus.Phone = txtPhone.Text;
            cus.Email = txtEmail.Text;
            cus.Note = txtNote.Text;
            cus.Address = txtAddress.Text;
            return cus;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
           
        }

    }
}
