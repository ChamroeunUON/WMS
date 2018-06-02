using System;
using System.Data.Entity.Migrations;
using System.Linq;
using DevComponents.DotNetBar;
using WinForm.Models;

namespace WinForm.Setting.POSSetting
{
    public partial class FormSetting : Office2007Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormPOSSetting_Load(object sender, EventArgs e)
        {
            using (var context = new AppContext())
            {
                var setting = context.Settings.ToList();
                foreach (var setting1 in setting)
                {
                    txtReceive.Text = setting1.ReceivePre;
                    txtAdjusment.Text = setting1.AdjustPre;
                    txtIssue.Text = setting1.Issue;
                    txtSaleOrderpre.Text = setting1.SaleOrderPre;
                    txtQuotePre.Text = setting1.QuotePre;
                    txtInvoice.Text = setting1.InvoicePre;
                    txtPayment.Text = setting1.PaymentPre;
                }
            }
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            using (var appContext = new AppContext())
            {
                var setting = appContext.Settings.ToList();
                foreach (var setting1 in setting)
                {
                    if (setting1 == null)
                    {
                        var s = new Models.Support.Setting
                        {
                            AdjustPre = txtAdjusment.Text,
                            InvoicePre = txtInvoice.Text,
                            PaymentPre = txtPayment.Text,
                            ReceivePre = txtReceive.Text,
                            Issue = txtIssue.Text,
                            QuotePre = txtQuotePre.Text,
                            SaleOrderPre = txtSaleOrderpre.Text
                        };
                        appContext.Settings.Add(s);
                        MyMessage.Success(@"Inserted");
                    }
                    else
                    {
                        setting1.InvoicePre = txtInvoice.Text;
                        setting1.AdjustPre = txtAdjusment.Text;
                        setting1.Issue = txtIssue.Text;
                        setting1.PaymentPre = txtPayment.Text;
                        setting1.ReceivePre = txtReceive.Text;
                        setting1.QuotePre = txtQuotePre.Text;
                        setting1.SaleOrderPre = txtSaleOrderpre.Text;
                        appContext.Settings.Add(setting1);
                        MyMessage.Success(@"Uodated");
                    }
                    appContext.SaveChanges();
                }
            }
        }
    }
}
