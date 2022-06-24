
namespace BaoCaoNhom2
{
    partial class frmRepass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepass));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.lblKeo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbAn = new System.Windows.Forms.PictureBox();
            this.txtOPass = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboRemember = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChange = new BoTronButton.DesignButton();
            this.btnBack = new BoTronButton.DesignButton();
            this.txtNPass = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAn)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // lblErro
            // 
            this.lblErro.BackColor = System.Drawing.Color.Transparent;
            this.lblErro.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(3, 277);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(284, 20);
            this.lblErro.TabIndex = 7;
            this.lblErro.Text = "Lỗi!";
            this.lblErro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKeo
            // 
            this.lblKeo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKeo.AutoSize = true;
            this.lblKeo.BackColor = System.Drawing.Color.White;
            this.lblKeo.ForeColor = System.Drawing.Color.Transparent;
            this.lblKeo.Location = new System.Drawing.Point(870, 0);
            this.lblKeo.Name = "lblKeo";
            this.lblKeo.Size = new System.Drawing.Size(70, 17);
            this.lblKeo.TabIndex = 15;
            this.lblKeo.Text = "Kéo forrm";
            this.lblKeo.Click += new System.EventHandler(this.lblKeo_Click);
            this.lblKeo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblKeo_MouseDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblErro, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtNPass, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(461, 239);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 304);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNhapLai);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(452, 52);
            this.panel3.TabIndex = 16;
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtNhapLai.Location = new System.Drawing.Point(4, 11);
            this.txtNhapLai.Multiline = true;
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.PasswordChar = '●';
            this.txtNhapLai.Size = new System.Drawing.Size(393, 25);
            this.txtNhapLai.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nhập lại mật khẩu mới:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ptbAn);
            this.panel2.Controls.Add(this.txtOPass);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 46);
            this.panel2.TabIndex = 15;
            // 
            // ptbAn
            // 
            this.ptbAn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ptbAn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ptbAn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbAn.Image = ((System.Drawing.Image)(resources.GetObject("ptbAn.Image")));
            this.ptbAn.Location = new System.Drawing.Point(403, 8);
            this.ptbAn.Name = "ptbAn";
            this.ptbAn.Size = new System.Drawing.Size(39, 25);
            this.ptbAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbAn.TabIndex = 8;
            this.ptbAn.TabStop = false;
            this.ptbAn.Click += new System.EventHandler(this.ptbAn_Click);
            // 
            // txtOPass
            // 
            this.txtOPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOPass.Location = new System.Drawing.Point(4, 8);
            this.txtOPass.Multiline = true;
            this.txtOPass.Name = "txtOPass";
            this.txtOPass.PasswordChar = '●';
            this.txtOPass.Size = new System.Drawing.Size(393, 25);
            this.txtOPass.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnChange, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBack, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cboRemember, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(476, 596);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(419, 131);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // cboRemember
            // 
            this.cboRemember.AutoSize = true;
            this.cboRemember.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRemember.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cboRemember.Location = new System.Drawing.Point(3, 3);
            this.cboRemember.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.cboRemember.Name = "cboRemember";
            this.cboRemember.Size = new System.Drawing.Size(194, 22);
            this.cboRemember.TabIndex = 7;
            this.cboRemember.Text = "Remember new password.";
            this.cboRemember.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(931, 785);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnChange
            // 
            this.btnChange.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChange.BackColor = System.Drawing.Color.HotPink;
            this.btnChange.BackgroundColor = System.Drawing.Color.HotPink;
            this.btnChange.BorderColer = System.Drawing.Color.PaleVioletRed;
            this.btnChange.BorderRadius = 40;
            this.btnChange.BorderSize = 0;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(30, 69);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(136, 59);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Change";
            this.btnChange.TextColor = System.Drawing.Color.White;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.HotPink;
            this.btnBack.BackgroundColor = System.Drawing.Color.HotPink;
            this.btnBack.BorderColer = System.Drawing.Color.PaleVioletRed;
            this.btnBack.BorderRadius = 40;
            this.btnBack.BorderSize = 0;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(240, 69);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 59);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtNPass
            // 
            this.txtNPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNPass.Location = new System.Drawing.Point(3, 138);
            this.txtNPass.Multiline = true;
            this.txtNPass.Name = "txtNPass";
            this.txtNPass.PasswordChar = '●';
            this.txtNPass.Size = new System.Drawing.Size(393, 25);
            this.txtNPass.TabIndex = 17;
            // 
            // Repass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 785);
            this.Controls.Add(this.lblKeo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Repass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repass";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAn)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label lblKeo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbAn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private BoTronButton.DesignButton btnChange;
        private BoTronButton.DesignButton btnBack;
        private System.Windows.Forms.CheckBox cboRemember;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtOPass;
        private System.Windows.Forms.TextBox txtNPass;
    }
}