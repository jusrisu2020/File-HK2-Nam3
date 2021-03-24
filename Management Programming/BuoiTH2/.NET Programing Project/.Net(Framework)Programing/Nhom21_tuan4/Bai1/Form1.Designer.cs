namespace bai1
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
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSXGiam = new System.Windows.Forms.Button();
            this.btnSXTang = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnSLN = new System.Windows.Forms.Button();
            this.btnSNN = new System.Windows.Forms.Button();
            this.btnTBMang = new System.Windows.Forms.Button();
            this.btnUCLN = new System.Windows.Forms.Button();
            this.btnSoHoanHao = new System.Windows.Forms.Button();
            this.btnSoNguyenTo = new System.Windows.Forms.Button();
            this.btnDSLe = new System.Windows.Forms.Button();
            this.btnDSChan = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(12, 12);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(123, 38);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập 1 phần tử";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(141, 22);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(105, 20);
            this.txtNhap.TabIndex = 1;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(252, 12);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(87, 38);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(345, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 38);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(435, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 38);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnSXGiam
            // 
            this.btnSXGiam.Location = new System.Drawing.Point(435, 56);
            this.btnSXGiam.Name = "btnSXGiam";
            this.btnSXGiam.Size = new System.Drawing.Size(99, 38);
            this.btnSXGiam.TabIndex = 5;
            this.btnSXGiam.Text = "Sắp xếp giảm";
            this.btnSXGiam.UseVisualStyleBackColor = true;
            this.btnSXGiam.Click += new System.EventHandler(this.btnSXGiam_Click);
            // 
            // btnSXTang
            // 
            this.btnSXTang.Location = new System.Drawing.Point(435, 100);
            this.btnSXTang.Name = "btnSXTang";
            this.btnSXTang.Size = new System.Drawing.Size(99, 38);
            this.btnSXTang.TabIndex = 6;
            this.btnSXTang.Text = "Sắp xếp tăng";
            this.btnSXTang.UseVisualStyleBackColor = true;
            this.btnSXTang.Click += new System.EventHandler(this.btnSXTang_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(435, 144);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(99, 38);
            this.btnTong.TabIndex = 7;
            this.btnTong.Text = "Tổng mảng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnSLN
            // 
            this.btnSLN.Location = new System.Drawing.Point(435, 188);
            this.btnSLN.Name = "btnSLN";
            this.btnSLN.Size = new System.Drawing.Size(99, 38);
            this.btnSLN.TabIndex = 8;
            this.btnSLN.Text = "Số lớn nhất";
            this.btnSLN.UseVisualStyleBackColor = true;
            this.btnSLN.Click += new System.EventHandler(this.btnSLN_Click);
            // 
            // btnSNN
            // 
            this.btnSNN.Location = new System.Drawing.Point(308, 188);
            this.btnSNN.Name = "btnSNN";
            this.btnSNN.Size = new System.Drawing.Size(121, 38);
            this.btnSNN.TabIndex = 9;
            this.btnSNN.Text = "Số nhỏ nhất";
            this.btnSNN.UseVisualStyleBackColor = true;
            this.btnSNN.Click += new System.EventHandler(this.btnSNN_Click);
            // 
            // btnTBMang
            // 
            this.btnTBMang.Location = new System.Drawing.Point(178, 188);
            this.btnTBMang.Name = "btnTBMang";
            this.btnTBMang.Size = new System.Drawing.Size(124, 38);
            this.btnTBMang.TabIndex = 10;
            this.btnTBMang.Text = "Trung bình mảng";
            this.btnTBMang.UseVisualStyleBackColor = true;
            this.btnTBMang.Click += new System.EventHandler(this.btnTBMang_Click_1);
            // 
            // btnUCLN
            // 
            this.btnUCLN.Location = new System.Drawing.Point(12, 188);
            this.btnUCLN.Name = "btnUCLN";
            this.btnUCLN.Size = new System.Drawing.Size(160, 38);
            this.btnUCLN.TabIndex = 11;
            this.btnUCLN.Text = "UCLN 2 phần tử đầu tiên";
            this.btnUCLN.UseVisualStyleBackColor = true;
            this.btnUCLN.Click += new System.EventHandler(this.btnUCLN_Click_1);
            // 
            // btnSoHoanHao
            // 
            this.btnSoHoanHao.Location = new System.Drawing.Point(330, 144);
            this.btnSoHoanHao.Name = "btnSoHoanHao";
            this.btnSoHoanHao.Size = new System.Drawing.Size(99, 38);
            this.btnSoHoanHao.TabIndex = 12;
            this.btnSoHoanHao.Text = "Số hoàn hảo";
            this.btnSoHoanHao.UseVisualStyleBackColor = true;
            this.btnSoHoanHao.Click += new System.EventHandler(this.btnSoHoanHao_Click);
            // 
            // btnSoNguyenTo
            // 
            this.btnSoNguyenTo.Location = new System.Drawing.Point(225, 144);
            this.btnSoNguyenTo.Name = "btnSoNguyenTo";
            this.btnSoNguyenTo.Size = new System.Drawing.Size(99, 38);
            this.btnSoNguyenTo.TabIndex = 13;
            this.btnSoNguyenTo.Text = "Số nguyên tố";
            this.btnSoNguyenTo.UseVisualStyleBackColor = true;
            this.btnSoNguyenTo.Click += new System.EventHandler(this.btnSoNguyenTo_Click);
            // 
            // btnDSLe
            // 
            this.btnDSLe.Location = new System.Drawing.Point(120, 144);
            this.btnDSLe.Name = "btnDSLe";
            this.btnDSLe.Size = new System.Drawing.Size(99, 38);
            this.btnDSLe.TabIndex = 14;
            this.btnDSLe.Text = "Đếm số lẻ";
            this.btnDSLe.UseVisualStyleBackColor = true;
            this.btnDSLe.Click += new System.EventHandler(this.btnDSLe_Click);
            // 
            // btnDSChan
            // 
            this.btnDSChan.Location = new System.Drawing.Point(12, 144);
            this.btnDSChan.Name = "btnDSChan";
            this.btnDSChan.Size = new System.Drawing.Size(102, 38);
            this.btnDSChan.TabIndex = 15;
            this.btnDSChan.Text = "Đếm số chẵn";
            this.btnDSChan.UseVisualStyleBackColor = true;
            this.btnDSChan.Click += new System.EventHandler(this.btnDSChan_Click_1);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblKQ.Location = new System.Drawing.Point(12, 56);
            this.lblKQ.MinimumSize = new System.Drawing.Size(415, 80);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(415, 80);
            this.lblKQ.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 241);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btnDSChan);
            this.Controls.Add(this.btnDSLe);
            this.Controls.Add(this.btnSoNguyenTo);
            this.Controls.Add(this.btnSoHoanHao);
            this.Controls.Add(this.btnUCLN);
            this.Controls.Add(this.btnTBMang);
            this.Controls.Add(this.btnSNN);
            this.Controls.Add(this.btnSLN);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnSXTang);
            this.Controls.Add(this.btnSXGiam);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.btnNhap);
            this.Name = "Form1";
            this.Text = "Mảng Nguyên Tố";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSXGiam;
        private System.Windows.Forms.Button btnSXTang;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnSLN;
        private System.Windows.Forms.Button btnSNN;
        private System.Windows.Forms.Button btnTBMang;
        private System.Windows.Forms.Button btnUCLN;
        private System.Windows.Forms.Button btnSoHoanHao;
        private System.Windows.Forms.Button btnSoNguyenTo;
        private System.Windows.Forms.Button btnDSLe;
        private System.Windows.Forms.Button btnDSChan;
        private System.Windows.Forms.Label lblKQ;
    }
}

