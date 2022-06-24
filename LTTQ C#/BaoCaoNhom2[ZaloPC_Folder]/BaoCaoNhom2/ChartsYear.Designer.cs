﻿
namespace BaoCaoNhom2.DoanhThuFull
{
    partial class ChartsYear
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new BoTronButton.DesignButton();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDoanhThuMin = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDoanhThuMax = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblYearMin = new System.Windows.Forms.Label();
            this.lblTop1Year = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chtDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tổng doanh thu theo tháng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.dtpKetThuc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpBatDau);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(80, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1078, 99);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.BorderColer = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BorderRadius = 40;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(881, 33);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(150, 40);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetThuc.Location = new System.Drawing.Point(552, 40);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(200, 22);
            this.dtpKetThuc.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Từ";
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBatDau.Location = new System.Drawing.Point(230, 40);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(200, 22);
            this.dtpBatDau.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm kiếm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "+ Năm có doanh thu thấp nhất:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblDoanhThuMin);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblDoanhThuMax);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblYearMin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTop1Year);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(606, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 271);
            this.panel1.TabIndex = 10;
            // 
            // lblDoanhThuMin
            // 
            this.lblDoanhThuMin.AutoSize = true;
            this.lblDoanhThuMin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDoanhThuMin.ForeColor = System.Drawing.Color.White;
            this.lblDoanhThuMin.Location = new System.Drawing.Point(374, 200);
            this.lblDoanhThuMin.Name = "lblDoanhThuMin";
            this.lblDoanhThuMin.Size = new System.Drawing.Size(50, 21);
            this.lblDoanhThuMin.TabIndex = 9;
            this.lblDoanhThuMin.Text = "........";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(158, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Có mức doanh thu:";
            // 
            // lblDoanhThuMax
            // 
            this.lblDoanhThuMax.AutoSize = true;
            this.lblDoanhThuMax.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDoanhThuMax.ForeColor = System.Drawing.Color.White;
            this.lblDoanhThuMax.Location = new System.Drawing.Point(374, 91);
            this.lblDoanhThuMax.Name = "lblDoanhThuMax";
            this.lblDoanhThuMax.Size = new System.Drawing.Size(50, 21);
            this.lblDoanhThuMax.TabIndex = 7;
            this.lblDoanhThuMax.Text = "........";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(150, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Có mức doanh thu:";
            // 
            // lblYearMin
            // 
            this.lblYearMin.AutoSize = true;
            this.lblYearMin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblYearMin.ForeColor = System.Drawing.Color.White;
            this.lblYearMin.Location = new System.Drawing.Point(373, 143);
            this.lblYearMin.Name = "lblYearMin";
            this.lblYearMin.Size = new System.Drawing.Size(102, 26);
            this.lblYearMin.TabIndex = 5;
            this.lblYearMin.Text = "...............";
            // 
            // lblTop1Year
            // 
            this.lblTop1Year.AutoSize = true;
            this.lblTop1Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTop1Year.ForeColor = System.Drawing.Color.White;
            this.lblTop1Year.Location = new System.Drawing.Point(373, 37);
            this.lblTop1Year.Name = "lblTop1Year";
            this.lblTop1Year.Size = new System.Drawing.Size(118, 29);
            this.lblTop1Year.TabIndex = 3;
            this.lblTop1Year.Text = "...............";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "+ Năm có doanh thu cao nhất:";
            // 
            // chtDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chtDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtDoanhThu.Legends.Add(legend1);
            this.chtDoanhThu.Location = new System.Drawing.Point(55, 315);
            this.chtDoanhThu.Name = "chtDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            this.chtDoanhThu.Series.Add(series1);
            this.chtDoanhThu.Size = new System.Drawing.Size(531, 274);
            this.chtDoanhThu.TabIndex = 8;
            this.chtDoanhThu.Text = "chart1";
            // 
            // ChartsYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 795);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chtDoanhThu);
            this.Name = "ChartsYear";
            this.Text = "ChartsYear";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private BoTronButton.DesignButton btnTimKiem;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDoanhThuMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDoanhThuMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblYearMin;
        private System.Windows.Forms.Label lblTop1Year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtDoanhThu;
    }
}