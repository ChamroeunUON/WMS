using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.ICustomerData;
using DatabaseLayer.CustomerData;
using AttributeLayer;
using System.Data;
using System.Data.SqlClient;
using AttributeLayer;

namespace BusinessLayer.CustomerData
{
    public class GetCustomer : IGetCustomer
    {
        DataTable dt;
        GetCustomerModel gcm;
        public  DataTable getAllCustomer
        {
            get
            {
                dt = new DataTable();
                 gcm = new GetCustomerModel();
                dt = gcm.getAll();
                return dt;
            }
        }





        public CustomerAttribute getCustomerById(string id)
        {
            CustomerAttribute customerAtt = GetCustomerModel.getCustomerById(id);
            return customerAtt;
        }
    }
}
