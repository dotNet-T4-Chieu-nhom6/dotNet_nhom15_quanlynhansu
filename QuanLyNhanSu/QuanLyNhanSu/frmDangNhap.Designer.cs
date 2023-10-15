
namespace QuanLyNhanSu
{
    partial class frmDangNhap
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
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.lb_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.lb_DangKi = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.AutoSize = true;
            this.btn_DangNhap.BackColor = System.Drawing.Color.Black;
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DangNhap.Location = new System.Drawing.Point(143, 195);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(226, 43);
            this.btn_DangNhap.TabIndex = 14;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QuanLyNhanSu.Properties.Resources.iconUser;
            this.pictureBox2.Image = global::QuanLyNhanSu.Properties.Resources.iconUser;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(75, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanLyNhanSu.Properties.Resources.iconPass;
            this.pictureBox3.Location = new System.Drawing.Point(74, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(143, 42);
            this.txt_User.Multiline = true;
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(248, 38);
            this.txt_User.TabIndex = 11;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(143, 113);
            this.txt_Pass.Multiline = true;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(248, 38);
            this.txt_Pass.TabIndex = 10;
            // 
            // lb_QuenMatKhau
            // 
            this.lb_QuenMatKhau.AutoSize = true;
            this.lb_QuenMatKhau.BackColor = System.Drawing.Color.White;
            this.lb_QuenMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuenMatKhau.Location = new System.Drawing.Point(72, 262);
            this.lb_QuenMatKhau.Name = "lb_QuenMatKhau";
            this.lb_QuenMatKhau.Size = new System.Drawing.Size(115, 19);
            this.lb_QuenMatKhau.TabIndex = 12;
            this.lb_QuenMatKhau.TabStop = true;
            this.lb_QuenMatKhau.Text = "Quên Mật Khẩu?";
            this.lb_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_QuenMatKhau_LinkClicked);
            // 
            // lb_DangKi
            // 
            this.lb_DangKi.AutoSize = true;
            this.lb_DangKi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DangKi.Location = new System.Drawing.Point(71, 291);
            this.lb_DangKi.Name = "lb_DangKi";
            this.lb_DangKi.Size = new System.Drawing.Size(60, 19);
            this.lb_DangKi.TabIndex = 13;
            this.lb_DangKi.TabStop = true;
            this.lb_DangKi.Text = "Đăng Kí";
            this.lb_DangKi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_DangKi_LinkClicked);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(469, 338);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.lb_DangKi);
            this.Controls.Add(this.lb_QuenMatKhau);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.LinkLabel lb_QuenMatKhau;
        private System.Windows.Forms.LinkLabel lb_DangKi;
    }
}