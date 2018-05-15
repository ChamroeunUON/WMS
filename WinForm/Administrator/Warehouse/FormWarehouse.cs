using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WinForm.Models;

namespace WinForm.Administrator.Warehouse
{
    public partial class FormWarehouse : Office2007Form
    {
        private AppContext _appContext;
        private Models.Warehouse _warehouse;

        private Models.Warehouse FormData
        {
            get
            {
                var warehouse = new Models.Warehouse
                {
                    NameEN = txtNameEN.Text,
                    NameKH = txtNameKH.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    Fax = txtFax.Text,
                    Note = txtNote.Text,
                    Email = txtEmail.Text
                };
                return warehouse;
            }
        }
        public FormWarehouse()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }

        private void FormWarehouse_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_warehouse == null)
            {
                var warehouse = FormData;
                _appContext.Warehouses.Add(warehouse);
                MessageBox.Show("Inserted");
            }
            else
            {
                _warehouse.NameEN = txtNameEN.Text;
                _warehouse.NameKH = txtNameKH.Text;
                _warehouse.Phone = txtPhone.Text;
                _warehouse.Email = txtEmail.Text;
                _warehouse.Fax = txtFax.Text;
                _warehouse.Address = txtAddress.Text;
                _warehouse.Note = txtNote.Text;
                MessageBox.Show("Updated");
            }
            _warehouse = null;
            _appContext.SaveChanges();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var warehouses = _appContext.Warehouses.ToList();
            foreach (var warehouse in warehouses)
            {
                dataGridView1.Rows.Add(warehouse.Id, warehouse.NameEN, warehouse.NameKH, warehouse.Phone,
                    warehouse.Note, warehouse.Address);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var id =int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                _warehouse = _appContext.Warehouses.Find(id);
                if (_warehouse != null) { 
                txtNameEN.Text = _warehouse.NameEN;
                txtNameKH.Text = _warehouse.NameKH;
                txtPhone.Text = _warehouse.Phone;
                txtEmail.Text = _warehouse.Email;
                txtFax.Text = _warehouse.Fax;
                txtNote.Text = _warehouse.Note;
                txtAddress.Text = _warehouse.Address;
                }
                tabControl1.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error :" + exception);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = MessageBox.Show("Are you sure want to delete this warehouse?", @"Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog != DialogResult.Yes) return;
                var id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                var warehouse = _appContext.Warehouses.Find(id);
                if (warehouse != null) _appContext.Warehouses.Remove(warehouse);
                _appContext.SaveChanges();
                tabControl1_SelectedIndexChanged(null, null);
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error :" + exception);
            }
        }
    }
}
