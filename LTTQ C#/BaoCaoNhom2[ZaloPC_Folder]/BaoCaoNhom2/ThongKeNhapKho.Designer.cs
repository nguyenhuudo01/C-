
namespace BaoCaoNhom2
{
    partial class ThongKeNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeNhapKho));
            this.biểuĐồNhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThoat = new BoTronButton.DesignButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new BoTronButton.DesignButton();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.soLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tenSPNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNhapKho = new System.Windows.Forms.DataGridView();
            this.btnXuatEx = new BoTronButton.DesignButton();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).BeginInit();
            this.SuspendLayout();
            // 
            // biểuĐồNhậpKhoToolStripMenuItem
            // 
            this.biểuĐồNhậpKhoToolStripMenuItem.Name = "biểuĐồNhậpKhoToolStripMenuItem";
            this.biểuĐồNhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.biểuĐồNhậpKhoToolStripMenuItem.Text = "Biểu đồ nhập kho";
            this.biểuĐồNhậpKhoToolStripMenuItem.Click += new System.EventHandler(this.biểuĐồNhậpKhoToolStripMenuItem_Click_1);
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
            this.btnThoat.Location = new System.Drawing.Point(1223, 991);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(183, 40);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(100, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1306, 117);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thống kê";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnThongKe.Location = new System.Drawing.Point(998, 54);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(150, 40);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextColor = System.Drawing.Color.White;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetThuc.Location = new System.Drawing.Point(732, 63);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(200, 22);
            this.dtpKetThuc.TabIndex = 3;
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBatDau.Location = new System.Drawing.Point(326, 63);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(200, 22);
            this.dtpBatDau.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(574, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(200, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // thanhTienNhap
            // 
            this.thanhTienNhap.DataPropertyName = "thanhTienNhap";
            this.thanhTienNhap.HeaderText = "Thành tiền";
            this.thanhTienNhap.MinimumWidth = 6;
            this.thanhTienNhap.Name = "thanhTienNhap";
            this.thanhTienNhap.Width = 125;
            // 
            // ngayNhap
            // 
            this.ngayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayNhap.DataPropertyName = "ngayNhap";
            this.ngayNhap.HeaderText = "Ngày nhập";
            this.ngayNhap.MinimumWidth = 6;
            this.ngayNhap.Name = "ngayNhap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(761, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 32);
            this.label4.TabIndex = 31;
            this.label4.Text = "Thống kê lượng hàng nhập kho";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThanhTien.Location = new System.Drawing.Point(290, 1005);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(138, 26);
            this.lblThanhTien.TabIndex = 30;
            this.lblThanhTien.Text = ".....................";
            // 
            // soLuongNhap
            // 
            this.soLuongNhap.DataPropertyName = "soLuongNhap";
            this.soLuongNhap.HeaderText = "Số lượng";
            this.soLuongNhap.MinimumWidth = 6;
            this.soLuongNhap.Name = "soLuongNhap";
            this.soLuongNhap.Width = 125;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(100, 1005);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tổng phí:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biểuĐồNhậpKhoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1557, 30);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tenSPNhap
            // 
            this.tenSPNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenSPNhap.DataPropertyName = "tenSPNhap";
            this.tenSPNhap.HeaderText = "Tên sản phẩm";
            this.tenSPNhap.MinimumWidth = 6;
            this.tenSPNhap.Name = "tenSPNhap";
            // 
            // dgvNhapKho
            // 
            this.dgvNhapKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhapKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenSPNhap,
            this.soLuongNhap,
            this.ngayNhap,
            this.thanhTienNhap,
            this.id});
            this.dgvNhapKho.Location = new System.Drawing.Point(100, 238);
            this.dgvNhapKho.Name = "dgvNhapKho";
            this.dgvNhapKho.RowHeadersWidth = 51;
            this.dgvNhapKho.RowTemplate.Height = 24;
            this.dgvNhapKho.Size = new System.Drawing.Size(1306, 714);
            this.dgvNhapKho.TabIndex = 28;
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
            this.btnXuatEx.Location = new System.Drawing.Point(1036, 991);
            this.btnXuatEx.Name = "btnXuatEx";
            this.btnXuatEx.Size = new System.Drawing.Size(181, 40);
            this.btnXuatEx.TabIndex = 26;
            this.btnXuatEx.Text = "Xuất Excel";
            this.btnXuatEx.TextColor = System.Drawing.Color.White;
            this.btnXuatEx.UseVisualStyleBackColor = false;
            this.btnXuatEx.Click += new System.EventHandler(this.btnXuatEx_Click);
            // 
            // ThongKeNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1557, 1055);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatEx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvNhapKho);
            this.Name = "ThongKeNhapKho";
            this.Text = "ThongKeNhapKho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem biểuĐồNhậpKhoToolStripMenuItem;
        private BoTronButton.DesignButton btnThoat;
        private BoTronButton.DesignButton btnXuatEx;
        private System.Windows.Forms.GroupBox groupBox1;
        private BoTronButton.DesignButton btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPNhap;
        private System.Windows.Forms.DataGridView dgvNhapKho;
    }
}