namespace QuanLyNhanSu
{
    partial class frmDepartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.txt_tenPB = new System.Windows.Forms.TextBox();
            this.dataGridView_Department = new System.Windows.Forms.DataGridView();
            this.txt_idphongban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Department)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Them
            // 
            this.button_Them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.Location = new System.Drawing.Point(42, 60);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(90, 30);
            this.button_Them.TabIndex = 0;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.Location = new System.Drawing.Point(42, 130);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(90, 30);
            this.button_Sua.TabIndex = 1;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.Location = new System.Drawing.Point(42, 200);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(90, 30);
            this.button_Xoa.TabIndex = 2;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.Location = new System.Drawing.Point(42, 414);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(90, 30);
            this.button_Thoat.TabIndex = 3;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // txt_tenPB
            // 
            this.txt_tenPB.Location = new System.Drawing.Point(332, 60);
            this.txt_tenPB.Multiline = true;
            this.txt_tenPB.Name = "txt_tenPB";
            this.txt_tenPB.Size = new System.Drawing.Size(294, 30);
            this.txt_tenPB.TabIndex = 4;
            // 
            // dataGridView_Department
            // 
            this.dataGridView_Department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Department.Location = new System.Drawing.Point(206, 130);
            this.dataGridView_Department.Name = "dataGridView_Department";
            this.dataGridView_Department.RowHeadersWidth = 51;
            this.dataGridView_Department.RowTemplate.Height = 24;
            this.dataGridView_Department.Size = new System.Drawing.Size(502, 315);
            this.dataGridView_Department.TabIndex = 5;
            this.dataGridView_Department.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Department_CellClick);
            this.dataGridView_Department.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_Department_CellFormatting_1);
            // 
            // txt_idphongban
            // 
            this.txt_idphongban.Location = new System.Drawing.Point(332, 12);
            this.txt_idphongban.Multiline = true;
            this.txt_idphongban.Name = "txt_idphongban";
            this.txt_idphongban.ReadOnly = true;
            this.txt_idphongban.Size = new System.Drawing.Size(294, 30);
            this.txt_idphongban.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID phòng ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên phòng ban";
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(720, 456);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idphongban);
            this.Controls.Add(this.dataGridView_Department);
            this.Controls.Add(this.txt_tenPB);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Them);
            this.Name = "frmDepartment";
            this.Text = "FrmDepartment";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Department)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.TextBox txt_tenPB;
        private System.Windows.Forms.DataGridView dataGridView_Department;
        private System.Windows.Forms.TextBox txt_idphongban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}