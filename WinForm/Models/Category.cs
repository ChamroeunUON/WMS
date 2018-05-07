using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Models
{
    class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
