using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AttributeLayer
{
   public class CustomerAttribute
    {
        public string ID { set; get; }
        public string Name { set; get; }
        public string Sex { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Note { set; get; }
        public string Address { set; get; }
        public CustomerAttribute() { }
     
      
       
    }
}
