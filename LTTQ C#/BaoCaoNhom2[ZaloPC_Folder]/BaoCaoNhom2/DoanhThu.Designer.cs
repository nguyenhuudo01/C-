
namespace BaoCaoNhom2
{
    partial class DoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoanhThu));
            this.btnThoat = new BoTronButton.DesignButton();
            this.doanhThuPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhThuTheoNămToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuTheoThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biểuĐồDonhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new BoTronButton.DesignButton();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPhuThu = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblPhong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXuatEx = new BoTronButton.DesignButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.BorderColer = System.Drawing.Color.PaleVioletRed;
            this.btnThoat.BorderRadius = 40;
            this.btnThoat.BorderSize = 0;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1225, 971);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(190, 40);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // doanhThuPhòngToolStripMenuItem
            // 
            this.doanhThuPhòngToolStripMenuItem.Name = "doanhThuPhòngToolStripMenuItem";
            this.doanhThuPhòngToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.doanhThuPhòngToolStripMenuItem.Text = "Doanh Thu Phòng";
            this.doanhThuPhòngToolStripMenuItem.Click += new System.EventHandler(this.doanhThuPhòngToolStripMenuItem_Click_1);
            // 
            // danhThuTheoNămToolStripMenuItem
            // 
            this.danhThuTheoNămToolStripMenuItem.Name = "danhThuTheoNămToolStripMenuItem";
            this.danhThuTheoNămToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.danhThuTheoNămToolStripMenuItem.Text = "Biểu Đồ Theo Năm";
            this.danhThuTheoNămToolStripMenuItem.Click += new System.EventHandler(this.danhThuTheoNămToolStripMenuItem_Click_1);
            // 
            // doanhThuTheoThángToolStripMenuItem
            // 
            this.doanhThuTheoThángToolStripMenuItem.Name = "doanhThuTheoThángToolStripMenuItem";
            this.doanhThuTheoThángToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.doanhThuTheoThángToolStripMenuItem.Text = "Biểu Đồ Theo Tháng";
            this.doanhThuTheoThángToolStripMenuItem.Click += new System.EventHandler(this.doanhThuTheoThángToolStripMenuItem_Click_1);
            // 
            // biểuĐồDonhThuToolStripMenuItem
            // 
            this.biểuĐồDonhThuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuTheoThángToolStripMenuItem,
            this.danhThuTheoNămToolStripMenuItem,
            this.doanhThuPhòngToolStripMenuItem});
            this.biểuĐồDonhThuToolStripMenuItem.Name = "biểuĐồDonhThuToolStripMenuItem";
            this.biểuĐồDonhThuToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.biểuĐồDonhThuToolStripMenuItem.Text = "Biểu Đồ Doanh Thu";
            // 
            // bảngDoanhThuToolStripMenuItem
            // 
            this.bảngDoanhThuToolStripMenuItem.Name = "bảngDoanhThuToolStripMenuItem";
            this.bảngDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.bảngDoanhThuToolStripMenuItem.Text = "Bảng Thống Kê Doanh Thu";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.dtpKetThuc);
            this.groupBox1.Controls.Add(this.dtpBatDau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(104, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1311, 115);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thống kê";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThongKe.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnThongKe.BorderColer = System.Drawing.Color.PaleVioletRed;
            this.btnThongKe.BorderRadius = 40;
            this.btnThongKe.BorderSize = 0;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(1121, 41);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(166, 50);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextColor = System.Drawing.Color.White;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetThuc.Location = new System.Drawing.Point(844, 60);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(200, 22);
            this.dtpKetThuc.TabIndex = 3;
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBatDau.Location = new System.Drawing.Point(447, 60);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(200, 22);
            this.dtpBatDau.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(693, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(306, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(876, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 32);
            this.label4.TabIndex = 33;
            this.label4.Text = "Thống kê doanh thu";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(100, 955);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 26);
            this.label7.TabIndex = 31;
            this.label7.Text = "Phí phòng:";
            // 
            // lblPhuThu
            // 
            this.lblPhuThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPhuThu.AutoSize = true;
            this.lblPhuThu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhuThu.Location = new System.Drawing.Point(737, 955);
            this.lblPhuThu.Name = "lblPhuThu";
            this.lblPhuThu.Size = new System.Drawing.Size(138, 26);
            this.lblPhuThu.TabIndex = 30;
            this.lblPhuThu.Text = ".....................";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThanhTien.Location = new System.Drawing.Point(286, 1003);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(138, 26);
            this.lblThanhTien.TabIndex = 28;
            this.lblThanhTien.Text = ".....................";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(101, 1003);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Thu nhập:";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(104, 243);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1311, 677);
            this.dgvDoanhThu.TabIndex = 26;
            this.dgvDoanhThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoanhThu_CellContentClick_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảngDoanhThuToolStripMenuItem,
            this.biểuĐồDonhThuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1557, 28);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblPhong
            // 
            this.lblPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhong.Location = new System.Drawing.Point(285, 955);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(138, 26);
            this.lblPhong.TabIndex = 32;
            this.lblPhong.Text = ".....................";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(526, 955);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "Phí phụ thu:";
            // 
            // btnXuatEx
            // 
            this.btnXuatEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatEx.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXuatEx.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnXuatEx.BorderColer = System.Drawing.Color.PaleVioletRed;
            this.btnXuatEx.BorderRadius = 40;
            this.btnXuatEx.BorderSize = 0;
            this.btnXuatEx.FlatAppearance.BorderSize = 0;
            this.btnXuatEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatEx.ForeColor = System.Drawing.Color.White;
            this.btnXuatEx.Image = global::BaoCaoNhom2.Properties.Resources.Excel_icon;
            this.btnXuatEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatEx.Location = new System.Drawing.Point(1016, 971);
            this.btnXuatEx.Name = "btnXuatEx";
            this.btnXuatEx.Size = new System.Drawing.Size(190, 40);
            this.btnXuatEx.TabIndex = 24;
            this.btnXuatEx.Text = "Xuất Excel";
            this.btnXuatEx.TextColor = System.Drawing.Color.White;
            this.btnXuatEx.UseVisualStyleBackColor = false;
            this.btnXuatEx.Click += new System.EventHandler(this.btnXuatEx_Click);
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1557, 1055);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatEx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPhuThu);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.label5);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BoTronButton.DesignButton btnThoat;
        private System.Windows.Forms.ToolStripMenuItem doanhThuPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhThuTheoNămToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuTheoThángToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biểuĐồDonhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngDoanhThuToolStripMenuItem;
        private BoTronButton.DesignButton btnXuatEx;
        private System.Windows.Forms.GroupBox groupBox1;
        private BoTronButton.DesignButton btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPhuThu;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label label5;
    }
}