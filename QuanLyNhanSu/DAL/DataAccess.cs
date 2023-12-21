using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;
namespace DAL
{
    public class ConnectionData
    {
        public static SqlConnection Connect()
        {
            string conStr = "Data Source=DESKTOP-US92MIO\\QUANGLOPXE;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            //string conStr = "Data Source=DESKTOP-G925OAP;Initial Catalog=QuanLyNhanSu;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            //string conStr = @"Data Source=LAPTOP-RHGDOGMA\DUC;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conStr);
            return conn;
        }
    }
    public class DataAccess
    {
        public static DataTable getDataEmps()
        {
            SqlConnection conn = ConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("ShowAllEmps",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static List<Department> getDataDepts()
        {
            List<Department> listPB = new List<Department>();

            SqlConnection conn = ConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("ShowAllDepartment", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                int IDPB = rdr.GetInt32(0);
                string tenPB = rdr.GetString(1);
                Department dept = new Department(IDPB, tenPB);
                listPB.Add(dept);
            }
            rdr.Close();

            return listPB;
        }
        public static void UpdateEmp(int IDNV, string TENV, DateTime NGSINH, string GIOITINH, string DIACHI, string Email, string DiDong, string VanHoa, string ChuyenMon, int IDPB, decimal Luong)
        {
            SqlConnection conn = ConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("EditEmps", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDNV",IDNV);
            cmd.Parameters.AddWithValue("@TENNV",TENV);
            cmd.Parameters.AddWithValue("@NGSINH",NGSINH);
            cmd.Parameters.AddWithValue("@GIOITINH",GIOITINH);
            cmd.Parameters.AddWithValue("@DIACHI",DIACHI);
            cmd.Parameters.AddWithValue("@EMAIL",Email);
            cmd.Parameters.AddWithValue("@DIDONG",DiDong);
            cmd.Parameters.AddWithValue("@VANHOA",VanHoa);
            cmd.Parameters.AddWithValue("@CHUYENMON",ChuyenMon);
            cmd.Parameters.AddWithValue("@IDPB",IDPB);
            cmd.Parameters.AddWithValue("@LUONG",Luong);
            cmd.ExecuteNonQuery();
        }
        public static void AddEmp(string TENV, DateTime NGSINH, string GIOITINH, string DIACHI, string Email, string DiDong, string VanHoa, string ChuyenMon, int IDPB, decimal Luong)
        {
            SqlConnection conn = ConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("AddEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;            
            cmd.Parameters.AddWithValue("@TENNV", TENV);
            cmd.Parameters.AddWithValue("@NGSINH", NGSINH);
            cmd.Parameters.AddWithValue("@GIOITINH", GIOITINH);
            cmd.Parameters.AddWithValue("@DIACHI", DIACHI);
            cmd.Parameters.AddWithValue("@EMAIL", Email);
            cmd.Parameters.AddWithValue("@DIDONG", DiDong);
            cmd.Parameters.AddWithValue("@VANHOA", VanHoa);
            cmd.Parameters.AddWithValue("@CHUYENMON", ChuyenMon);
            cmd.Parameters.AddWithValue("@IDPB", IDPB);
            cmd.Parameters.AddWithValue("@LUONG", Luong);
            cmd.ExecuteNonQuery();
        }
        public static void DeleteEmp(int IDNV)
        {
            SqlConnection conn = ConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("DeleteEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDNV", IDNV);
            cmd.ExecuteNonQuery();
        }

        public static DataTable ShowHighSalary()
        {
            SqlConnection conn = ConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("ShowHighSalary", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable ShowLowSalary()
        {
            SqlConnection conn = ConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("ShowLowSalary", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable ShowExpertise(string Expertise)
        {
            SqlConnection conn = ConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Show_Expertise", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Expertise", Expertise);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable ShowGender(string Gender)
        {
            SqlConnection conn = ConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("ShowGender", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Gender", Gender);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
