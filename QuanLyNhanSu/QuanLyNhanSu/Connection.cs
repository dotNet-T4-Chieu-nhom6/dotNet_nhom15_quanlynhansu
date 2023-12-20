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
<<<<<<< HEAD
            //string conStr = "Data Source=.;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            //string conStr = @"Data Source=DESKTOP-G925OAP;Initial Catalog=QuanLyNhanSu;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string conStr = @"Data Source=LAPTOP-RHGDOGMA\DUC;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
=======
            string conStr = "Data Source=DESKTOP-US92MIO\\QUANGLOPXE;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            //string conStr = @"Data Source=DESKTOP-G925OAP;Initial Catalog=QuanLyNhanSu;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
>>>>>>> a9dd1dcf6928a716e012791583d02aeeb938c6f2
            SqlConnection conn = new SqlConnection(conStr);
            return conn;
        }
    }
}
