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
                SqlCommand cmd = new SqlCommand("Select idU, nameU,passU,emailU From Users", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                foreach (DataRow item in dt.Rows) { 

                }
                con.Close();

                textBox_idTK.Text = "";
                textBox_tenTK.Text = "";
                textBox_matkhau.Text = "";
                textBox_Email.Text = "";
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.quanLyNhanSuDataSet.Users);
            LoadUsers();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
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
            }
            catch (Exception ex)
            {

            }
        }
    }
}
