using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Models.Support
{
    class Setting
    {
        public int Id { get; set; }
        public string InvoicePre { get; set; }
        public string AdjustPre { get; set; }
        public string PaymentPre { get; set; }
        public string ReceivePre { get; set; }
    }
}
