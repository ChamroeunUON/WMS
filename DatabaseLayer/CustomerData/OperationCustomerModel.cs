using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AttributeLayer;
using WinMessage;

namespace DatabaseLayer.CustomerData
{
    public class OperationCustomerModel
    {
      
        public bool saveCusType(String saveType,CustomerAttribute customer)
        {
            try
            {
            SqlCommand sc = new SqlCommand(saveType, Connection.getConnection());
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("@id", customer.ID);
            sc.Parameters.AddWithValue("@name", customer.Name);
            sc.Parameters.AddWithValue("@sex", customer.Sex);
            sc.Parameters.AddWithValue("@phone", customer.Phone);
            sc.Parameters.AddWithValue("@email", customer.Email);
            sc.Parameters.AddWithValue("@note", customer.Note);
            sc.Parameters.AddWithValue("@address", customer.Address);
                sc.ExecuteNonQuery();
                Connection.Close();
                MyMessage.showMessage("Success...");
                return true;
            }
            catch (Exception E)
            {
                MyMessage.showMessage("DatabaseLayer CustomerModel on Insert Method : " + E);
                return false;
            }
        }
     
       
    }
}
