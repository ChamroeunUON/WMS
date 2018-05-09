using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Models
{
    class Employee
    {
        public int Id { get; set; }
        public string NameEN { get; set; }
        public string NameKH { get; set; }
        public string Sex { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Possition { get; set; }
        public string Note { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

    }
}
