namespace QLThuVien
{
    partial class frmSach
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboTacGia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdKetThuc = new System.Windows.Forms.Button();
            this.cmdKhong = new System.Windows.Forms.Button();
            this.cmdGhi = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdThem = new System.Windows.Forms.Button();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgDanhSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboNhaXB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMuonTra = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboChuyenMuc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboFTinhTrang = new System.Windows.Forms.ComboBox();
            this.cboFMuonTra = new System.Windows.Forms.ComboBox();
            this.cmdInDS = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(90, 10);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(160, 23);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tìm kiếm :";
            // 
            // cboTacGia
            // 
            this.cboTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTacGia.FormattingEnabled = true;
            this.cboTacGia.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cboTacGia.Location = new System.Drawing.Point(90, 450);
            this.cboTacGia.Name = "cboTacGia";
            this.cboTacGia.Size = new System.Drawing.Size(270, 24);
            this.cboTacGia.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tác giả :";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(470, 420);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(270, 23);
            this.txtNoiDung.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nội dung : ";
            // 
            // cmdKetThuc
            // 
            this.cmdKetThuc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKetThuc.Location = new System.Drawing.Point(860, 475);
            this.cmdKetThuc.Name = "cmdKetThuc";
            this.cmdKetThuc.Size = new System.Drawing.Size(100, 30);
            this.cmdKetThuc.TabIndex = 27;
            this.cmdKetThuc.Text = "Kết thúc";
            this.cmdKetThuc.UseVisualStyleBackColor = true;
            this.cmdKetThuc.Click += new System.EventHandler(this.cmdKetThuc_Click);
            // 
            // cmdKhong
            // 
            this.cmdKhong.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKhong.Location = new System.Drawing.Point(860, 435);
            this.cmdKhong.Name = "cmdKhong";
            this.cmdKhong.Size = new System.Drawing.Size(100, 30);
            this.cmdKhong.TabIndex = 26;
            this.cmdKhong.Text = "Không ghi";
            this.cmdKhong.UseVisualStyleBackColor = true;
            this.cmdKhong.Click += new System.EventHandler(this.cmdKhong_Click);
            // 
            // cmdGhi
            // 
            this.cmdGhi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGhi.Location = new System.Drawing.Point(860, 395);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(100, 30);
            this.cmdGhi.TabIndex = 25;
            this.cmdGhi.Text = "Ghi";
            this.cmdGhi.UseVisualStyleBackColor = true;
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSua.Location = new System.Drawing.Point(750, 435);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(100, 30);
            this.cmdSua.TabIndex = 23;
            this.cmdSua.Text = "Cập nhật";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdXoa.Location = new System.Drawing.Point(750, 475);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(100, 30);
            this.cmdXoa.TabIndex = 24;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdThem.Location = new System.Drawing.Point(750, 395);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(100, 30);
            this.cmdThem.TabIndex = 22;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(470, 390);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(270, 23);
            this.txtViTri.TabIndex = 15;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(380, 390);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 16);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Vị trí sách :";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(90, 390);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(270, 23);
            this.txtTenSach.TabIndex = 7;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(10, 390);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Tên sách :";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(90, 360);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(270, 23);
            this.txtMaSach.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 360);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(74, 16);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Mã sách :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(270, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(296, 25);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "QUẢN LÝ DANH MỤC SÁCH";
            // 
            // dgDanhSach
            // 
            this.dgDanhSach.AllowUserToAddRows = false;
            this.dgDanhSach.AllowUserToDeleteRows = false;
            this.dgDanhSach.ColumnHeadersHeight = 30;
            this.dgDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgDanhSach.Location = new System.Drawing.Point(10, 40);
            this.dgDanhSach.MultiSelect = false;
            this.dgDanhSach.Name = "dgDanhSach";
            this.dgDanhSach.ReadOnly = true;
            this.dgDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDanhSach.Size = new System.Drawing.Size(950, 310);
            this.dgDanhSach.TabIndex = 3;
            this.dgDanhSach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDanhSach_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSach";
            this.Column1.HeaderText = "Mã Sách";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSach";
            this.Column2.HeaderText = "Tên Sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenMuc";
            this.Column3.HeaderText = "Thể Loại";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenTG";
            this.Column4.HeaderText = "Tác Giả";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenNXB";
            this.Column5.HeaderText = "Nhà XB";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ViTri";
            this.Column6.HeaderText = "Vị Trí";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NoiDung";
            this.Column7.HeaderText = "Nội Dung";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DaChoMuon";
            this.Column8.HeaderText = "Cho Mượn";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "DaBiHong";
            this.Column9.HeaderText = "Bị Hỏng";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 150;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "MaMuc";
            this.Column10.HeaderText = "Mục";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.Width = 5;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MaTG";
            this.Column11.HeaderText = "Tác Giả";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column11.Width = 5;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "MaNXB";
            this.Column12.HeaderText = "NXB";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column12.Width = 5;
            // 
            // cboNhaXB
            // 
            this.cboNhaXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaXB.FormattingEnabled = true;
            this.cboNhaXB.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cboNhaXB.Location = new System.Drawing.Point(90, 480);
            this.cboNhaXB.Name = "cboNhaXB";
            this.cboNhaXB.Size = new System.Drawing.Size(270, 24);
            this.cboNhaXB.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhà XB : ";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Vẫn bình thường",
            "Đã bị hỏng"});
            this.cboTinhTrang.Location = new System.Drawing.Point(470, 480);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(270, 24);
            this.cboTinhTrang.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tình trạng :";
            // 
            // cboMuonTra
            // 
            this.cboMuonTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMuonTra.FormattingEnabled = true;
            this.cboMuonTra.Items.AddRange(new object[] {
            "Chưa cho mượn",
            "Đã cho mượn"});
            this.cboMuonTra.Location = new System.Drawing.Point(470, 450);
            this.cboMuonTra.Name = "cboMuonTra";
            this.cboMuonTra.Size = new System.Drawing.Size(270, 24);
            this.cboMuonTra.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mượn/trả : ";
            // 
            // cboChuyenMuc
            // 
            this.cboChuyenMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenMuc.FormattingEnabled = true;
            this.cboChuyenMuc.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cboChuyenMuc.Location = new System.Drawing.Point(90, 420);
            this.cboChuyenMuc.Name = "cboChuyenMuc";
            this.cboChuyenMuc.Size = new System.Drawing.Size(270, 24);
            this.cboChuyenMuc.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Thể loại :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(580, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Lọc sách :";
            // 
            // cboFTinhTrang
            // 
            this.cboFTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFTinhTrang.FormattingEnabled = true;
            this.cboFTinhTrang.Items.AddRange(new object[] {
            "Hiện toàn bộ",
            "Chỉ sách bình thương",
            "Chỉ sách bị hỏng"});
            this.cboFTinhTrang.Location = new System.Drawing.Point(810, 10);
            this.cboFTinhTrang.Name = "cboFTinhTrang";
            this.cboFTinhTrang.Size = new System.Drawing.Size(150, 24);
            this.cboFTinhTrang.TabIndex = 29;
            this.cboFTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cboFTinhTrang_SelectedIndexChanged);
            // 
            // cboFMuonTra
            // 
            this.cboFMuonTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFMuonTra.FormattingEnabled = true;
            this.cboFMuonTra.Items.AddRange(new object[] {
            "Hiện toàn bộ",
            "Sách chưa cho mượn",
            "Sách đã cho mượn"});
            this.cboFMuonTra.Location = new System.Drawing.Point(660, 10);
            this.cboFMuonTra.Name = "cboFMuonTra";
            this.cboFMuonTra.Size = new System.Drawing.Size(140, 24);
            this.cboFMuonTra.TabIndex = 30;
            this.cboFMuonTra.SelectedIndexChanged += new System.EventHandler(this.cboFMuonTra_SelectedIndexChanged);
            // 
            // cmdInDS
            // 
            this.cmdInDS.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInDS.Location = new System.Drawing.Point(750, 360);
            this.cmdInDS.Name = "cmdInDS";
            this.cmdInDS.Size = new System.Drawing.Size(210, 25);
            this.cmdInDS.TabIndex = 32;
            this.cmdInDS.Text = "In danh sách";
            this.cmdInDS.UseVisualStyleBackColor = true;
            this.cmdInDS.Click += new System.EventHandler(this.cmdInDS_Click);
            // 
            // lblThongBao
            // 
            this.lblThongBao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(470, 360);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(276, 20);
            this.lblThongBao.TabIndex = 35;
            this.lblThongBao.Text = ".";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 521);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.cmdInDS);
            this.Controls.Add(this.cboFMuonTra);
            this.Controls.Add(this.cboFTinhTrang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboChuyenMuc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboMuonTra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboNhaXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboTacGia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdKetThuc);
            this.Controls.Add(this.cmdKhong);
            this.Controls.Add(this.cmdGhi);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dgDanhSach);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Danh Mục Sách";
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtTimKiem;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboTacGia;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtNoiDung;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Button cmdKetThuc;
        internal System.Windows.Forms.Button cmdKhong;
        internal System.Windows.Forms.Button cmdGhi;
        internal System.Windows.Forms.Button cmdSua;
        internal System.Windows.Forms.Button cmdXoa;
        internal System.Windows.Forms.Button cmdThem;
        internal System.Windows.Forms.TextBox txtViTri;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtTenSach;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtMaSach;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dgDanhSach;
        private System.Windows.Forms.ComboBox cboNhaXB;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMuonTra;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboChuyenMuc;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboFTinhTrang;
        private System.Windows.Forms.ComboBox cboFMuonTra;
        internal System.Windows.Forms.Button cmdInDS;
        internal System.Windows.Forms.Label lblThongBao;
    }
}