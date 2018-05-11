using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string NameEn { get; set; }
        [StringLength(255)]
        public string NameKh { get; set; }

        public float Cost { get; set; }
        public float Price { get; set; }

        
        public byte Status { get; set; }
  
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int MeasureId { get; set; }
        public Measure Measure { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        public string Note { get; set; }
    }
}
