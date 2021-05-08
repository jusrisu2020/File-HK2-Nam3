
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.dtgvQLND = new System.Windows.Forms.DataGridView();
            this.btnSuaTaiKhoan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbMaCV = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnShowChucVu = new System.Windows.Forms.Button();
            this.pnShowChucVu = new System.Windows.Forms.Panel();
            this.dtgvChucVu = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLND)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnShowChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ NGƯỜI DÙNG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 81);
            this.panel1.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(178, 29);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(162, 20);
            this.txtTimKiem.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(344, 24);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(64, 30);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Search...";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(102, 2);
            this.btnThemTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(76, 40);
            this.btnThemTaiKhoan.TabIndex = 2;
            this.btnThemTaiKhoan.Text = "Create User";
            this.btnThemTaiKhoan.UseVisualStyleBackColor = true;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // dtgvQLND
            // 
            this.dtgvQLND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQLND.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvQLND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvQLND.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvQLND.Location = new System.Drawing.Point(8, 13);
            this.dtgvQLND.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvQLND.Name = "dtgvQLND";
            this.dtgvQLND.ReadOnly = true;
            this.dtgvQLND.RowHeadersVisible = false;
            this.dtgvQLND.RowHeadersWidth = 100;
            this.dtgvQLND.RowTemplate.Height = 24;
            this.dtgvQLND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQLND.Size = new System.Drawing.Size(646, 169);
            this.dtgvQLND.TabIndex = 7;
            // 
            // btnSuaTaiKhoan
            // 
            this.btnSuaTaiKhoan.Location = new System.Drawing.Point(2, 2);
            this.btnSuaTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaTaiKhoan.Name = "btnSuaTaiKhoan";
            this.btnSuaTaiKhoan.Size = new System.Drawing.Size(76, 40);
            this.btnSuaTaiKhoan.TabIndex = 11;
            this.btnSuaTaiKhoan.Text = "Thêm Tài Khoản";
            this.btnSuaTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvQLND);
            this.panel2.Location = new System.Drawing.Point(2, 358);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 194);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Location = new System.Drawing.Point(2, 85);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 189);
            this.panel3.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtManv);
            this.groupBox2.Location = new System.Drawing.Point(8, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 52);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã Nhân Viên";
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(6, 19);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(100, 20);
            this.txtManv.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPass);
            this.groupBox3.Location = new System.Drawing.Point(12, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(126, 52);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "pass";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(6, 19);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTenTK);
            this.groupBox4.Location = new System.Drawing.Point(12, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(126, 52);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tên Tài Khoản";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(6, 19);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(100, 20);
            this.txtTenTK.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbMaCV);
            this.groupBox5.Location = new System.Drawing.Point(161, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(130, 52);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Vụ";
            // 
            // cbMaCV
            // 
            this.cbMaCV.FormattingEnabled = true;
            this.cbMaCV.Location = new System.Drawing.Point(6, 19);
            this.cbMaCV.Name = "cbMaCV";
            this.cbMaCV.Size = new System.Drawing.Size(106, 21);
            this.cbMaCV.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnThemTaiKhoan);
            this.panel4.Controls.Add(this.btnSuaTaiKhoan);
            this.panel4.Location = new System.Drawing.Point(316, 85);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 132);
            this.panel4.TabIndex = 16;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(2, 88);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(76, 40);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Update";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(2, 45);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 40);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Delete";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnShowChucVu
            // 
            this.btnShowChucVu.Location = new System.Drawing.Point(301, 232);
            this.btnShowChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowChucVu.Name = "btnShowChucVu";
            this.btnShowChucVu.Size = new System.Drawing.Size(79, 29);
            this.btnShowChucVu.TabIndex = 17;
            this.btnShowChucVu.Text = "Chức Vụ Info";
            this.btnShowChucVu.UseVisualStyleBackColor = true;
            this.btnShowChucVu.Click += new System.EventHandler(this.btnShowChucVu_Click);
            // 
            // pnShowChucVu
            // 
            this.pnShowChucVu.Controls.Add(this.dtgvChucVu);
            this.pnShowChucVu.Location = new System.Drawing.Point(384, 232);
            this.pnShowChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.pnShowChucVu.Name = "pnShowChucVu";
            this.pnShowChucVu.Size = new System.Drawing.Size(242, 98);
            this.pnShowChucVu.TabIndex = 18;
            // 
            // dtgvChucVu
            // 
            this.dtgvChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChucVu.Location = new System.Drawing.Point(2, 2);
            this.dtgvChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvChucVu.Name = "dtgvChucVu";
            this.dtgvChucVu.ReadOnly = true;
            this.dtgvChucVu.RowHeadersVisible = false;
            this.dtgvChucVu.RowHeadersWidth = 51;
            this.dtgvChucVu.RowTemplate.Height = 24;
            this.dtgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChucVu.Size = new System.Drawing.Size(238, 90);
            this.dtgvChucVu.TabIndex = 19;
            // 
            // UCQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnShowChucVu);
            this.Controls.Add(this.btnShowChucVu);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCQuanLyNguoiDung";
            this.Size = new System.Drawing.Size(900, 569);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLND)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnShowChucVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemTaiKhoan;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dtgvQLND;
        private System.Windows.Forms.Button btnSuaTaiKhoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.ComboBox cbMaCV;
        private System.Windows.Forms.Button btnShowChucVu;
        private System.Windows.Forms.Panel pnShowChucVu;
        private System.Windows.Forms.DataGridView dtgvChucVu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtManv;
    }
}
