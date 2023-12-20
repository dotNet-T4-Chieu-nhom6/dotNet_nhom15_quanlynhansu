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
            string conStr = "Data Source=.;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conStr);
            return conn;
        }
    }
}
