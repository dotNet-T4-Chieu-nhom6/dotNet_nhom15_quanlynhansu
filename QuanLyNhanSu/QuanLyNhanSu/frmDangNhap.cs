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

        Modify modify = new Modify();

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string tentk = txt_User.Text;
            string matkhau = txt_Pass.Text;
            int id;
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui long nhap ten tai khoan!");
                return;
            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui long nhap mat khau vao!");
                return;
            }
            else
            {
                string query = "Select * from Users where nameU='" + tentk + "' and passU='" + matkhau + "'";
                if (modify.Userss(query).Count != 0)
                {
                    MessageBox.Show("Đăng Nhập Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string Quyen = modify.Userss(query)[0].admin;
                    if(String.Compare(Quyen, "admin", true) == 0)
                    {
                        id = 0;
                    }
                    else if (String.Compare(Quyen, "manager", true) == 0)
                    {
                        id = 1;
                    }
                    else
                    {
                        id = 2;
                    }
                    this.Hide();
                    frmMain mn = new frmMain(id);
                    mn.ShowDialog();
                    mn = null;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác !");
                    return;
                }
            }

            
        }

        private void lb_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmQuenMatKhau frmQMK = new frmQuenMatKhau();
            DialogResult result = frmQMK.ShowDialog();

            if (result == DialogResult.OK)
            { this.Show(); }
            else { this.Show(); }
        }

        private void lb_DangKi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            frmDangKy frmDK = new frmDangKy();
            DialogResult result = frmDK.ShowDialog();

            if (result == DialogResult.OK)
            { this.Show(); }
            else { this.Show(); }
        }
    }
}
