using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseLayer
{
    public class Connection
    {
        private static SqlConnection connection = null;
        public static String conStr = @"Data Source=.;" +
                                    "Initial Catalog=ShopManagementCSharp;" +
                                     "User id=sa;" +
                                     "Password=123456;";
        public static SqlConnection getConnection()
        {
            if (connection == null)
            {
                try
                {
                    connection = new SqlConnection(conStr);
                    connection.Open();
                }
                catch (Exception E)
                {
                    E.ToString();
                }
                return connection;
            }
            else
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception E)
                    {
                        E.ToString();
                    }
                   
                }
                return connection;
            }
        }
        public static void Close()
        {
            connection.Close();
          
        }
    }
}
