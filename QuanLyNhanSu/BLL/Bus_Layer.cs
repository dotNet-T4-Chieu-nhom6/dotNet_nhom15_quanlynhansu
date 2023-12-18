using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Bus_Layer
    {
        public static DataTable GetAllEmps()
        {
            return DataAccess.getDataEmps();
        }
        public static void UpdateEmps(int IDNV, string TENV, DateTime NGSINH, string GIOITINH, string DIACHI, string Email, string DiDong, string VanHoa, string ChuyenMon, int IDPB, int Luong)
        {
            DataAccess.UpdateEmp( IDNV,  TENV,  NGSINH,  GIOITINH,  DIACHI,  Email,  DiDong,  VanHoa,  ChuyenMon,  IDPB,  Luong);
        }
    }
}
