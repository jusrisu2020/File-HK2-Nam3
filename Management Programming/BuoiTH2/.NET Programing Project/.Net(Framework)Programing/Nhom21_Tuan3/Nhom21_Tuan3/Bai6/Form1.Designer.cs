namespace Bai6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhapChuoi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lstChuoi = new System.Windows.Forms.ListBox();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnMN = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhapChuoi);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập chuỗi";
            // 
            // txtNhapChuoi
            // 
            this.txtNhapChuoi.Location = new System.Drawing.Point(8, 19);
            this.txtNhapChuoi.Name = "txtNhapChuoi";
            this.txtNhapChuoi.Size = new System.Drawing.Size(164, 20);
            this.txtNhapChuoi.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(8, 57);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(103, 57);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lstChuoi
            // 
            this.lstChuoi.FormattingEnabled = true;
            this.lstChuoi.Location = new System.Drawing.Point(8, 95);
            this.lstChuoi.Name = "lstChuoi";
            this.lstChuoi.Size = new System.Drawing.Size(170, 95);
            this.lstChuoi.TabIndex = 3;
            // 
            // txtHienThi
            // 
            this.txtHienThi.Location = new System.Drawing.Point(184, 0);
            this.txtHienThi.Multiline = true;
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.Size = new System.Drawing.Size(250, 80);
            this.txtHienThi.TabIndex = 4;
            // 
            // btnMC
            // 
            this.btnMC.Location = new System.Drawing.Point(197, 95);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(75, 34);
            this.btnMC.TabIndex = 5;
            this.btnMC.Text = "Chọn màu chữ";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(278, 95);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 34);
            this.btnFont.TabIndex = 6;
            this.btnFont.Text = "Chọn font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnMN
            // 
            this.btnMN.Location = new System.Drawing.Point(359, 95);
            this.btnMN.Name = "btnMN";
            this.btnMN.Size = new System.Drawing.Size(75, 34);
            this.btnMN.TabIndex = 7;
            this.btnMN.Text = "Chọn màu nền";
            this.btnMN.UseVisualStyleBackColor = true;
            this.btnMN.Click += new System.EventHandler(this.btnMN_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(278, 144);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 32);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 200);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnMN);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.txtHienThi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lstChuoi);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhapChuoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox lstChuoi;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnMN;
        private System.Windows.Forms.Button btnDong;
    }
}

