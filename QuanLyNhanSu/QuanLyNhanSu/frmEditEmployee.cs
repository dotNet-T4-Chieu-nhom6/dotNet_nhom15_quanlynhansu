using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace QuanLyNhanSu
{
    public partial class frmEditEmployee : Form
    {
        Employee emp = new Employee();

        public frmEditEmployee()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            int IDNV = int.Parse(txt_EmpID.Text);
            string tenNV = txt_Name.Text;
            DateTime NGSINH = dateTimePicker1.Value;
            string gioiTinh = txt_Gender.Text;
            string diaChi = txt_Address.Text;
            string email = txt_Email.Text;
            string DiDong = txt_PhoneNumber.Text;
            string VanHoa = txt_Education.Text;
            string ChuyenMon = txt_Expertise.Text;
            int IDPB = int.Parse(txt_Department.Text);
            int Luong = int.Parse(txt_Salary.Text);

            Bus_Layer.UpdateEmps(IDNV, tenNV, NGSINH, gioiTinh, diaChi, email, DiDong, VanHoa, ChuyenMon, IDPB, Luong);
        }

        private void dtgv_Emp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dtgv_Emp.Rows[e.RowIndex];
                txt_EmpID.Text = row.Cells[0].Value.ToString();
                txt_Name.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                txt_Gender.Text = row.Cells[3].Value.ToString();
                txt_Address.Text = row.Cells[4].Value.ToString();
                txt_Email.Text = row.Cells[5].Value.ToString();
                txt_PhoneNumber.Text = row.Cells[6].Value.ToString();
                txt_Education.Text = row.Cells[7].Value.ToString();
                txt_Expertise.Text = row.Cells[8].Value.ToString();
                txt_Department.Text = row.Cells[9].Value.ToString();
                txt_Salary.Text = row.Cells[10].Value.ToString();
            }
            catch
            {
                txt_EmpID.Clear();
                txt_Name.Clear();
                dateTimePicker1.Text = DateTime.Now.Date.ToString();
                txt_Gender.Clear();
                txt_Address.Clear();
                txt_Email.Clear();
                txt_PhoneNumber.Clear();
                txt_Education.Clear();
                txt_Expertise.Clear();
                txt_Department.Clear();
                txt_Salary.Clear();

            }
        }

        private void frmEditEmployee_Load(object sender, EventArgs e)
        {
            dtgv_Emp.DataSource = Bus_Layer.GetAllEmps();
        }
    }
}
