namespace listView
{
    partial class frmListView
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmdNhap = new System.Windows.Forms.Button();
            this.cmdA1B = new System.Windows.Forms.Button();
            this.cmdAB = new System.Windows.Forms.Button();
            this.cmdB1A = new System.Windows.Forms.Button();
            this.cmdBA = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdKetThuc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstB = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập họ tên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 27);
            this.txtName.TabIndex = 2;
            // 
            // cmdNhap
            // 
            this.cmdNhap.Location = new System.Drawing.Point(416, 72);
            this.cmdNhap.Name = "cmdNhap";
            this.cmdNhap.Size = new System.Drawing.Size(96, 32);
            this.cmdNhap.TabIndex = 3;
            this.cmdNhap.Text = "Nhập";
            this.cmdNhap.UseVisualStyleBackColor = true;
            this.cmdNhap.Click += new System.EventHandler(this.cmdNhap_Click);
            // 
            // cmdA1B
            // 
            this.cmdA1B.Location = new System.Drawing.Point(232, 192);
            this.cmdA1B.Name = "cmdA1B";
            this.cmdA1B.Size = new System.Drawing.Size(72, 32);
            this.cmdA1B.TabIndex = 8;
            this.cmdA1B.Text = ">";
            this.cmdA1B.UseVisualStyleBackColor = true;
            this.cmdA1B.Click += new System.EventHandler(this.cmdA1B_Click);
            // 
            // cmdAB
            // 
            this.cmdAB.Location = new System.Drawing.Point(232, 240);
            this.cmdAB.Name = "cmdAB";
            this.cmdAB.Size = new System.Drawing.Size(72, 32);
            this.cmdAB.TabIndex = 9;
            this.cmdAB.Text = ">>";
            this.cmdAB.UseVisualStyleBackColor = true;
            this.cmdAB.Click += new System.EventHandler(this.cmdAB_Click);
            // 
            // cmdB1A
            // 
            this.cmdB1A.Location = new System.Drawing.Point(232, 288);
            this.cmdB1A.Name = "cmdB1A";
            this.cmdB1A.Size = new System.Drawing.Size(72, 32);
            this.cmdB1A.TabIndex = 11;
            this.cmdB1A.Text = "<";
            this.cmdB1A.UseVisualStyleBackColor = true;
            this.cmdB1A.Click += new System.EventHandler(this.cmdB1A_Click);
            // 
            // cmdBA
            // 
            this.cmdBA.Location = new System.Drawing.Point(232, 336);
            this.cmdBA.Name = "cmdBA";
            this.cmdBA.Size = new System.Drawing.Size(72, 32);
            this.cmdBA.TabIndex = 12;
            this.cmdBA.Text = "<<";
            this.cmdBA.UseVisualStyleBackColor = true;
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(56, 376);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(96, 32);
            this.cmdXoa.TabIndex = 13;
            this.cmdXoa.Text = "Xóa trắng";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdKetThuc
            // 
            this.cmdKetThuc.Location = new System.Drawing.Point(368, 376);
            this.cmdKetThuc.Name = "cmdKetThuc";
            this.cmdKetThuc.Size = new System.Drawing.Size(96, 32);
            this.cmdKetThuc.TabIndex = 14;
            this.cmdKetThuc.Text = "Kết thúc";
            this.cmdKetThuc.UseVisualStyleBackColor = true;
            this.cmdKetThuc.Click += new System.EventHandler(this.cmdKetThuc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstA);
            this.groupBox1.Location = new System.Drawing.Point(32, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 216);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.ItemHeight = 18;
            this.lstA.Items.AddRange(new object[] {
            "Nguyễn Văn A",
            "Nguyễn Văn C",
            "Nguyễn Văn D"});
            this.lstA.Location = new System.Drawing.Point(16, 32);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(144, 184);
            this.lstA.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstB);
            this.groupBox2.Location = new System.Drawing.Point(336, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 216);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // lstB
            // 
            this.lstB.FormattingEnabled = true;
            this.lstB.ItemHeight = 18;
            this.lstB.Location = new System.Drawing.Point(16, 32);
            this.lstB.Name = "lstB";
            this.lstB.Size = new System.Drawing.Size(144, 184);
            this.lstB.TabIndex = 0;
            // 
            // frmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 437);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdKetThuc);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdBA);
            this.Controls.Add(this.cmdB1A);
            this.Controls.Add(this.cmdAB);
            this.Controls.Add(this.cmdA1B);
            this.Controls.Add(this.cmdNhap);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListView";
            this.Text = "Danh sach";
            this.Load += new System.EventHandler(this.frmListView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button cmdNhap;
        private System.Windows.Forms.Button cmdA1B;
        private System.Windows.Forms.Button cmdAB;
        private System.Windows.Forms.Button cmdB1A;
        private System.Windows.Forms.Button cmdBA;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdKetThuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstB;
    }
}

