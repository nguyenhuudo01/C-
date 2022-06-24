namespace QLThuVien
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
            this.txtMatKhau2 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtMatKhau1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.cmdKetThuc2 = new System.Windows.Forms.Button();
            this.cmdDoiMatKhau = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.grpLayOTP = new System.Windows.Forms.GroupBox();
            this.cmdKiemTraOTP = new System.Windows.Forms.Button();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdKetThuc1 = new System.Windows.Forms.Button();
            this.cmdLayMa = new System.Windows.Forms.Button();
            this.grpDoiMatKhau = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpLayOTP.SuspendLayout();
            this.grpDoiMatKhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMatKhau2
            // 
            this.txtMatKhau2.Location = new System.Drawing.Point(120, 100);
            this.txtMatKhau2.Name = "txtMatKhau2";
            this.txtMatKhau2.PasswordChar = '*';
            this.txtMatKhau2.Size = new System.Drawing.Size(240, 23);
            this.txtMatKhau2.TabIndex = 4;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(10, 100);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(76, 16);
            this.Label5.TabIndex = 3;
            this.Label5.Text = "Nhập lại : ";
            // 
            // txtMatKhau1
            // 
            this.txtMatKhau1.Location = new System.Drawing.Point(120, 60);
            this.txtMatKhau1.Name = "txtMatKhau1";
            this.txtMatKhau1.PasswordChar = '*';
            this.txtMatKhau1.Size = new System.Drawing.Size(240, 23);
            this.txtMatKhau1.TabIndex = 2;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(10, 60);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(112, 16);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Mật khẩu mới : ";
            // 
            // cmdKetThuc2
            // 
            this.cmdKetThuc2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKetThuc2.Location = new System.Drawing.Point(260, 160);
            this.cmdKetThuc2.Name = "cmdKetThuc2";
            this.cmdKetThuc2.Size = new System.Drawing.Size(100, 30);
            this.cmdKetThuc2.TabIndex = 6;
            this.cmdKetThuc2.Text = "Kết thúc";
            this.cmdKetThuc2.UseVisualStyleBackColor = true;
            this.cmdKetThuc2.Click += new System.EventHandler(this.cmdKetThuc2_Click);
            // 
            // cmdDoiMatKhau
            // 
            this.cmdDoiMatKhau.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDoiMatKhau.Location = new System.Drawing.Point(120, 160);
            this.cmdDoiMatKhau.Name = "cmdDoiMatKhau";
            this.cmdDoiMatKhau.Size = new System.Drawing.Size(130, 30);
            this.cmdDoiMatKhau.TabIndex = 5;
            this.cmdDoiMatKhau.Text = "Đổi mật khẩu";
            this.cmdDoiMatKhau.UseVisualStyleBackColor = true;
            this.cmdDoiMatKhau.Click += new System.EventHandler(this.cmdDoiMatKhau_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 23);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(10, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(90, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Nhập email :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(130, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(219, 25);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "LẤY MÃ KHÔI PHỤC";
            // 
            // grpLayOTP
            // 
            this.grpLayOTP.Controls.Add(this.grpDoiMatKhau);
            this.grpLayOTP.Controls.Add(this.cmdKiemTraOTP);
            this.grpLayOTP.Controls.Add(this.txtOTP);
            this.grpLayOTP.Controls.Add(this.label3);
            this.grpLayOTP.Controls.Add(this.cmdKetThuc1);
            this.grpLayOTP.Controls.Add(this.cmdLayMa);
            this.grpLayOTP.Controls.Add(this.Label1);
            this.grpLayOTP.Controls.Add(this.Label2);
            this.grpLayOTP.Controls.Add(this.txtEmail);
            this.grpLayOTP.Location = new System.Drawing.Point(10, 10);
            this.grpLayOTP.Name = "grpLayOTP";
            this.grpLayOTP.Size = new System.Drawing.Size(370, 210);
            this.grpLayOTP.TabIndex = 0;
            this.grpLayOTP.TabStop = false;
            // 
            // cmdKiemTraOTP
            // 
            this.cmdKiemTraOTP.Enabled = false;
            this.cmdKiemTraOTP.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKiemTraOTP.Location = new System.Drawing.Point(120, 160);
            this.cmdKiemTraOTP.Name = "cmdKiemTraOTP";
            this.cmdKiemTraOTP.Size = new System.Drawing.Size(240, 30);
            this.cmdKiemTraOTP.TabIndex = 7;
            this.cmdKiemTraOTP.Text = "Kiểm tra mã OPT";
            this.cmdKiemTraOTP.UseVisualStyleBackColor = true;
            this.cmdKiemTraOTP.Click += new System.EventHandler(this.cmdKiemTraOTP_Click);
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(120, 130);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(240, 23);
            this.txtOTP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập mã OTP :";
            // 
            // cmdKetThuc1
            // 
            this.cmdKetThuc1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKetThuc1.Location = new System.Drawing.Point(250, 90);
            this.cmdKetThuc1.Name = "cmdKetThuc1";
            this.cmdKetThuc1.Size = new System.Drawing.Size(110, 30);
            this.cmdKetThuc1.TabIndex = 4;
            this.cmdKetThuc1.Text = "Kết thúc";
            this.cmdKetThuc1.UseVisualStyleBackColor = true;
            this.cmdKetThuc1.Click += new System.EventHandler(this.cmdKetThuc1_Click);
            // 
            // cmdLayMa
            // 
            this.cmdLayMa.Enabled = false;
            this.cmdLayMa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLayMa.Location = new System.Drawing.Point(120, 90);
            this.cmdLayMa.Name = "cmdLayMa";
            this.cmdLayMa.Size = new System.Drawing.Size(120, 30);
            this.cmdLayMa.TabIndex = 3;
            this.cmdLayMa.Text = "Lấy mã OTP";
            this.cmdLayMa.UseVisualStyleBackColor = true;
            this.cmdLayMa.Click += new System.EventHandler(this.cmdLayMa_Click);
            // 
            // grpDoiMatKhau
            // 
            this.grpDoiMatKhau.Controls.Add(this.label6);
            this.grpDoiMatKhau.Controls.Add(this.txtMatKhau2);
            this.grpDoiMatKhau.Controls.Add(this.cmdDoiMatKhau);
            this.grpDoiMatKhau.Controls.Add(this.Label5);
            this.grpDoiMatKhau.Controls.Add(this.cmdKetThuc2);
            this.grpDoiMatKhau.Controls.Add(this.txtMatKhau1);
            this.grpDoiMatKhau.Controls.Add(this.Label4);
            this.grpDoiMatKhau.Location = new System.Drawing.Point(0, 0);
            this.grpDoiMatKhau.Name = "grpDoiMatKhau";
            this.grpDoiMatKhau.Size = new System.Drawing.Size(370, 210);
            this.grpDoiMatKhau.TabIndex = 1;
            this.grpDoiMatKhau.TabStop = false;
            this.grpDoiMatKhau.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "ĐỔI MẬT KHẨU";
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 233);
            this.Controls.Add(this.grpLayOTP);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên Mật Khẩu";
            this.grpLayOTP.ResumeLayout(false);
            this.grpLayOTP.PerformLayout();
            this.grpDoiMatKhau.ResumeLayout(false);
            this.grpDoiMatKhau.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.TextBox txtMatKhau2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtMatKhau1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button cmdKetThuc2;
        internal System.Windows.Forms.Button cmdDoiMatKhau;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox grpLayOTP;
        internal System.Windows.Forms.Button cmdKiemTraOTP;
        internal System.Windows.Forms.TextBox txtOTP;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button cmdKetThuc1;
        internal System.Windows.Forms.Button cmdLayMa;
        private System.Windows.Forms.GroupBox grpDoiMatKhau;
        internal System.Windows.Forms.Label label6;
    }
}