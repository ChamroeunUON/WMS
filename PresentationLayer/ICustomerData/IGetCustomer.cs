using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttributeLayer;
using System.Data;

namespace PresentationLayer.ICustomerData
{
    public interface IGetCustomer
    {
        DataTable getAllCustomer { get; }
        CustomerAttribute getCustomerById(String id);
    }
}
