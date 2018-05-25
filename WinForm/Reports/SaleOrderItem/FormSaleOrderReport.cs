using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Reports.SaleOrderItem;

namespace WinForm.Reports.ReceiveItems
{
    public partial class FormSaleOrderReport : Form
    {
        public FormSaleOrderReport(crptSaleOrder rpt)
        {
            InitializeComponent();
            crystalReportSaleOrder.ReportSource = rpt;
        }

        private void FormSaleOrderReport_Load(object sender, EventArgs e)
        {

        }
    }
}
