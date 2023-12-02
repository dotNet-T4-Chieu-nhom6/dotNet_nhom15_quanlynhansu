using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void LoadUsers()
        {
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Users", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                textBox_idTK.Text = "";
                textBox_tenTK.Text = "";
                textBox_matkhau.Text = "";
                textBox_Email.Text = "";
                comboBox_Quyen.SelectedIndex = -1;
                dataGridView1.ClearSelection();
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {

            LoadUsers();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrows;
            numrows = e.RowIndex;
            try
            {
                textBox_idTK.Text = dataGridView1.Rows[numrows].Cells[0].Value.ToString();
                textBox_tenTK.Text = dataGridView1.Rows[numrows].Cells[1].Value.ToString();
                textBox_matkhau.Text = dataGridView1.Rows[numrows].Cells[2].Value.ToString();
                textBox_Email.Text = dataGridView1.Rows[numrows].Cells[3].Value.ToString();
                comboBox_Quyen.Text = dataGridView1.Rows[numrows].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private bool kiemtrarong()
        {
            if (string.IsNullOrEmpty(textBox_tenTK.Text))
            {
                MessageBox.Show("không được để trống tên tài khoản");
                return false;
            }
            if (string.IsNullOrEmpty(textBox_matkhau.Text))
            {
                MessageBox.Show("không được để trống mật khẩu");
                return false;
            }
            if (string.IsNullOrEmpty(textBox_Email.Text))
            {
                MessageBox.Show("không được để trống email");
                return false;
            }
            if (!IsEmailValid(textBox_Email.Text))
            {
                MessageBox.Show("Địa chỉ email không đúng định dạng");
                return false;
            }
            if (string.IsNullOrEmpty(comboBox_Quyen.Text))
            {
                MessageBox.Show("hãy chọn quyền");
                return false;
            }
            else
            return true;
        }
        private bool IsDuplicateName(string name)
        {
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                // đếm , nếu >0 thì trùng
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE nameU = @Name", con);
                cmd.Parameters.AddWithValue("@Name", name);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        private bool IsDuplicateEmail(string email)
        {
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                // đếm , nếu >0 thì trùng
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE emailU = @Email", con);
                cmd.Parameters.AddWithValue("@Email", email);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        public static bool IsEmailValid(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            // Biểu thức chính quy kiểm tra định dạng email
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            return Regex.IsMatch(email, pattern);
        }
        private void button_Them_Click(object sender, EventArgs e)
        {
            if (IsDuplicateName(textBox_tenTK.Text))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng nhập một tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsDuplicateEmail(textBox_Email.Text))
            {
                MessageBox.Show("Mail đã đăng ký. Vui lòng nhập một mail khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (kiemtrarong())
            {
                using (SqlConnection con = Connection.GetSqlConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert Into Users Values (@Name, @Pass, @Email, @Quyen)", con);
                    cmd.Parameters.AddWithValue("@Name", textBox_tenTK.Text);
                    cmd.Parameters.AddWithValue("@Pass", textBox_matkhau.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox_Email.Text);
                    cmd.Parameters.AddWithValue("@Quyen", comboBox_Quyen.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadUsers();
                }
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_tenTK.Text))
            {
                MessageBox.Show("Hãy chọn một nội dung cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsDuplicateName(textBox_tenTK.Text))
            {
                MessageBox.Show("Tên phòng ban đã tồn tại. Vui lòng nhập một tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Users Set nameU = @Name, passU =@Pass, emailU =@Email, phanquyen =@Quyen Where idU =@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox_idTK.Text));
                cmd.Parameters.AddWithValue("@Name", textBox_tenTK.Text);
                cmd.Parameters.AddWithValue("@Pass", textBox_matkhau.Text);
                cmd.Parameters.AddWithValue("@Email", textBox_Email.Text);
                cmd.Parameters.AddWithValue("@Quyen", comboBox_Quyen.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadUsers();
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            string selectedQuyen = comboBox_Quyen.Text;
            if (selectedQuyen.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Không được phép xóa người dùng có quyền admin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (dataGridView1.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Hãy chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if (string.IsNullOrEmpty(textBox_tenTK.Text))
            {
                MessageBox.Show("Hãy chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete Users Where idU =@ID",con);
                cmd.Parameters.AddWithValue("@ID", textBox_idTK.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadUsers();
            }
        }
        private void button_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
