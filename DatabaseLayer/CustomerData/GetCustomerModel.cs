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
    public class GetCustomerModel
    {
        public CustomerAttribute cus;
        public DataTable getAll()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.showAllCustomer", Connection.getConnection());
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt ;
            }
            catch (Exception E)
            {
                MyMessage.showMessage("DatabaesLayer getCustomer " + E);
                return null;

            }
            
        }

        public static CustomerAttribute getCustomerById(String id)
        {
            try
            {
                String sqlFun = "SELECT * FROM getCusById('" + id + "')";
                SqlDataAdapter da =new SqlDataAdapter(sqlFun,Connection.getConnection());
                DataTable dt = new DataTable();
                da.Fill(dt);
                CustomerAttribute customerAtt = new CustomerAttribute();
                if (dt.Rows.Count >= 1)
                {
                    DataRow row = dt.Rows[0];
                    customerAtt.ID = row[0].ToString();
                    customerAtt.Name = row[1].ToString();
                    customerAtt.Sex = row[2].ToString();
                    customerAtt.Phone = row[3].ToString();
                    customerAtt.Email = row[4].ToString();
                    customerAtt.Note = row[5].ToString();
                    customerAtt.Address = row[6].ToString();
                }
                return customerAtt;
            }catch(Exception E)
            {
                MyMessage.showMessage("GetCustomerModel GetCustomer By Id : " + E);
                return null;
            }
        }



     



    }
}
