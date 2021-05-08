
namespace QLTSTBKhachSan.UI
{
    partial class UCQuanLyNhanVien
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
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvQLNV = new System.Windows.Forms.DataGridView();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvChucVu = new System.Windows.Forms.DataGridView();
            this.btnRefeshChucVu = new System.Windows.Forms.Button();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.btnInsertChucVu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Location = new System.Drawing.Point(23, 58);
            this.btnThemNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(80, 46);
            this.btnThemNhanVien.TabIndex = 1;
            this.btnThemNhanVien.Text = "Add...";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Location = new System.Drawing.Point(116, 58);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(58, 46);
            this.btnDeleteNV.TabIndex = 2;
            this.btnDeleteNV.Text = "Delete";
            this.btnDeleteNV.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 63);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Search...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvQLNV
            // 
            this.dgvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNV.Location = new System.Drawing.Point(37, 344);
            this.dgvQLNV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQLNV.Name = "dgvQLNV";
            this.dgvQLNV.ReadOnly = true;
            this.dgvQLNV.RowHeadersVisible = false;
            this.dgvQLNV.RowHeadersWidth = 51;
            this.dgvQLNV.RowTemplate.Height = 24;
            this.dgvQLNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLNV.Size = new System.Drawing.Size(503, 176);
            this.dgvQLNV.TabIndex = 4;
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.Location = new System.Drawing.Point(189, 72);
            this.txtTimKiemNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(113, 20);
            this.txtTimKiemNV.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvChucVu);
            this.groupBox2.Controls.Add(this.btnRefeshChucVu);
            this.groupBox2.Controls.Add(this.txtMaCV);
            this.groupBox2.Controls.Add(this.txtTenCV);
            this.groupBox2.Controls.Add(this.btnInsertChucVu);
            this.groupBox2.Location = new System.Drawing.Point(496, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 257);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức vụ";
            // 
            // dtgvChucVu
            // 
            this.dtgvChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChucVu.Location = new System.Drawing.Point(16, 87);
            this.dtgvChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvChucVu.Name = "dtgvChucVu";
            this.dtgvChucVu.ReadOnly = true;
            this.dtgvChucVu.RowHeadersVisible = false;
            this.dtgvChucVu.RowHeadersWidth = 51;
            this.dtgvChucVu.RowTemplate.Height = 24;
            this.dtgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChucVu.Size = new System.Drawing.Size(211, 114);
            this.dtgvChucVu.TabIndex = 14;
            // 
            // btnRefeshChucVu
            // 
            this.btnRefeshChucVu.Location = new System.Drawing.Point(230, 12);
            this.btnRefeshChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefeshChucVu.Name = "btnRefeshChucVu";
            this.btnRefeshChucVu.Size = new System.Drawing.Size(88, 28);
            this.btnRefeshChucVu.TabIndex = 19;
            this.btnRefeshChucVu.Text = "Refesh";
            this.btnRefeshChucVu.UseVisualStyleBackColor = true;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(16, 27);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(67, 20);
            this.txtMaCV.TabIndex = 18;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(88, 27);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(128, 20);
            this.txtTenCV.TabIndex = 15;
            // 
            // btnInsertChucVu
            // 
            this.btnInsertChucVu.Location = new System.Drawing.Point(230, 43);
            this.btnInsertChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertChucVu.Name = "btnInsertChucVu";
            this.btnInsertChucVu.Size = new System.Drawing.Size(88, 28);
            this.btnInsertChucVu.TabIndex = 16;
            this.btnInsertChucVu.Text = "Thêm Bộ Phận";
            this.btnInsertChucVu.UseVisualStyleBackColor = true;
            // 
            // UCQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTimKiemNV);
            this.Controls.Add(this.dgvQLNV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDeleteNV);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCQuanLyNhanVien";
            this.Size = new System.Drawing.Size(900, 569);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Button btnDeleteNV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvQLNV;
        private System.Windows.Forms.TextBox txtTimKiemNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Button btnInsertChucVu;
        private System.Windows.Forms.Button btnRefeshChucVu;
        private System.Windows.Forms.DataGridView dtgvChucVu;
    }
}
