using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain mn = new frmMain();
            mn.ShowDialog();
            mn = null;
            this.Show();
        }

        private void lb_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmQuenMatKhau mn = new frmQuenMatKhau();
            mn.ShowDialog();
            mn = null;
            this.Show();
        }

        private void lb_DangKi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            frmDangKy mn = new frmDangKy();
            mn.ShowDialog();
            mn = null;
            this.Close();
        }
    }
}
