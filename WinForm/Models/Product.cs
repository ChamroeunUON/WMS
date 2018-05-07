using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Models
{
    class Product
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string NameEn { get; set; }
        [StringLength(255)]
        public string NameKh { get; set; }

        public DateTime? DateEnter { get; set; }
        public DateTime? DateExpire { get; set; }
               
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public byte? Image { get; set; }
    }
}
