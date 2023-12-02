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

namespace QuanLyNhanSu
{
    public partial class frmDepartment : Form
    {
        int index = -1;
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void LoadDepartment()
        {
            SqlConnection con = Connection.GetSqlConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from PhongBan", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_Department.DataSource = dt;

            dataGridView_Department.ClearSelection();
            txt_tenPB.Text = "";
            txt_idphongban.Text = "";
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            LoadDepartment();
        }

        private void dataGridView_Department_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            try
            {
                txt_idphongban.Text = dataGridView_Department.Rows[numrow].Cells[0].Value.ToString();
                txt_tenPB.Text = dataGridView_Department.Rows[numrow].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                txt_tenPB.Text = "";
            }
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenPB.Text))
            {
                MessageBox.Show("Tên phòng ban không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsDuplicateName(txt_tenPB.Text))
            {
                MessageBox.Show("Tên phòng ban đã tồn tại. Vui lòng nhập một tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into PhongBan Values (@Name)", con);
                cmd.Parameters.AddWithValue("@Name", txt_tenPB.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadDepartment();
            }
        }

        private bool IsDuplicateName(string name)
        {
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                // đếm tên phòng ban, nếu >0 thì trùng tên
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM PhongBan WHERE tenphongban = @Name", con);
                cmd.Parameters.AddWithValue("@Name", name);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenPB.Text))
            {
                MessageBox.Show("Hãy chọn một nội dung cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsDuplicateName(txt_tenPB.Text))
            {
                MessageBox.Show("Tên phòng ban đã tồn tại. Vui lòng nhập một tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update PhongBan Set tenphongban = @Name Where idphongban =@ID",con);
                cmd.Parameters.AddWithValue("@ID",int.Parse(txt_idphongban.Text));
                cmd.Parameters.AddWithValue("@Name",txt_tenPB.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadDepartment();
            }

        }

        private void dataGridView_Department_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // cột chứa tên phòng ban là 1
            if (e.ColumnIndex == 1)
            {
                DataGridViewColumn column = dataGridView_Department.Columns[e.ColumnIndex];
                if (column != null)
                {
                    //DataGridViewAutoSizeColumnMode.AllCells, cột sẽ tự động điều chỉnh kích thước của mình dựa trên nội dung của tất cả các ô trong cột.
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            //if (dataGridView_Department.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Hãy chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if (string.IsNullOrEmpty(txt_tenPB.Text))
            {
                MessageBox.Show("Hãy chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete PhongBan Where idphongban =@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txt_idphongban.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                LoadDepartment();
            }
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
