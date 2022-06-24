namespace Demo
{
    partial class frmTinhTienDien
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.cmd_Cong = new System.Windows.Forms.Button();
            this.cmd_Chia = new System.Windows.Forms.Button();
            this.cmd_Nhan = new System.Windows.Forms.Button();
            this.cmd_Tru = new System.Windows.Forms.Button();
            this.cmd_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính  toán số học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết quả :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập số B :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập số A :";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(192, 96);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(248, 27);
            this.txtA.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(192, 144);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(248, 27);
            this.txtB.TabIndex = 5;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Location = new System.Drawing.Point(192, 192);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(248, 56);
            this.txtKetQua.TabIndex = 6;
            // 
            // cmd_Cong
            // 
            this.cmd_Cong.Location = new System.Drawing.Point(96, 264);
            this.cmd_Cong.Name = "cmd_Cong";
            this.cmd_Cong.Size = new System.Drawing.Size(80, 32);
            this.cmd_Cong.TabIndex = 7;
            this.cmd_Cong.Text = "+";
            this.cmd_Cong.UseVisualStyleBackColor = true;
            this.cmd_Cong.Click += new System.EventHandler(this.cmd_Cong_Click);
            // 
            // cmd_Chia
            // 
            this.cmd_Chia.Location = new System.Drawing.Point(360, 264);
            this.cmd_Chia.Name = "cmd_Chia";
            this.cmd_Chia.Size = new System.Drawing.Size(80, 32);
            this.cmd_Chia.TabIndex = 8;
            this.cmd_Chia.Text = "/";
            this.cmd_Chia.UseVisualStyleBackColor = true;
            this.cmd_Chia.Click += new System.EventHandler(this.cmd_Chia_Click);
            // 
            // cmd_Nhan
            // 
            this.cmd_Nhan.Location = new System.Drawing.Point(272, 264);
            this.cmd_Nhan.Name = "cmd_Nhan";
            this.cmd_Nhan.Size = new System.Drawing.Size(80, 32);
            this.cmd_Nhan.TabIndex = 9;
            this.cmd_Nhan.Text = "*";
            this.cmd_Nhan.UseVisualStyleBackColor = true;
            this.cmd_Nhan.Click += new System.EventHandler(this.cmd_Nhan_Click);
            // 
            // cmd_Tru
            // 
            this.cmd_Tru.Location = new System.Drawing.Point(184, 264);
            this.cmd_Tru.Name = "cmd_Tru";
            this.cmd_Tru.Size = new System.Drawing.Size(80, 32);
            this.cmd_Tru.TabIndex = 10;
            this.cmd_Tru.Text = "-";
            this.cmd_Tru.UseVisualStyleBackColor = true;
            this.cmd_Tru.Click += new System.EventHandler(this.cmd_Tru_Click);
            // 
            // cmd_Thoat
            // 
            this.cmd_Thoat.Location = new System.Drawing.Point(8, 264);
            this.cmd_Thoat.Name = "cmd_Thoat";
            this.cmd_Thoat.Size = new System.Drawing.Size(80, 32);
            this.cmd_Thoat.TabIndex = 11;
            this.cmd_Thoat.Text = "Thoát";
            this.cmd_Thoat.UseVisualStyleBackColor = true;
            this.cmd_Thoat.Click += new System.EventHandler(this.cmd_Thoat_Click);
            // 
            // frmTinhTienDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 361);
            this.Controls.Add(this.cmd_Thoat);
            this.Controls.Add(this.cmd_Tru);
            this.Controls.Add(this.cmd_Nhan);
            this.Controls.Add(this.cmd_Chia);
            this.Controls.Add(this.cmd_Cong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmTinhTienDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính Toán Số Học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTinhTienDien_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button cmd_Cong;
        private System.Windows.Forms.Button cmd_Chia;
        private System.Windows.Forms.Button cmd_Nhan;
        private System.Windows.Forms.Button cmd_Tru;
        private System.Windows.Forms.Button cmd_Thoat;
    }
}

