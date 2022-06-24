namespace Bai001_Frm
{
    partial class FrmTinhToan
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.cmdCong = new System.Windows.Forms.Button();
            this.cmdTru = new System.Windows.Forms.Button();
            this.cmdNhan = new System.Windows.Forms.Button();
            this.cmdChia = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính Toán Số Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số thứ nhất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập số thứ hai:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(247, 102);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(339, 27);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(247, 157);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(339, 27);
            this.txtB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kết quả tính toán:";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(247, 208);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(339, 27);
            this.txtKQ.TabIndex = 6;
            // 
            // cmdCong
            // 
            this.cmdCong.Location = new System.Drawing.Point(247, 262);
            this.cmdCong.Name = "cmdCong";
            this.cmdCong.Size = new System.Drawing.Size(54, 56);
            this.cmdCong.TabIndex = 11;
            this.cmdCong.Text = "+";
            this.cmdCong.UseVisualStyleBackColor = true;
            this.cmdCong.Click += new System.EventHandler(this.cmdCong_Click);
            // 
            // cmdTru
            // 
            this.cmdTru.Location = new System.Drawing.Point(323, 262);
            this.cmdTru.Name = "cmdTru";
            this.cmdTru.Size = new System.Drawing.Size(54, 56);
            this.cmdTru.TabIndex = 12;
            this.cmdTru.Text = "-";
            this.cmdTru.UseVisualStyleBackColor = true;
            this.cmdTru.Click += new System.EventHandler(this.cmdTru_Click);
            // 
            // cmdNhan
            // 
            this.cmdNhan.Location = new System.Drawing.Point(393, 262);
            this.cmdNhan.Name = "cmdNhan";
            this.cmdNhan.Size = new System.Drawing.Size(54, 56);
            this.cmdNhan.TabIndex = 13;
            this.cmdNhan.Text = "*";
            this.cmdNhan.UseVisualStyleBackColor = true;
            this.cmdNhan.Click += new System.EventHandler(this.cmdNhan_Click);
            // 
            // cmdChia
            // 
            this.cmdChia.Location = new System.Drawing.Point(463, 262);
            this.cmdChia.Name = "cmdChia";
            this.cmdChia.Size = new System.Drawing.Size(54, 56);
            this.cmdChia.TabIndex = 14;
            this.cmdChia.Text = "/";
            this.cmdChia.UseVisualStyleBackColor = true;
            this.cmdChia.Click += new System.EventHandler(this.cmdChia_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(532, 262);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(54, 56);
            this.cmdXoa.TabIndex = 15;
            this.cmdXoa.Text = "C";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdThoat
            // 
            this.cmdThoat.Location = new System.Drawing.Point(69, 262);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.Size = new System.Drawing.Size(74, 56);
            this.cmdThoat.TabIndex = 16;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.UseVisualStyleBackColor = true;
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // FrmTinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 479);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdChia);
            this.Controls.Add(this.cmdNhan);
            this.Controls.Add(this.cmdTru);
            this.Controls.Add(this.cmdCong);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmTinhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương Trình Toán Số Học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTinhToan_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button cmdCong;
        private System.Windows.Forms.Button cmdTru;
        private System.Windows.Forms.Button cmdNhan;
        private System.Windows.Forms.Button cmdChia;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdThoat;
    }
}

