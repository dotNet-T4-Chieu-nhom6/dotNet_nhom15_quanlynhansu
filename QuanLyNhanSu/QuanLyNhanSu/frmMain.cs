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

namespace QuanLyNhanSu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
    }
}
