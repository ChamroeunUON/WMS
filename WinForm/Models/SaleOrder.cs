using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Models
{
    public class SaleOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string SaleOrderId { get; set; }
        public SaleType SaleType { get; set; }
        public DateTime SaleDate { get; set; }
        public int CusId { get; set; }
        public Customer Customer { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public float DisAmount { get; set; }
        public float DisPercent { get; set; }
        public float SubTotal { get; set; }
        public float GrandTotal { get; set; }
        public float Deposit { get; set; }
        public float Balance { get; set; }
        public float Paid { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }


    }
}
