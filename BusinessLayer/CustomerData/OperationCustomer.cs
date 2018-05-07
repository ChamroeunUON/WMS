using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttributeLayer;
using WinMessage;
using DatabaseLayer.CustomerData;
using PresentationLayer.ICustomerData;



namespace BusinessLayer.CustomerData
{
    public class OperationCustomer : CustomerAttribute, IOperationCustomer
    {

        MyMessage MESSAGE = new MyMessage();
        public void saveType(String saveType)
        {
            try
            {
                OperationCustomerModel cm = new OperationCustomerModel();
                cm.saveCusType(saveType,this);
            }
            catch (Exception E)
            {
                MyMessage.showMessage("BusinessLayer Customer " + E);
            }

        }









        public List<CustomerAttribute> getAllCustomer()
        {
            try
            {

                return null;
            }
            catch (Exception E)
            {
                MyMessage.showMessage(" " + E);
                return null;
            }

        }


      
    }
}
