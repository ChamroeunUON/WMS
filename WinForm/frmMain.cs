using System;
using DevComponents.DotNetBar;
using WinForm.Administrator;
using WinForm.Administrator.Employee;
using WinForm.Administrator.frmProduct;
using WinForm.Administrator.FormCategory;
using WinForm.Administrator.FormSupplier;
using WinForm.Administrator.Warehouse;
using WinForm.Inventory.ReceivItem;
using WinForm.POS;
using WinForm.Setting.FrmMeasure;
using WinForm.Setting.POSSetting;
//using WinForm.FormCustomer;


namespace WinForm
{
    public partial class frmMain : Office2007Form
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
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void btnReceivePayment_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            var frm = new frmSupplier {MdiParent = this};
            frm.Show();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            var frm = new FrmCategory {MdiParent = this};
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
            MyMessage.Error("This Feature Not Availble");
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
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void btnPosSetting_Click(object sender, EventArgs e)
        {
            var frm = new FormSetting {MdiParent = this};
            frm.Show();
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
        }

        private void btnSaleOrder_Click(object sender, EventArgs e)
        {
            var frm = new FormSaleOrder {MdiParent = this};
            frm.Show();
        }

        private void ribbonTabItem3_Click(object sender, EventArgs e)
        {
        }

        private void ribbonPanel4_Click(object sender, EventArgs e)
        {
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem13_Click_1(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem27_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem28_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem29_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem24_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem25_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem26_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            MyMessage.Error("This Feature Not Availble yet");
        }

        private void ribbonTabItem1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar3_ItemClick(object sender, EventArgs e)
        {

        }
    }
}
