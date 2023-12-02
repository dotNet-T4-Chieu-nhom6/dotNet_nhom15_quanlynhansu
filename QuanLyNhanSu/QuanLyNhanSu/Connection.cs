using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    internal class Connection
    {
        public static string ConString = "Data Source=DESKTOP-G925OAP;Initial Catalog=QuanLyNhanSu;Integrated Security=True;TrustServerCertificate=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConString);
        }
    }
}
