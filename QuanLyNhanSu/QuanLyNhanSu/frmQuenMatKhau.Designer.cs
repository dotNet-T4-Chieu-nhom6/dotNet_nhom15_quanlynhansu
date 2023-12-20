
namespace QuanLyNhanSu
{
    partial class frmQuenMatKhau
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
            this.ptb4 = new System.Windows.Forms.PictureBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lb_KetQua = new System.Windows.Forms.Label();
            this.btn_LayLaiPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb4
            // 
            this.ptb4.Image = global::QuanLyNhanSu.Properties.Resources.iconGmail;
            this.ptb4.Location = new System.Drawing.Point(57, 57);
            this.ptb4.Name = "ptb4";
            this.ptb4.Size = new System.Drawing.Size(45, 38);
            this.ptb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb4.TabIndex = 24;
            this.ptb4.TabStop = false;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txt_Email.Location = new System.Drawing.Point(132, 66);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(267, 26);
            this.txt_Email.TabIndex = 25;
            // 
            // lb_KetQua
            // 
            this.lb_KetQua.AutoSize = true;
            this.lb_KetQua.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lb_KetQua.Location = new System.Drawing.Point(66, 133);
            this.lb_KetQua.Name = "lb_KetQua";
            this.lb_KetQua.Size = new System.Drawing.Size(58, 19);
            this.lb_KetQua.TabIndex = 26;
            this.lb_KetQua.Text = "Kết quả";
            // 
            // btn_LayLaiPass
            // 
            this.btn_LayLaiPass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_LayLaiPass.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_LayLaiPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_LayLaiPass.Location = new System.Drawing.Point(114, 170);
            this.btn_LayLaiPass.Name = "btn_LayLaiPass";
            this.btn_LayLaiPass.Size = new System.Drawing.Size(254, 51);
            this.btn_LayLaiPass.TabIndex = 27;
            this.btn_LayLaiPass.Text = "LẤY LẠI MẬT KHẨU";
            this.btn_LayLaiPass.UseVisualStyleBackColor = false;
            this.btn_LayLaiPass.Click += new System.EventHandler(this.btn_LayLaiPass_Click);
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 237);
            this.Controls.Add(this.btn_LayLaiPass);
            this.Controls.Add(this.lb_KetQua);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.ptb4);
            this.Name = "frmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb4;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lb_KetQua;
        private System.Windows.Forms.Button btn_LayLaiPass;
    }
}