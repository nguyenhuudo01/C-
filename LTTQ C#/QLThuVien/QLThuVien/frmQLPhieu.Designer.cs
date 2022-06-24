namespace QLThuVien
{
    partial class frmQLPhieu
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
            this.dgPhieu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdKetThuc = new System.Windows.Forms.Button();
            this.cmdTraCuu = new System.Windows.Forms.Button();
            this.optNgayLapPhieu = new System.Windows.Forms.RadioButton();
            this.optNgayHenTra = new System.Windows.Forms.RadioButton();
            this.optPhieuQuaHan = new System.Windows.Forms.RadioButton();
            this.optTimCanBo = new System.Windows.Forms.RadioButton();
            this.optTimSoPhieu = new System.Windows.Forms.RadioButton();
            this.optTimDocGia = new System.Windows.Forms.RadioButton();
            this.dgChiTiet = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkPhieuKetThuc = new System.Windows.Forms.CheckBox();
            this.cmdInPhieu = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPhieu
            // 
            this.dgPhieu.AllowUserToAddRows = false;
            this.dgPhieu.AllowUserToDeleteRows = false;
            this.dgPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgPhieu.Location = new System.Drawing.Point(10, 110);
            this.dgPhieu.Name = "dgPhieu";
            this.dgPhieu.ReadOnly = true;
            this.dgPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPhieu.Size = new System.Drawing.Size(960, 200);
            this.dgPhieu.TabIndex = 61;
            this.dgPhieu.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPhieu_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SoPhieu";
            this.Column1.HeaderText = "Số Phiếu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayLap";
            this.Column2.HeaderText = "Ngày Lập";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayHenTra";
            this.Column3.HeaderText = "Hẹn Trả";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HoTenDG";
            this.Column4.HeaderText = "Độc Giả";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "HoTenCB";
            this.Column5.HeaderText = "Cán Bộ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TheDG";
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 5;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaCB";
            this.Column7.HeaderText = "";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Width = 5;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NgayKetThuc";
            this.Column8.HeaderText = "Kết Thúc";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 120;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TinhTrang";
            this.Column9.HeaderText = "Tình Trạng";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 120;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 59;
            this.label10.Text = "đến : ";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(300, 10);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(130, 23);
            this.dtpDenNgay.TabIndex = 60;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(100, 10);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(130, 23);
            this.dtpTuNgay.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Từ ngày :";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(100, 70);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(330, 23);
            this.txtTimKiem.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tìm kiếm :";
            // 
            // cmdKetThuc
            // 
            this.cmdKetThuc.Location = new System.Drawing.Point(830, 70);
            this.cmdKetThuc.Name = "cmdKetThuc";
            this.cmdKetThuc.Size = new System.Drawing.Size(140, 30);
            this.cmdKetThuc.TabIndex = 50;
            this.cmdKetThuc.Text = "Kết thúc";
            this.cmdKetThuc.UseVisualStyleBackColor = true;
            this.cmdKetThuc.Click += new System.EventHandler(this.cmdKetThuc_Click);
            // 
            // cmdTraCuu
            // 
            this.cmdTraCuu.Location = new System.Drawing.Point(450, 70);
            this.cmdTraCuu.Name = "cmdTraCuu";
            this.cmdTraCuu.Size = new System.Drawing.Size(180, 30);
            this.cmdTraCuu.TabIndex = 49;
            this.cmdTraCuu.Text = "Tra cứu phiếu";
            this.cmdTraCuu.UseVisualStyleBackColor = true;
            this.cmdTraCuu.Click += new System.EventHandler(this.cmdTraCuu_Click);
            // 
            // optNgayLapPhieu
            // 
            this.optNgayLapPhieu.AutoSize = true;
            this.optNgayLapPhieu.Checked = true;
            this.optNgayLapPhieu.Location = new System.Drawing.Point(20, 40);
            this.optNgayLapPhieu.Name = "optNgayLapPhieu";
            this.optNgayLapPhieu.Size = new System.Drawing.Size(123, 20);
            this.optNgayLapPhieu.TabIndex = 62;
            this.optNgayLapPhieu.TabStop = true;
            this.optNgayLapPhieu.Text = "Ngày lập phiếu";
            this.optNgayLapPhieu.UseVisualStyleBackColor = true;
            // 
            // optNgayHenTra
            // 
            this.optNgayHenTra.AutoSize = true;
            this.optNgayHenTra.Location = new System.Drawing.Point(170, 40);
            this.optNgayHenTra.Name = "optNgayHenTra";
            this.optNgayHenTra.Size = new System.Drawing.Size(112, 20);
            this.optNgayHenTra.TabIndex = 63;
            this.optNgayHenTra.Text = "Ngày hẹn trả";
            this.optNgayHenTra.UseVisualStyleBackColor = true;
            // 
            // optPhieuQuaHan
            // 
            this.optPhieuQuaHan.AutoSize = true;
            this.optPhieuQuaHan.Location = new System.Drawing.Point(310, 40);
            this.optPhieuQuaHan.Name = "optPhieuQuaHan";
            this.optPhieuQuaHan.Size = new System.Drawing.Size(119, 20);
            this.optPhieuQuaHan.TabIndex = 64;
            this.optPhieuQuaHan.Text = "Phiếu quá hạn";
            this.optPhieuQuaHan.UseVisualStyleBackColor = true;
            // 
            // optTimCanBo
            // 
            this.optTimCanBo.AutoSize = true;
            this.optTimCanBo.Location = new System.Drawing.Point(590, 40);
            this.optTimCanBo.Name = "optTimCanBo";
            this.optTimCanBo.Size = new System.Drawing.Size(109, 20);
            this.optTimCanBo.TabIndex = 66;
            this.optTimCanBo.Text = "Theo cán bộ";
            this.optTimCanBo.UseVisualStyleBackColor = true;
            // 
            // optTimSoPhieu
            // 
            this.optTimSoPhieu.AutoSize = true;
            this.optTimSoPhieu.Location = new System.Drawing.Point(450, 40);
            this.optTimSoPhieu.Name = "optTimSoPhieu";
            this.optTimSoPhieu.Size = new System.Drawing.Size(119, 20);
            this.optTimSoPhieu.TabIndex = 65;
            this.optTimSoPhieu.Text = "Theo số phiếu";
            this.optTimSoPhieu.UseVisualStyleBackColor = true;
            // 
            // optTimDocGia
            // 
            this.optTimDocGia.AutoSize = true;
            this.optTimDocGia.Location = new System.Drawing.Point(710, 40);
            this.optTimDocGia.Name = "optTimDocGia";
            this.optTimDocGia.Size = new System.Drawing.Size(112, 20);
            this.optTimDocGia.TabIndex = 67;
            this.optTimDocGia.Text = "Theo độc giả";
            this.optTimDocGia.UseVisualStyleBackColor = true;
            // 
            // dgChiTiet
            // 
            this.dgChiTiet.AllowUserToAddRows = false;
            this.dgChiTiet.AllowUserToDeleteRows = false;
            this.dgChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgChiTiet.Location = new System.Drawing.Point(10, 340);
            this.dgChiTiet.Name = "dgChiTiet";
            this.dgChiTiet.ReadOnly = true;
            this.dgChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChiTiet.Size = new System.Drawing.Size(960, 160);
            this.dgChiTiet.TabIndex = 68;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SoPhieu";
            this.Column10.HeaderText = "";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.Width = 5;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MaSach";
            this.Column11.HeaderText = "Mã Sách";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column11.Width = 120;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TenSach";
            this.Column12.HeaderText = "Tên Sách";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 250;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "NgayTra";
            this.Column13.HeaderText = "Ngày Trả";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 120;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "TinhTrang";
            this.Column14.HeaderText = "Tình Trạng";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 150;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "GhiChu";
            this.Column15.HeaderText = "Ghi Chú";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 250;
            // 
            // chkPhieuKetThuc
            // 
            this.chkPhieuKetThuc.AutoSize = true;
            this.chkPhieuKetThuc.Checked = true;
            this.chkPhieuKetThuc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPhieuKetThuc.Location = new System.Drawing.Point(450, 10);
            this.chkPhieuKetThuc.Name = "chkPhieuKetThuc";
            this.chkPhieuKetThuc.Size = new System.Drawing.Size(280, 20);
            this.chkPhieuKetThuc.TabIndex = 69;
            this.chkPhieuKetThuc.Text = "Không tìm kiếm trên phiếu đã kết thúc";
            this.chkPhieuKetThuc.UseVisualStyleBackColor = true;
            // 
            // cmdInPhieu
            // 
            this.cmdInPhieu.Location = new System.Drawing.Point(640, 70);
            this.cmdInPhieu.Name = "cmdInPhieu";
            this.cmdInPhieu.Size = new System.Drawing.Size(180, 30);
            this.cmdInPhieu.TabIndex = 70;
            this.cmdInPhieu.Text = "In phiếu mượn";
            this.cmdInPhieu.UseVisualStyleBackColor = true;
            this.cmdInPhieu.Click += new System.EventHandler(this.cmdInPhieu_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(10, 314);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(13, 16);
            this.lblThongBao.TabIndex = 71;
            this.lblThongBao.Text = ".";
            // 
            // frmQLPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 510);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.cmdInPhieu);
            this.Controls.Add(this.chkPhieuKetThuc);
            this.Controls.Add(this.dgChiTiet);
            this.Controls.Add(this.optTimDocGia);
            this.Controls.Add(this.optTimCanBo);
            this.Controls.Add(this.optTimSoPhieu);
            this.Controls.Add(this.optPhieuQuaHan);
            this.Controls.Add(this.optNgayHenTra);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.optNgayLapPhieu);
            this.Controls.Add(this.dgPhieu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmdKetThuc);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.cmdTraCuu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDenNgay);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQLPhieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phiếu Trả Sách";
            this.Load += new System.EventHandler(this.frmQLPhieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdKetThuc;
        private System.Windows.Forms.Button cmdTraCuu;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgPhieu;
        private System.Windows.Forms.RadioButton optNgayLapPhieu;
        private System.Windows.Forms.RadioButton optNgayHenTra;
        private System.Windows.Forms.RadioButton optPhieuQuaHan;
        private System.Windows.Forms.RadioButton optTimCanBo;
        private System.Windows.Forms.RadioButton optTimSoPhieu;
        private System.Windows.Forms.RadioButton optTimDocGia;
        private System.Windows.Forms.DataGridView dgChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.CheckBox chkPhieuKetThuc;
        private System.Windows.Forms.Button cmdInPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        internal System.Windows.Forms.Label lblThongBao;
    }
}