﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLyNhanSu
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();

        public bool CheckEmail(string em)//check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9]{3,20}@gmail.com.(.vn|)$");
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string tenTk = txt_User.Text;
            string MatKhau = txt_Pass.Text;
            string xacNhanMatKhau = txt_XacNhanPass.Text;
            string Email = txt_Email.Text;
            string Admin;

            if(chbAdmin.Checked == true)
            {
                Admin = "admin";
            }
            else
            {
                Admin = "user";
            }

            if (xacNhanMatKhau != MatKhau)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác");
                return;
            }

            if (CheckEmail(Email) == true)
            {
                MessageBox.Show("Email này không đúng định dạng, vui lòng nhập đúng định dạng");
            }

            if (modify.Userss("Select * from Users where emailU = '" + Email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng kí , vui lòng nhập email khác");
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
            }
        }
    }
}
