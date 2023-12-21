using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
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
        public static List<Department> getListDepts()
        {
            return DataAccess.getDataDepts();
        }
        public static void UpdateEmps(int IDNV, string TENV, DateTime NGSINH, string GIOITINH, string DIACHI, string Email, string DiDong, string VanHoa, string ChuyenMon, int IDPB, decimal Luong)
        {
            DataAccess.UpdateEmp( IDNV,  TENV,  NGSINH,  GIOITINH,  DIACHI,  Email,  DiDong,  VanHoa,  ChuyenMon,  IDPB,  Luong);
        }
        public static void AddEmp(string TENV, DateTime NGSINH, string GIOITINH, string DIACHI, string Email, string DiDong, string VanHoa, string ChuyenMon, int IDPB, decimal Luong)
        {
            DataAccess.AddEmp(TENV, NGSINH, GIOITINH, DIACHI, Email, DiDong, VanHoa, ChuyenMon, IDPB, Luong);
        }
        public static void DeleteEmp(int IDNV)
        {
            DataAccess.DeleteEmp(IDNV);
        }
        public static DataTable GetHighSalary()
        {
            return DataAccess.ShowHighSalary();
        }
        public static DataTable GetLowSalary()
        {
            return DataAccess.ShowLowSalary();
        }
        public static DataTable GetExpertise(string expertise)
        {
            return DataAccess.ShowExpertise(expertise);
        }
        public static DataTable GetGender(string gender)
        {
            return DataAccess.ShowGender(gender);
        }

    }
}
