using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectionData
    {
        public static SqlConnection Connect()
        {
            string conStr = "Data Source=DESKTOP-US92MIO\QUANGLOPXE;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conStr);
            return conn;
        }
    }
    public class DataAccess
    {
        
    }
}
