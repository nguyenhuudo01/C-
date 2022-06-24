namespace QLThuVien
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
            this.cmdKetThuc = new System.Windows.Forms.Button();
            this.cmdDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.chkLuuMatKhau = new System.Windows.Forms.CheckBox();
            this.cmdQuenMatKhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdKetThuc
            // 
            this.cmdKetThuc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKetThuc.Location = new System.Drawing.Point(260, 150);
            this.cmdKetThuc.Name = "cmdKetThuc";
            this.cmdKetThuc.Size = new System.Drawing.Size(110, 30);
            this.cmdKetThuc.TabIndex = 20;
            this.cmdKetThuc.Text = "Kết thúc";
            this.cmdKetThuc.UseVisualStyleBackColor = true;
            this.cmdKetThuc.Click += new System.EventHandler(this.cmdKetThuc_Click);
            // 
            // cmdDangNhap
            // 
            this.cmdDangNhap.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDangNhap.Location = new System.Drawing.Point(140, 150);
            this.cmdDangNhap.Name = "cmdDangNhap";
            this.cmdDangNhap.Size = new System.Drawing.Size(110, 30);
            this.cmdDangNhap.TabIndex = 19;
            this.cmdDangNhap.Text = "Đăng nhập";
            this.cmdDangNhap.UseVisualStyleBackColor = true;
            this.cmdDangNhap.Click += new System.EventHandler(this.cmdDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(140, 90);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(230, 23);
            this.txtMatKhau.TabIndex = 18;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(140, 50);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(230, 23);
            this.txtTaiKhoan.TabIndex = 17;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(20, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(85, 16);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Mật khẩu : ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(20, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 16);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Tài khoản : ";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(180, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(140, 25);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "ĐĂNG NHẬP";
            // 
            // chkLuuMatKhau
            // 
            this.chkLuuMatKhau.AutoSize = true;
            this.chkLuuMatKhau.Checked = true;
            this.chkLuuMatKhau.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLuuMatKhau.Location = new System.Drawing.Point(140, 120);
            this.chkLuuMatKhau.Name = "chkLuuMatKhau";
            this.chkLuuMatKhau.Size = new System.Drawing.Size(191, 20);
            this.chkLuuMatKhau.TabIndex = 21;
            this.chkLuuMatKhau.Text = "Lưu tài khoản đăng nhập";
            this.chkLuuMatKhau.UseVisualStyleBackColor = true;
            // 
            // cmdQuenMatKhau
            // 
            this.cmdQuenMatKhau.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQuenMatKhau.Location = new System.Drawing.Point(20, 150);
            this.cmdQuenMatKhau.Name = "cmdQuenMatKhau";
            this.cmdQuenMatKhau.Size = new System.Drawing.Size(110, 30);
            this.cmdQuenMatKhau.TabIndex = 22;
            this.cmdQuenMatKhau.Text = "Quên Mật khẩu";
            this.cmdQuenMatKhau.UseVisualStyleBackColor = true;
            this.cmdQuenMatKhau.Click += new System.EventHandler(this.cmdQuenMatKhau_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 204);
            this.Controls.Add(this.cmdQuenMatKhau);
            this.Controls.Add(this.chkLuuMatKhau);
            this.Controls.Add(this.cmdKetThuc);
            this.Controls.Add(this.cmdDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdKetThuc;
        internal System.Windows.Forms.Button cmdDangNhap;
        internal System.Windows.Forms.TextBox txtMatKhau;
        internal System.Windows.Forms.TextBox txtTaiKhoan;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.CheckBox chkLuuMatKhau;
        internal System.Windows.Forms.Button cmdQuenMatKhau;
    }
}

