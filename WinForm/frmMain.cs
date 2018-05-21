using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WinForm.FormCustomer;
using WinForm.Administrator;
using WinForm.Administrator.Employee;
using WinForm.Administrator.frmProduct;
using WinForm.Administrator.FormCategory;
using WinForm.Administrator.FormSupplier;
using WinForm.Administrator.Warehouse;
using WinForm.Inventory.ReceivItem;
using WinForm.Models.Support;
using WinForm.POS;
using WinForm.Setting.FrmMeasure;
using WinForm.Setting.POSSetting;


namespace WinForm
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var frm = new FormLogin();
            frm.ShowDialog();
        }

        private void Customer_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            var frm = new FrmUser {MdiParent = this};
            frm.Show();
        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click_1(object sender, EventArgs e)
        {
            var frm = new frmCustomer {MdiParent = this};
            frm.Show();
            
        }

        private void ribbonBar4_ItemClick(object sender, EventArgs e)
        {

        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {

        }

        private void btnReceivePayment_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            var frm = new frmSupplier { MdiParent = this };
            frm.Show();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            var frm = new FrmCategory { MdiParent = this};
            frm.Show();
            
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            var frm = new frmMeasure {MdiParent = this};
            frm.Show();
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            var frm = new frmEmployee {MdiParent = this};
            frm.Show();
        }

        private void Products_Click(object sender, EventArgs e)
        {
            var frm = new frmProduct {MdiParent = this};
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FormLogin();
            frm.ShowDialog();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" " + CurrentUser.GetCurrentUser+ "  "+ CurrentUser.GetCurrentUserId);
        }

        private void Warehouse_Click(object sender, EventArgs e)
        {
            var frm = new FormWarehouse {MdiParent = this};
            frm.Show();
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            var frm = new FormReceiveItem {MdiParent = this};
            frm.Show();
        }

        private void buttonItem23_Click(object sender, EventArgs e)
        {

        }

        private void btnPosSetting_Click(object sender, EventArgs e)
        {
            var frm = new te {MdiParent = this};
            frm.Show();

        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {

        }

        private void btnSaleOrder_Click(object sender, EventArgs e)
        {
            var frm = new FormSaleOrder { MdiParent = this};
            frm.Show();
        }
    }
}
