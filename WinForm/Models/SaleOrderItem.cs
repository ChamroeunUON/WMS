using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Models
{
    public class SaleOrderItem
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("SaleOrder")]
        public string SaleOrderId { get; set; }
        public SaleOrder SaleOrder { get; set; }

        public IEnumerable<Product> Products { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        public int Qty { get; set; }
        public float Price { get; set; }
        public float DisPercent { get; set; }
        public float VatPercent { get; set; }
        public float Amount { get; set; }
        public string Note { get; set; }

    }
}
