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
using WinForm.Administrator.frmProduct;
using WinForm.Inventory.ProductMaster;
using WinForm.Models;

namespace WinForm.Inventory.ReceivItem
{
    public partial class FormReceiveItem : Office2007Form
    {
        private AppContext _appContext;
        public FormReceiveItem()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }

        private void FormReceiveItem_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnWarehouseId_Click(object sender, EventArgs e)
        {
            var frm = new FormListWarehouse();
            frm.ShowDialog();
            txtWarehouseId.Text = frm.WarehouseId;
            txtWarehouse.Text = frm.WarehouseName;
        }

        private void btnSupplierId_Click(object sender, EventArgs e)
        {
            var frm = new FormListSupplier();
            frm.ShowDialog();
            txtSupplierId.Text = frm.SupplierId;
            txtSupplier.Text = frm.SupplierName;
        }

        private string CheckOnhand(int warehouseId, int proId)
        {
            var qty = _appContext.ProducWarehouses
                .Where(id => id.WarehouseId == warehouseId && id.ProductId == proId)
                .Select(w => w.OnHand).ToList();

            return qty[0].ToString();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {

                if (e.ColumnIndex == 3)
                {
                    var frmProduct = new FormListProduct();
                    frmProduct.ShowDialog();
                    MessageBox.Show(CheckOnhand(1,1));
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value == null) break;
                        if (frmProduct.SelectProduct.Id.Equals(row.Cells[0].Value.ToString()))
                        {
                            MessageBox.Show("Aleady Added.");
                            return;
                        }
                    }

                    var dataGridViewRow = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    dataGridViewRow.Cells[0].Value = frmProduct.SelectProduct.Id;
                    dataGridViewRow.Cells[1].Value = frmProduct.SelectProduct.NameEn;
                    dataGridViewRow.Cells[2].Value = frmProduct.SelectProduct.NameKh;

                    dataGridViewRow.Cells[4].Value = CheckOnhand(1,1);
                    dataGridViewRow.Cells[5].Value = frmProduct.SelectProduct.CategoryId;
                    dataGridViewRow.Cells[6].Value = frmProduct.SelectProduct.MeasureId;
                    dataGridViewRow.Cells[7].Value = frmProduct.SelectProduct.Price;
                    dataGridViewRow.Cells[8].Value = frmProduct.SelectProduct.Cost;
                    if (e.RowIndex == (dataGridView1.Rows.Count - 1))
                    {
                        dataGridView1.Rows.Add(dataGridViewRow);
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error :" + exception, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
