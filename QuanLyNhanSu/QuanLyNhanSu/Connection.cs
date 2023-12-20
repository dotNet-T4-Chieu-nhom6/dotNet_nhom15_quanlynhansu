using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public class Connection
    {
        public static SqlConnection GetSqlConnection()
        {
            string conStr = "Data Source=DESKTOP-US92MIO\\QUANGLOPXE;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            //string conStr = @"Data Source=DESKTOP-G925OAP;Initial Catalog=QuanLyNhanSu;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(conStr);
            return conn;
        }
    }
}
