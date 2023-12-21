using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QuanLyNhanSu
{
    public partial class frmAddEmployee : Form
    {                
        public frmAddEmployee()
        {
            InitializeComponent();
            load_cbo_Gender();
            load_cbo_Department();
        }

        private void load_cbo_Gender()
        {
            cbo_Gender.Items.Add("");
            cbo_Gender.Items.Add("Nam");
            cbo_Gender.Items.Add("Nữ");
            cbo_Gender.Items.Add("Khác");
        }

        private void load_cbo_Department()
        {
            
            List<Department> listPB = Bus_Layer.getListDepts();
            cbo_Department.DataSource = listPB;
            cbo_Department.ValueMember = "idphongban";
            cbo_Department.DisplayMember = "tenphongban";            
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9][a-zA-Z0-9._-]*@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        private void txt_Email_Validated(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            string email = txt_Email.Text;
            if (IsValidEmail(email) == false)
            {
                this.errorProvider1.SetError(ctrl, "Email không đúng định dạng!");
                txt_Email.Focus();
            }
            else
                this.errorProvider1.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string tenNV = txt_Name.Text;
            DateTime NGSINH = dateTimePicker1.Value;
            string gioiTinh = cbo_Gender.Text;
            string diaChi = txt_Address.Text;
            string email = txt_Email.Text;
            string DiDong = txt_PhoneNumber.Text;
            string VanHoa = txt_Education.Text;
            string ChuyenMon = txt_Expertise.Text;
            int IDPB = (int)cbo_Department.SelectedValue;
            decimal Luong = decimal.Parse(txt_Salary.Text);
            if (string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(gioiTinh) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(DiDong) || string.IsNullOrEmpty(VanHoa) || string.IsNullOrEmpty(ChuyenMon))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");         
            try
            {
                Bus_Layer.AddEmp(tenNV, NGSINH, gioiTinh, diaChi, email, DiDong, VanHoa, ChuyenMon, IDPB, Luong);
                MessageBox.Show("Thêm nhân viên thành công!");
                dtgv_Emp.DataSource = Bus_Layer.GetAllEmps();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            dtgv_Emp.DataSource = Bus_Layer.GetAllEmps();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        

        private void dtgv_Emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dtgv_Emp.Rows[e.RowIndex];                
                txt_Name.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                cbo_Gender.SelectedItem = row.Cells[3].Value.ToString();
                txt_Address.Text = row.Cells[4].Value.ToString();
                txt_Email.Text = row.Cells[5].Value.ToString();
                txt_PhoneNumber.Text = row.Cells[6].Value.ToString();
                txt_Education.Text = row.Cells[7].Value.ToString();
                txt_Expertise.Text = row.Cells[8].Value.ToString();
                cbo_Department.SelectedItem = row.Cells[9].Value.ToString();
                txt_Salary.Text = row.Cells[10].Value.ToString();
            }
            catch
            {                
                txt_Name.Clear();
                dateTimePicker1.Text = DateTime.Now.Date.ToString();
                cbo_Gender.Text = "";
                txt_Address.Clear();
                txt_Email.Clear();
                txt_PhoneNumber.Clear();
                txt_Education.Clear();
                txt_Expertise.Clear();
                cbo_Department.Text = "";                
                txt_Salary.Clear();

            }            
        }

        private void frmAddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {            
            this.Close();
        }

        

        private void txt_Name_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                this.errorProvider1.SetError(ctrl, "Giá trị không được để trống!");
            }
            else
                this.errorProvider1.Clear();
        }

        private void txt_Address_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (string.IsNullOrEmpty(txt_Address.Text))
            {
                this.errorProvider1.SetError(ctrl, "Giá trị không được để trống!");
            }
            else
                this.errorProvider1.Clear();
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (string.IsNullOrEmpty(txt_Email.Text))
            {
                this.errorProvider1.SetError(ctrl, "Giá trị không được để trống!");
            }
            else
                this.errorProvider1.Clear();
        }

        private void txt_Salary_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (string.IsNullOrEmpty(txt_Salary.Text))
            {
                this.errorProvider1.SetError(ctrl, "Giá trị không được để trống!");
            }
            else
                this.errorProvider1.Clear();
        }

        

        

        private void txt_PhoneNumber_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (string.IsNullOrEmpty(txt_PhoneNumber.Text))
            {
                this.errorProvider1.SetError(ctrl, "Giá trị không được để trống!");
            }
            else
                this.errorProvider1.Clear();
        }

        private void txt_Education_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (string.IsNullOrEmpty(txt_Education.Text))
            {
                this.errorProvider1.SetError(ctrl, "Giá trị không được để trống!");
            }
            else
                this.errorProvider1.Clear();
        }

        private void txt_Expertise_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (string.IsNullOrEmpty(txt_Expertise.Text))
            {
                this.errorProvider1.SetError(ctrl, "Giá trị không được để trống!");
            }
            else
                this.errorProvider1.Clear();
        }

        
    }
}
