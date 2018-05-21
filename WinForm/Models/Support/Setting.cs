using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Models.Support
{
    public class Setting
    {
        public int Id { get; set; }
        public string AdjustPre { get; set; }
        public string ReceivePre { get; set; }
        public string Issue { get; set; }
        public string SaleOrderPre { get; set; }
        public string QuotePre { get; set; }
        public string InvoicePre { get; set; }
        public string PaymentPre { get; set; }

    }
}
