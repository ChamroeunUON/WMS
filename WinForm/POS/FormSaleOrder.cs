using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WinForm.Inventory.ProductMaster;
using WinForm.Models;
using WinForm.Models.Support;

namespace WinForm.POS
{
    public partial class FormSaleOrder : Office2007Form
    {
        private int _idMax;
        private readonly AppContext _appContext;

        public FormSaleOrder()
        {
            _appContext = new AppContext();
            InitializeComponent();
        }


        private void FormSaleOrder_Load(object sender, EventArgs e)
        {
            txtUser.Text = CurrentUser.GetCurrentUserId.ToString();
            txtUserName.Text = CurrentUser.GetCurrentUser;
            var settings = _appContext.Settings.First();
            var saleCount = _appContext.SaleOrders.ToList();
            _idMax = saleCount.Equals(null) ? 0 : saleCount.Count;
            txtSaleOrderID.Text = settings.SaleOrderPre + DateTime.Today.Year + DateTime.Today.Month.ToString("D2") +
                                  DateTime.Today.Day.ToString("D2") + _idMax.ToString("D3");
            
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var frm = new FormListProductWarehouse {WarehouseId = int.Parse(txtWarehouseId.Text)};
            frm.ShowDialog();

           
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            var frm = new FormListCustomer();
            frm.ShowDialog();
            txtCustomerID.Text = frm.CustomerId.ToString();
            txtCustomerName.Text = frm.CustomerName;
            
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            var frm = new FormListWarehouse();
            frm.ShowDialog();
            txtWarehouseId.Text = frm.WarehouseId.ToString();
            txtWarehouseName.Text = frm.WarehouseName;
        }
    }
}
