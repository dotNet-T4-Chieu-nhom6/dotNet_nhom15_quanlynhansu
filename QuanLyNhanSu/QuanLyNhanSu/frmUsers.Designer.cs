﻿namespace QuanLyNhanSu
{
    partial class frmUsers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_tenTK = new System.Windows.Forms.TextBox();
            this.textBox_matkhau = new System.Windows.Forms.TextBox();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_idTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Quyen = new System.Windows.Forms.ComboBox();
            this.button_Themmoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quyền";
            // 
            // textBox_tenTK
            // 
            this.textBox_tenTK.Location = new System.Drawing.Point(143, 80);
            this.textBox_tenTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_tenTK.Name = "textBox_tenTK";
            this.textBox_tenTK.Size = new System.Drawing.Size(212, 22);
            this.textBox_tenTK.TabIndex = 2;
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.Location = new System.Drawing.Point(143, 133);
            this.textBox_matkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.Size = new System.Drawing.Size(212, 22);
            this.textBox_matkhau.TabIndex = 3;
            // 
            // button_Them
            // 
            this.button_Them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.Location = new System.Drawing.Point(28, 310);
            this.button_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(91, 30);
            this.button_Them.TabIndex = 6;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sua.Location = new System.Drawing.Point(28, 371);
            this.button_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(91, 30);
            this.button_Sua.TabIndex = 8;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.Location = new System.Drawing.Point(209, 371);
            this.button_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(91, 30);
            this.button_Xoa.TabIndex = 9;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.Location = new System.Drawing.Point(28, 436);
            this.button_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(91, 30);
            this.button_Thoat.TabIndex = 10;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(575, 454);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox_idTK
            // 
            this.textBox_idTK.Location = new System.Drawing.Point(143, 28);
            this.textBox_idTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_idTK.Name = "textBox_idTK";
            this.textBox_idTK.ReadOnly = true;
            this.textBox_idTK.Size = new System.Drawing.Size(212, 22);
            this.textBox_idTK.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID tài khoản";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(143, 190);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(212, 22);
            this.textBox_Email.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // comboBox_Quyen
            // 
            this.comboBox_Quyen.FormattingEnabled = true;
            this.comboBox_Quyen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_Quyen.Items.AddRange(new object[] {
            "admin",
            "user",
            "manager"});
            this.comboBox_Quyen.Location = new System.Drawing.Point(143, 249);
            this.comboBox_Quyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Quyen.Name = "comboBox_Quyen";
            this.comboBox_Quyen.Size = new System.Drawing.Size(209, 24);
            this.comboBox_Quyen.TabIndex = 5;
            // 
            // button_Themmoi
            // 
            this.button_Themmoi.AutoSize = true;
            this.button_Themmoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Themmoi.Location = new System.Drawing.Point(209, 310);
            this.button_Themmoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Themmoi.Name = "button_Themmoi";
            this.button_Themmoi.Size = new System.Drawing.Size(93, 30);
            this.button_Themmoi.TabIndex = 7;
            this.button_Themmoi.Text = "Thêm mới";
            this.button_Themmoi.UseVisualStyleBackColor = true;
            this.button_Themmoi.Click += new System.EventHandler(this.button_Themmoi_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 478);
            this.Controls.Add(this.button_Themmoi);
            this.Controls.Add(this.comboBox_Quyen);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_idTK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.textBox_matkhau);
            this.Controls.Add(this.textBox_tenTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUsers_FormClosing);
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_tenTK;
        private System.Windows.Forms.TextBox textBox_matkhau;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_idTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Quyen;
        private System.Windows.Forms.Button button_Themmoi;
    }
}