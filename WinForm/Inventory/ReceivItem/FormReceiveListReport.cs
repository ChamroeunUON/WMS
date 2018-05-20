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


namespace WinForm.Inventory.ReceivItem
{
    public partial class FormReceiveListReport : Form
    {
        public FormReceiveListReport(rptReceiveItem rptReceive)
        {
            InitializeComponent();
            crystalReport1.ReportSource = rptReceive;
            crystalReport1.RefreshReport();
        }

        private void FormReceiveListReport_Load(object sender, EventArgs e)
        {
//            var receiveList = new receiveList();
//            crystalReport1.ReportSource = null;
//            crystalReport1.ReportSource = receiveList;
        }

        private void crvReportreceive_Load(object sender, EventArgs e)
        {
            var productDataTable = new DataTable();
            productDataTable.Columns.Add("Id", typeof(int));
            productDataTable.Columns.Add("Name", typeof(string));
            productDataTable.Columns.Add("Price", typeof(decimal));
            productDataTable.Columns.Add("Count", typeof(long));



            productDataTable.Rows.Add(1,"Pen", 20, 250);
            productDataTable.Rows.Add(2,"PenCil", 20, 250);
            productDataTable.Rows.Add(3,"Ruuler", 20, 250);
            productDataTable.Rows.Add(4,"Unbrela", 20, 250);

//            var receiveList= new receiveList();
       


        }
    }
}
