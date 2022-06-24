namespace listview1
{
    partial class frmDanhSach
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
            this.lvwDanhSach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdXoaTrang = new System.Windows.Forms.Button();
            this.cmdThem = new System.Windows.Forms.Button();
            this.cmdCapNhat = new System.Windows.Forms.Button();
            this.cmdXoaBo = new System.Windows.Forms.Button();
            this.cmdKetThuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HỒ SƠ SINH VIÊN";
            // 
            // lvwDanhSach
            // 
            this.lvwDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwDanhSach.FullRowSelect = true;
            this.lvwDanhSach.GridLines = true;
            this.lvwDanhSach.Location = new System.Drawing.Point(8, 64);
            this.lvwDanhSach.Name = "lvwDanhSach";
            this.lvwDanhSach.Size = new System.Drawing.Size(720, 232);
            this.lvwDanhSach.TabIndex = 1;
            this.lvwDanhSach.UseCompatibleStateImageBehavior = false;
            this.lvwDanhSach.View = System.Windows.Forms.View.Details;
            this.lvwDanhSach.SelectedIndexChanged += new System.EventHandler(this.lvwDanhSach_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã SV";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ Tên";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Sinh";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lớp";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Điện Thoại";
            this.columnHeader5.Width = 138;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Địa Chỉ";
            this.columnHeader6.Width = 119;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sinh viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ và tên  :";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(144, 320);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(240, 27);
            this.txtMaSinhVien.TabIndex = 5;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(144, 384);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(240, 27);
            this.txtNgaySinh.TabIndex = 6;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(144, 352);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(240, 27);
            this.txtHoVaTen.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(512, 352);
            this.txtDienThoai.MaxLength = 10;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(216, 27);
            this.txtDienThoai.TabIndex = 13;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(512, 384);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(216, 27);
            this.txtDiaChi.TabIndex = 12;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(512, 320);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(216, 27);
            this.txtLop.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Điện thoại :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Địa chỉ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lớp :";
            // 
            // cmdXoaTrang
            // 
            this.cmdXoaTrang.Location = new System.Drawing.Point(144, 424);
            this.cmdXoaTrang.Name = "cmdXoaTrang";
            this.cmdXoaTrang.Size = new System.Drawing.Size(104, 31);
            this.cmdXoaTrang.TabIndex = 15;
            this.cmdXoaTrang.Text = "Xóa trắng";
            this.cmdXoaTrang.UseVisualStyleBackColor = true;
            this.cmdXoaTrang.Click += new System.EventHandler(this.cmdXoaTrang_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(264, 424);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(104, 31);
            this.cmdThem.TabIndex = 16;
            this.cmdThem.Text = "Thêm ";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdCapNhat
            // 
            this.cmdCapNhat.Location = new System.Drawing.Point(384, 424);
            this.cmdCapNhat.Name = "cmdCapNhat";
            this.cmdCapNhat.Size = new System.Drawing.Size(104, 31);
            this.cmdCapNhat.TabIndex = 17;
            this.cmdCapNhat.Text = "Cập nhật";
            this.cmdCapNhat.UseVisualStyleBackColor = true;
            this.cmdCapNhat.Click += new System.EventHandler(this.cmdCapNhat_Click);
            // 
            // cmdXoaBo
            // 
            this.cmdXoaBo.Location = new System.Drawing.Point(504, 424);
            this.cmdXoaBo.Name = "cmdXoaBo";
            this.cmdXoaBo.Size = new System.Drawing.Size(104, 31);
            this.cmdXoaBo.TabIndex = 18;
            this.cmdXoaBo.Text = "Xóa bỏ";
            this.cmdXoaBo.UseVisualStyleBackColor = true;
            this.cmdXoaBo.Click += new System.EventHandler(this.cmdXoaBo_Click);
            // 
            // cmdKetThuc
            // 
            this.cmdKetThuc.Location = new System.Drawing.Point(624, 424);
            this.cmdKetThuc.Name = "cmdKetThuc";
            this.cmdKetThuc.Size = new System.Drawing.Size(104, 31);
            this.cmdKetThuc.TabIndex = 19;
            this.cmdKetThuc.Text = "Kết thúc";
            this.cmdKetThuc.UseVisualStyleBackColor = true;
            this.cmdKetThuc.Click += new System.EventHandler(this.cmdKetThuc_Click);
            // 
            // frmDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 465);
            this.Controls.Add(this.cmdKetThuc);
            this.Controls.Add(this.cmdXoaBo);
            this.Controls.Add(this.cmdCapNhat);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.cmdXoaTrang);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvwDanhSach);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmDanhSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDanhSach_FormClosing);
            this.Load += new System.EventHandler(this.frmDanhSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwDanhSach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdXoaTrang;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Button cmdCapNhat;
        private System.Windows.Forms.Button cmdXoaBo;
        private System.Windows.Forms.Button cmdKetThuc;
    }
}

