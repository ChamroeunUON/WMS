using System;
using System.CodeDom;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WinForm.Models;

namespace WinForm.Administrator
{
    public partial class frmCustomer : Office2007Form
    {
        public string DefaultString = "N/A";
        private readonly AppContext _appContext;
//        private Models.Customer _customer;
//        private Models.Customer FormData
//        {
//            
//            get
//            {
//                var customer = new Customer
//                {
//                    Name = txtName.Text,
//                    Sex = cboSex.SelectedItem.ToString(),
//                    Phone = txtPhone.Text,
//                    Address = txtAddress.Text,
//                    Email = txtEmail.Text,
//                    Note = txtNote.Text
//                };
//                return customer;
//            }
//        }
        public frmCustomer()
        {
            _appContext = new AppContext();

            InitializeComponent();
        }


        private void frmCustomer_Load(object sender, EventArgs e)
        {
           
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "") txtEmail.Text = DefaultString;
                if (txtAddress.Text == "") txtAddress.Text = DefaultString;
                if (txtPhone.Text == "") txtPhone.Text = DefaultString;
                if (txtNote.Text == "") txtNote.Text = DefaultString;
//
//                if (_customer == null)
//                {
//                    var customer = FormData;
//                    _appContext.Customers.Add(customer);
//                }
//                else
//                {
//                    _customer.Name = FormData.Name;
//                    _customer.Sex = FormData.Sex;
//                    _customer.Phone = FormData.Phone;
//                    _customer.Email = FormData.Email;
//                    _customer.Note = FormData.Note;
//                    _customer.Address = FormData.Address;
//                    
//                }
//                _appContext.SaveChanges();
//                _customer = null;
                MessageBox.Show("Successfuly", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception+" ", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          
        }

        private void panel1_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
//            var customers = _appContext.Customers.ToList();
//            foreach (var customer in customers)
            {
//                dataGridView1.Rows.Add(customer.Id, customer.Name, customer.Sex, customer.Phone, customer.Address);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
//            try
//            {
//                var id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
//                 _customer=_appContext.Customers.Find(id);
//                if (_customer != null)
//                {
//                    txtName.Text = _customer.Name;
//                    cboSex.SelectedItem = _customer.Sex;
//                    txtPhone.Text = _customer.Phone;
//                    txtEmail.Text = _customer.Email;
//                    txtAddress.Text = _customer.Address;
//                    txtNote.Text = _customer.Note;
//                }
//                tabControl1.SelectedIndex = 0;
//            }
//            catch (Exception exception)
//            {
//                MessageBox.Show(exception + " ");
//            }
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this customer?",
                @"Message", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }
            else
            {
                var id = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
//                var customer = _appContext.Customers.Find(id);
//                _appContext.Customers.Remove(customer);
                _appContext.SaveChanges();
                tabControl1_SelectedIndexChanged(null,null);
            }
        }
    }
}