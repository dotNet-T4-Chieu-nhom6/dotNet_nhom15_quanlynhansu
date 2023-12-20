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
        private int admin;

        public frmMain()
        {
            InitializeComponent();        
            
        }

        public frmMain(int id)
        {
            InitializeComponent();
            this.admin = id;
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
            dgv_NhanVien.DataSource = Bus_Layer.GetAllEmps();
            if(admin == 0)
            {
                menuStrip1.Enabled = false;
                toolStrip1.Enabled = false;
            }
            else
            {
                menuStrip1.Enabled = true;
                toolStrip1.Enabled = true;
            }    
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditEmployee f = new frmEditEmployee();
            f.Show();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddEmployee f = new frmAddEmployee();
            f.Show();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeleteEmp f = new frmDeleteEmp();
            f.Show();
        }
    }
}
