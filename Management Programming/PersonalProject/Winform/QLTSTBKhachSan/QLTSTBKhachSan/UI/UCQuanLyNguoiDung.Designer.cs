
namespace QLTSTBKhachSan.UI
{
    partial class UCQuanLyNguoiDung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCapNhatND = new System.Windows.Forms.Button();
            this.btnPhanQuyenND = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtgvQLND = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.btnThemNv = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLND)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ NGƯỜI DÙNG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnCapNhatND
            // 
            this.btnCapNhatND.Location = new System.Drawing.Point(32, 114);
            this.btnCapNhatND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatND.Name = "btnCapNhatND";
            this.btnCapNhatND.Size = new System.Drawing.Size(101, 57);
            this.btnCapNhatND.TabIndex = 2;
            this.btnCapNhatND.Text = "Create User";
            this.btnCapNhatND.UseVisualStyleBackColor = true;
            this.btnCapNhatND.Click += new System.EventHandler(this.btnCapNhatND_Click);
            // 
            // btnPhanQuyenND
            // 
            this.btnPhanQuyenND.Location = new System.Drawing.Point(164, 117);
            this.btnPhanQuyenND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhanQuyenND.Name = "btnPhanQuyenND";
            this.btnPhanQuyenND.Size = new System.Drawing.Size(163, 62);
            this.btnPhanQuyenND.TabIndex = 3;
            this.btnPhanQuyenND.Text = "User Authorization";
            this.btnPhanQuyenND.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(387, 124);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 49);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(550, 131);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(215, 22);
            this.txtTimKiem.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(781, 124);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 37);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Search...";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtgvQLND
            // 
            this.dtgvQLND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLND.Location = new System.Drawing.Point(31, 370);
            this.dtgvQLND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvQLND.Name = "dtgvQLND";
            this.dtgvQLND.ReadOnly = true;
            this.dtgvQLND.RowHeadersVisible = false;
            this.dtgvQLND.RowHeadersWidth = 51;
            this.dtgvQLND.RowTemplate.Height = 24;
            this.dtgvQLND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQLND.Size = new System.Drawing.Size(725, 208);
            this.dtgvQLND.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Location = new System.Drawing.Point(223, 196);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(173, 64);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã Nhân Viên";
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(8, 23);
            this.txtManv.Margin = new System.Windows.Forms.Padding(4);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(132, 22);
            this.txtManv.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenTK);
            this.groupBox2.Location = new System.Drawing.Point(418, 196);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(173, 64);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tên Tài Khoản";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(8, 23);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(132, 22);
            this.txtTenTK.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPass);
            this.groupBox3.Location = new System.Drawing.Point(418, 273);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(173, 64);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "pass";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(8, 23);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(132, 22);
            this.txtPass.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbTrangThai);
            this.groupBox4.Location = new System.Drawing.Point(620, 196);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(173, 64);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trangthai";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(23, 23);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(121, 24);
            this.cbTrangThai.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbChucVu);
            this.groupBox5.Location = new System.Drawing.Point(822, 196);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(173, 64);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Vụ";
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(8, 23);
            this.cbChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(140, 24);
            this.cbChucVu.TabIndex = 12;
            // 
            // btnThemNv
            // 
            this.btnThemNv.Location = new System.Drawing.Point(802, 300);
            this.btnThemNv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemNv.Name = "btnThemNv";
            this.btnThemNv.Size = new System.Drawing.Size(123, 37);
            this.btnThemNv.TabIndex = 11;
            this.btnThemNv.Text = "Thêm NV";
            this.btnThemNv.UseVisualStyleBackColor = true;
            this.btnThemNv.Click += new System.EventHandler(this.btnThemNv_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtMaTK);
            this.groupBox6.Location = new System.Drawing.Point(31, 196);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(173, 64);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Mã Tài Khoản";
            // 
            // txtMaTK
            // 
            this.txtMaTK.Enabled = false;
            this.txtMaTK.Location = new System.Drawing.Point(8, 23);
            this.txtMaTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(132, 22);
            this.txtMaTK.TabIndex = 0;
            // 
            // UCQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnThemNv);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvQLND);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPhanQuyenND);
            this.Controls.Add(this.btnCapNhatND);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCQuanLyNguoiDung";
            this.Size = new System.Drawing.Size(1200, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLND)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCapNhatND;
        private System.Windows.Forms.Button btnPhanQuyenND;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dtgvQLND;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnThemNv;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtMaTK;
    }
}
