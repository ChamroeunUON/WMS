using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string UserNmae { get; set; }
        public string Password { get; set; }
        public string Note { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
    }
}
