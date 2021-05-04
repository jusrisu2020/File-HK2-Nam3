
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
            this.btnUpdateNV = new System.Windows.Forms.Button();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvQLNV = new System.Windows.Forms.DataGridView();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvChucVu = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.btnThemCV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // btnUpdateNV
            // 
            this.btnUpdateNV.Location = new System.Drawing.Point(31, 137);
            this.btnUpdateNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Size = new System.Drawing.Size(106, 57);
            this.btnUpdateNV.TabIndex = 1;
            this.btnUpdateNV.Text = "Add...";
            this.btnUpdateNV.UseVisualStyleBackColor = true;
            this.btnUpdateNV.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Location = new System.Drawing.Point(152, 137);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(77, 57);
            this.btnDeleteNV.TabIndex = 2;
            this.btnDeleteNV.Text = "Delete";
            this.btnDeleteNV.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(405, 144);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Search...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvQLNV
            // 
            this.dgvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNV.Location = new System.Drawing.Point(41, 377);
            this.dgvQLNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQLNV.Name = "dgvQLNV";
            this.dgvQLNV.ReadOnly = true;
            this.dgvQLNV.RowHeadersVisible = false;
            this.dgvQLNV.RowHeadersWidth = 51;
            this.dgvQLNV.RowTemplate.Height = 24;
            this.dgvQLNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLNV.Size = new System.Drawing.Size(671, 217);
            this.dgvQLNV.TabIndex = 4;
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.Location = new System.Drawing.Point(250, 154);
            this.txtTimKiemNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(149, 22);
            this.txtTimKiemNV.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvChucVu);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtMaCV);
            this.groupBox2.Controls.Add(this.txtTenCV);
            this.groupBox2.Controls.Add(this.btnThemCV);
            this.groupBox2.Location = new System.Drawing.Point(662, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(446, 316);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức vụ";
            // 
            // dtgvChucVu
            // 
            this.dtgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChucVu.Location = new System.Drawing.Point(21, 107);
            this.dtgvChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvChucVu.Name = "dtgvChucVu";
            this.dtgvChucVu.ReadOnly = true;
            this.dtgvChucVu.RowHeadersVisible = false;
            this.dtgvChucVu.RowHeadersWidth = 51;
            this.dtgvChucVu.RowTemplate.Height = 24;
            this.dtgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChucVu.Size = new System.Drawing.Size(281, 140);
            this.dtgvChucVu.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Refesh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(21, 33);
            this.txtMaCV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(88, 22);
            this.txtMaCV.TabIndex = 18;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(117, 33);
            this.txtTenCV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(169, 22);
            this.txtTenCV.TabIndex = 15;
            // 
            // btnThemCV
            // 
            this.btnThemCV.Location = new System.Drawing.Point(307, 53);
            this.btnThemCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.Size = new System.Drawing.Size(118, 34);
            this.btnThemCV.TabIndex = 16;
            this.btnThemCV.Text = "Tạo Bộ Phận";
            this.btnThemCV.UseVisualStyleBackColor = true;
            // 
            // UCQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTimKiemNV);
            this.Controls.Add(this.dgvQLNV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDeleteNV);
            this.Controls.Add(this.btnUpdateNV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCQuanLyNhanVien";
            this.Size = new System.Drawing.Size(1200, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateNV;
        private System.Windows.Forms.Button btnDeleteNV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvQLNV;
        private System.Windows.Forms.TextBox txtTimKiemNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Button btnThemCV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgvChucVu;
    }
}
