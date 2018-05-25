using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WinForm.Models.Support;

namespace WinForm.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string TransactionId { get; set; }

        public TransactionType TransactionType { get; set; }
        public DateTime DateTime { get; set; }

        public int UserId { set; get; }

        public User User { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public IEnumerable<TransactionItem> TransactionItems { get; set; }

        public float TotalAmount { get; set; }
        public string SynNote { get; set; }
        public string Note { get; set; }
    }
}
