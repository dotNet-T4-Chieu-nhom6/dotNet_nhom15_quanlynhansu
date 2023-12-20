using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QuanLyNhanSu
{
    public partial class frmDeleteEmp : Form
    {
        public frmDeleteEmp()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(r == DialogResult.Yes)
            {
                int ID = int.Parse(txt_EmpID.Text);
                Bus_Layer.DeleteEmp(ID);
                MessageBox.Show("Xóa thành công");                
            }
            dtgv_Emp.DataSource = Bus_Layer.GetAllEmps();
            
        }

        private void dtgv_Emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            try
            {
                row = dtgv_Emp.Rows[e.RowIndex];
                txt_EmpID.Text = row.Cells[0].Value.ToString();
            }
            catch
            {
                txt_EmpID.Clear();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Hide();
                frmMain f = new frmMain();
                f.Show();
            }
        }

        private void frmDeleteEmp_Load(object sender, EventArgs e)
        {
            dtgv_Emp.DataSource = Bus_Layer.GetAllEmps();
        }

        private void frmDeleteEmp_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Hide();
                frmMain f = new frmMain();
                f.Show();
            }
        }

    }
}
