using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using WinForm.Inventory.ProductMaster;
using WinForm.Models;

namespace WinForm.POS
{
    public partial class FormListProductWarehouse : Form
    {
        private readonly AppContext _appContext;

        public FormListProductWarehouse()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
        }

        public int WarehouseId { get; set; }
        private void FormListProductWarehouse_Load(object sender, EventArgs e)
        {
            var wId = WarehouseId;
            var pro = _appContext.ProducWarehouses
                .Where(id => id.WarehouseId == wId)
                .Include(id => id.Product)
                .Include(ca => ca.Product.Category)
                .Include(me => me.Product.Measure)
                .ToList();

            foreach (var producWarehouse in pro)
                dataGridView1.Rows.Add(producWarehouse.ProductId.ToString(),
                    producWarehouse.Product.NameEn,
                    producWarehouse.Product.NameKh,
                    producWarehouse.Product.Category.Name,
                    producWarehouse.Product.Measure.Name,
                    producWarehouse.Product.Price,
                    producWarehouse.Product.Cost);
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
           
        }
    }
}
