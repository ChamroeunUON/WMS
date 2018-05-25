using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Reports;
namespace WinForm.Reports
{
    public partial class frmReceiveReport : Form
    {
        public frmReceiveReport(crptReceiveItem rpt)
        {
            InitializeComponent();

            crystalReportViewer1.ReportSource = rpt;


        }

        private void frmReceiveReport_Load(object sender, EventArgs e)
        {

        }
    }
}
