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
    public partial class frmMain : Form
    {
        private int Quyen;

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(int id)
        {
            InitializeComponent();
            this.Quyen = id;
        }



        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDepartment frmD = new frmDepartment();
            DialogResult result = frmD.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Code xử lý sau khi frmDepartment được đóng
                this.Show(); // Hiển thị lại frmMain 
            }
            else
            {
                // Code xử lý khi frm2 được đóng với Cancel hoặc một giá trị khác
                this.Show(); // Hiển thị lại frmMain
            }
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsers frmU = new frmUsers();
            DialogResult result = frmU.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else { this.Show(); }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgv_NhanVien.DataSource = null;
            dgv_NhanVien.DataSource = Bus_Layer.GetAllEmps();
            if(Quyen == 2)
            {
                quảnLýToolStripMenuItem.Enabled = false;
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                trợGiúpToolStripMenuItem.Enabled = false;
                toolStrip1.Enabled = false;
            }
            else if (Quyen == 1)
            {
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
            }    
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditEmployee frmEE = new frmEditEmployee();
            DialogResult result = frmEE.ShowDialog();

            if (result == DialogResult.OK)
            { this.Show(); }
            else { this.Show(); }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddEmployee frmAE = new frmAddEmployee();
            DialogResult result = frmAE.ShowDialog();

            if (result == DialogResult.OK)
            { this.Show(); }
            else { this.Show(); }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeleteEmp frmDE = new frmDeleteEmp();
            DialogResult result = frmDE.ShowDialog();

            if (result == DialogResult.OK)
            { this.Show(); }
            else { this.Show(); }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap mn = new frmDangNhap();
            mn.ShowDialog();
            mn = null;
            this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string maNV = txt_MaNhanVien.Text;
            string hoTenNV = txt_HoTen.Text;
            if (maNV.Trim() == "" && hoTenNV.Trim() == "")
            {
                frmMain_Load(sender, e);
            }
            else if (hoTenNV.Trim() == "")
            {
                TimKiemByID(Convert.ToInt32(maNV));
                txt_MaNhanVien.Text = "";
                txt_HoTen.Text = "";
            }
            else
            {
                TimKiemByName(hoTenNV);
                txt_MaNhanVien.Text = "";
                txt_HoTen.Text = "";
            }
        }

        public void TimKiemByID(int manv)
        {
            string query = "Select * from NhanVien Where idnv =" + manv + "";
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_NhanVien.DataSource = null;
                dgv_NhanVien.DataSource = dt;
            }
        }

        public void TimKiemByName(string name)
        {
            string query = "Select * from NhanVien Where tennv = N'" + name + "'";
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_NhanVien.DataSource = null;
                dgv_NhanVien.DataSource = dt;
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
        }

        private void txt_MaNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tsmn_Salary_High_Click(object sender, EventArgs e)
        {

        }

        
    }
}
