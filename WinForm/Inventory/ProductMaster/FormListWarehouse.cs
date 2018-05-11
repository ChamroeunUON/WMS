using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Models;

namespace WinForm.Inventory.ProductMaster
{
    public partial class FormListWarehouse : Form
    {
        private AppContext _appContext;
        private Models.ProducWarehouse _producWarehouse;
        public FormListWarehouse()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }

        public string WarehouseId
        {
            get
            {
                var id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                return id;
            }
        }
        public string WarehouseName 
        {
            get
            {
                var id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                return id;
            }
        }
        private void FormListWarehouse_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var warehouses = _appContext.Warehouses.ToList();
            foreach (var warehouse in warehouses)
            {
                dataGridView1.Rows.Add(warehouse.Id, warehouse.NameEN,warehouse.NameKH,warehouse.Address);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
