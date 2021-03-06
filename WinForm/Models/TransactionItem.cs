﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Models
{
    public class TransactionItem
    {
        //        public int Id { get; set; }
        public int Id { get; set; }
        [ForeignKey("Transaction")]
        public string TransactionId { get; set; }
        public Transaction Transaction { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        
        public int Qty { get; set; }
        public float Price { get; set; }
        public float Cost { get; set; }
    }
}
