using System;
using System.Collections.Generic;
using WinForm.Models.Support;

namespace WinForm.Models
{
    internal class Transaction
    {
        public int Id { get; set; } 
        public string TransactionId { get; set; }

        public TransactionType TransactionType { get; set; }
        public DateTime DateTime { get; set; }

        public int UserId { set; get; }

        public User User { get; set; }

        public int SupplierId { get; set; }

        public IEnumerable<TransactionItem> TransactionItems { get; set; }

        public float TotalAmount { get; set; }
        public string SynNote { get; set; }
        public string Note { get; set; }
    }
}
