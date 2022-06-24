namespace WFCombo
{
    partial class Form1
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdKetThuc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDanhSach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(200, 40);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(312, 27);
            this.txtHoTen.TabIndex = 1;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(200, 96);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(144, 40);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Text = "Thêm vào DS";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdKetThuc
            // 
            this.cmdKetThuc.Location = new System.Drawing.Point(368, 96);
            this.cmdKetThuc.Name = "cmdKetThuc";
            this.cmdKetThuc.Size = new System.Drawing.Size(144, 40);
            this.cmdKetThuc.TabIndex = 3;
            this.cmdKetThuc.Text = "Kết thúc";
            this.cmdKetThuc.UseVisualStyleBackColor = true;
            this.cmdKetThuc.Click += new System.EventHandler(this.cmdKetThuc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách:";
            // 
            // cboDanhSach
            // 
            this.cboDanhSach.FormattingEnabled = true;
            this.cboDanhSach.Location = new System.Drawing.Point(200, 168);
            this.cboDanhSach.Name = "cboDanhSach";
            this.cboDanhSach.Size = new System.Drawing.Size(312, 26);
            this.cboDanhSach.TabIndex = 5;
            this.cboDanhSach.SelectedIndexChanged += new System.EventHandler(this.cboDanhSach_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng số đối tượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nội dung đối tượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vị trí đối tượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dữ liệu combo (text) :";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(296, 336);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(18, 18);
            this.lblText.TabIndex = 13;
            this.lblText.Text = "_";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(296, 256);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(18, 18);
            this.lblIndex.TabIndex = 12;
            this.lblIndex.Text = "_";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(296, 296);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(18, 18);
            this.lblItem.TabIndex = 11;
            this.lblItem.Text = "_";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(296, 224);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(18, 18);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "_";
            // 
            // cmdRemove
            // 
            this.cmdRemove.Location = new System.Drawing.Point(80, 384);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(208, 32);
            this.cmdRemove.TabIndex = 14;
            this.cmdRemove.Text = "Xóa đối tượng chọn";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(344, 384);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(200, 32);
            this.cmdClear.TabIndex = 15;
            this.cmdClear.Text = "Xóa trắng danh sách";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 452);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDanhSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdKetThuc);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài Tập Combo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDanhSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.Button cmdClear;
    }
}

