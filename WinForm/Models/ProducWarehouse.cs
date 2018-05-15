using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Models
{
    public class ProducWarehouse
    {
        [Key]
        [Column(Order = 0)]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Key]
        [Column(Order = 1)]
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        public int?  SupplierId { get; set; }
//        public int Qty { get; set; }
        public int OnHand { get; set; }
        public int AlertQty { get; set; }
        public string Note { get; set; }
        public int SaleOrderQty { get; set; }
    }
}
