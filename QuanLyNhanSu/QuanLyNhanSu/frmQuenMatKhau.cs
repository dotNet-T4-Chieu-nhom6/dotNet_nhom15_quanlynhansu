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
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
            lb_KetQua.Text = "";
        }

        Modify modify = new Modify();

        private void btn_LayLaiPass_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng kí");
            }
            else
            {
                string query = "Select * from Users Where emailU ='" + email + "'";
                if (modify.Userss(query).Count != 0)
                {
                    lb_KetQua.ForeColor = Color.Blue;
                    lb_KetQua.Text = "Mat Khau: " + modify.Userss(query)[0].pass;
                }
                else
                {
                    lb_KetQua.ForeColor = Color.Red;
                    lb_KetQua.Text = "Email này chưa đươc đăng ký";
                }
            }
        }
    }
}
