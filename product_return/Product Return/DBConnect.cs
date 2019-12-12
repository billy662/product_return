using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Product_Return
{
    public static class DBConnect
    {
        public static string serverIP = "61.92.84.106";
        public static MySqlConnection getConnection()
        {
            //string server = "db4free.net";
            //string port = "3306";
            //string database = "billydb";
            //string uid = "billy662";
            //string password = "billychungbc1210";
            string port = "3306";
            string database = "product_return_DB";
            string uid = "root";
            string password = "BillyChungCN0201#*#*";
            string connectionString;
            connectionString = "Server=" + serverIP + ";Port=" + port + ";Database=" + database + ";Uid=" + uid + ";Pwd=" + password + ";SslMode=none";
            return new MySqlConnection(connectionString);
        }
    }
}
