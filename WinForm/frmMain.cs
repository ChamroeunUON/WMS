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
using WinMessage;

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
            frmCustomer frm = new frmCustomer();
            if (CheckFrmExist.frmExist(frm)) return;
            frm.MdiParent = this;
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
    }
}
