
namespace QuanLyNhanSu
{
    partial class frmDangKy
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
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_XacNhanPass = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.ptb4 = new System.Windows.Forms.PictureBox();
            this.ptb3 = new System.Windows.Forms.PictureBox();
            this.ptb2 = new System.Windows.Forms.PictureBox();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.chbAdmin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.Color.Black;
            this.btn_DangKy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.Color.White;
            this.btn_DangKy.Location = new System.Drawing.Point(179, 286);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(124, 38);
            this.btn_DangKy.TabIndex = 19;
            this.btn_DangKy.Text = "Đăng Ký";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Email.Location = new System.Drawing.Point(131, 208);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(267, 26);
            this.txt_Email.TabIndex = 18;
            // 
            // txt_XacNhanPass
            // 
            this.txt_XacNhanPass.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_XacNhanPass.Location = new System.Drawing.Point(131, 158);
            this.txt_XacNhanPass.Name = "txt_XacNhanPass";
            this.txt_XacNhanPass.PasswordChar = '*';
            this.txt_XacNhanPass.Size = new System.Drawing.Size(267, 26);
            this.txt_XacNhanPass.TabIndex = 17;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Pass.Location = new System.Drawing.Point(131, 103);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(267, 26);
            this.txt_Pass.TabIndex = 16;
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_User.Location = new System.Drawing.Point(131, 48);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(267, 26);
            this.txt_User.TabIndex = 15;
            // 
            // ptb4
            // 
            this.ptb4.Image = global::QuanLyNhanSu.Properties.Resources.iconGmail;
            this.ptb4.Location = new System.Drawing.Point(64, 206);
            this.ptb4.Name = "ptb4";
            this.ptb4.Size = new System.Drawing.Size(45, 38);
            this.ptb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb4.TabIndex = 23;
            this.ptb4.TabStop = false;
            // 
            // ptb3
            // 
            this.ptb3.Image = global::QuanLyNhanSu.Properties.Resources.iconPass;
            this.ptb3.Location = new System.Drawing.Point(65, 149);
            this.ptb3.Name = "ptb3";
            this.ptb3.Size = new System.Drawing.Size(45, 38);
            this.ptb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb3.TabIndex = 22;
            this.ptb3.TabStop = false;
            // 
            // ptb2
            // 
            this.ptb2.Image = global::QuanLyNhanSu.Properties.Resources.iconPass;
            this.ptb2.Location = new System.Drawing.Point(64, 94);
            this.ptb2.Name = "ptb2";
            this.ptb2.Size = new System.Drawing.Size(45, 38);
            this.ptb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb2.TabIndex = 21;
            this.ptb2.TabStop = false;
            // 
            // ptb1
            // 
            this.ptb1.Image = global::QuanLyNhanSu.Properties.Resources.iconUser;
            this.ptb1.Location = new System.Drawing.Point(65, 39);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(44, 38);
            this.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb1.TabIndex = 20;
            this.ptb1.TabStop = false;
            // 
            // chbAdmin
            // 
            this.chbAdmin.AutoSize = true;
            this.chbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAdmin.Location = new System.Drawing.Point(131, 256);
            this.chbAdmin.Name = "chbAdmin";
            this.chbAdmin.Size = new System.Drawing.Size(65, 20);
            this.chbAdmin.TabIndex = 24;
            this.chbAdmin.Text = "Admin";
            this.chbAdmin.UseVisualStyleBackColor = true;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 344);
            this.Controls.Add(this.chbAdmin);
            this.Controls.Add(this.ptb4);
            this.Controls.Add(this.ptb3);
            this.Controls.Add(this.ptb2);
            this.Controls.Add(this.ptb1);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_XacNhanPass);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Name = "frmDangKy";
            this.Text = "Đăng Ký";
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb4;
        private System.Windows.Forms.PictureBox ptb3;
        private System.Windows.Forms.PictureBox ptb2;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_XacNhanPass;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.CheckBox chbAdmin;
    }
}

