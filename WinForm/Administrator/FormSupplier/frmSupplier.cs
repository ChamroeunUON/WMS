using System;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WinForm.Models;

namespace WinForm.Administrator.FormSupplier
{
    public partial class frmSupplier : Office2007Form
    {
        private readonly AppContext _appContext;
        private Supplier _supplier;
        private  readonly string DefualtString = "N/A";

        private Supplier FormData
        {
            get
            {
                var supplier = new Supplier
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Website = txtWebsite.Text,
                    Note = txtNote.Text,
                    Address = txtAddress.Text
                };
                return supplier;
            }
        }

        public frmSupplier()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }


        private void frmSupplier_Load(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Name is required!", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                    txtEmail.Text = DefualtString;
                if (string.IsNullOrWhiteSpace(txtPhone.Text))
                    txtPhone.Text = DefualtString;
                if (string.IsNullOrWhiteSpace(txtWebsite.Text))
                    txtWebsite.Text = DefualtString;
                if (string.IsNullOrWhiteSpace(txtNote.Text))
                    txtNote.Text = DefualtString;
                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                    txtAddress.Text = DefualtString;
                if (_supplier == null)
                {
                    var supplier = FormData;
                    _appContext.Suppliers.Add(supplier);
                }
                else
                {
                    _supplier.Name = FormData.Name;
                    _supplier.Phone = FormData.Phone;
                    _supplier.Email = FormData.Email;
                    _supplier.Website = FormData.Website;
                    _supplier.Note = FormData.Note;
                    _supplier.Address = FormData.Address;
                }
                _appContext.SaveChanges();
                _supplier = null;
                MessageBox.Show("Succesfuyly", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error meaasge:" + exception, @"Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var suppliers = _appContext.Suppliers.ToList();
            foreach (var supplier in suppliers)
                dataGridView1.Rows.Add(supplier.Id, supplier.Name,
                    supplier.Email, supplier.Phone,
                    supplier.Address, supplier.Note);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                _supplier = _appContext.Suppliers.Find(id);
                if (_supplier != null)
                {
                    txtName.Text = _supplier.Name;
                    txtPhone.Text = _supplier.Phone;
                    txtEmail.Text = _supplier.Email;
                    txtWebsite.Text = _supplier.Website;
                    txtNote.Text = _supplier.Note;
                    txtAddress.Text = _supplier.Address;
                }
                tabControl1.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Message: " + exception, @"Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var dialogResult = MessageBox.Show("Are you sure want to delete this Supplier?",
                    @"Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    var id = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    var supplier = _appContext.Suppliers.Find(id);
                    _appContext.Suppliers.Remove(supplier);
                    _appContext.SaveChanges();
                    tabControl1_SelectedIndexChanged(null, null);
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erroe Meassge:" + exception, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
