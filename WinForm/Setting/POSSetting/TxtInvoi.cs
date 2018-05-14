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
using WinForm.Models;

namespace WinForm.Setting.POSSetting
{
    public partial class FormPOSSetting : Office2007Form
    {
        public FormPOSSetting()
        {
            InitializeComponent();
        }

        private void FormPOSSetting_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var appContext = new AppContext())
            {
                var settig = new Models.Support.Setting
                {
                    AdjustPre = txtAdjusment.Text,
                    InvoicePre = txtInvoice.Text,
                    PaymentPre = txtPayment.Text,
                    ReceivePre = txtReceive.Text
                };
                appContext.Settings.Add(settig);
                appContext.SaveChanges();
                MessageBox.Show("Insertd");
            }
        }
    }
}
