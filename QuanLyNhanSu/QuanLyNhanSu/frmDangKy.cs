using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace QuanLyNhanSu
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();

        public bool IsEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string tenTk = txt_User.Text;
            string MatKhau = txt_Pass.Text;
            string xacNhanMatKhau = txt_XacNhanPass.Text;
            string Email = txt_Email.Text;
            string Admin;

            if (tenTk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }

            if (MatKhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }

            if (xacNhanMatKhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập xác nhận mật khẩu");
                return;
            }

            if (Email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Email");
                return;
            }

            if (xacNhanMatKhau != MatKhau)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác");
                return;
            }

            if (IsEmail(Email) == false)
            {
                MessageBox.Show("Email này không đúng định dạng, vui lòng nhập đúng định dạng");
                return;
            }

            if (modify.Userss("Select * from Users where emailU = '" + Email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng kí , vui lòng nhập email khác");
                return;
            }

            if (chbAdmin.Checked == true)
            {
                Admin = "admin";
            }
            else
            {
                Admin = "user";
            }

            try
            {
                string query = "Insert into Users(nameU, passU, emailU, phanquyen ) Values " +
                    "('" + tenTk + "', '" + MatKhau + "', '" + Email + "', N'" + Admin + "')";
                modify.Command(query);
                this.Hide();
                frmDangNhap mn = new frmDangNhap();
                mn.ShowDialog();
                mn = null;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Tên Tài Khoản này đã được đăng ký, vui lòng đăng kí tài khoản khác!");
                return;
            }
        }
    }
}
