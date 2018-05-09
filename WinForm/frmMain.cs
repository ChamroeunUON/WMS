﻿using System;
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
using WinForm.Setting.FrmMeasure;


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

        }

        private void Customer_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
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
    }
}
