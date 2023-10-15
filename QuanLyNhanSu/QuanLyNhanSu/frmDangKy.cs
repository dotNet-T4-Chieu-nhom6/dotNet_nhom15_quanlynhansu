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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap mn = new frmDangNhap();
            mn.ShowDialog();
            mn = null;
            this.Close();
        }
    }
}
