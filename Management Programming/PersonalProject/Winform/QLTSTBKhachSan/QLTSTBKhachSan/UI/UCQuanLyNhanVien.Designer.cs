
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtgvChucVu = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.btnDeleteChucVu = new System.Windows.Forms.Button();
            this.btnUpdateCV = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // btnUpdateNV
            // 
            this.btnUpdateNV.Location = new System.Drawing.Point(14, 56);
            this.btnUpdateNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Size = new System.Drawing.Size(141, 46);
            this.btnUpdateNV.TabIndex = 1;
            this.btnUpdateNV.Text = "Add...";
            this.btnUpdateNV.UseVisualStyleBackColor = true;
            this.btnUpdateNV.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Location = new System.Drawing.Point(202, 56);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(58, 46);
            this.btnDeleteNV.TabIndex = 2;
            this.btnDeleteNV.Text = "Delete";
            this.btnDeleteNV.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 61);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Search...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvQLNV
            // 
            this.dgvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNV.Location = new System.Drawing.Point(23, 198);
            this.dgvQLNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvQLNV.Name = "dgvQLNV";
            this.dgvQLNV.RowHeadersWidth = 51;
            this.dgvQLNV.RowTemplate.Height = 24;
            this.dgvQLNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLNV.Size = new System.Drawing.Size(387, 176);
            this.dgvQLNV.TabIndex = 4;
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.Location = new System.Drawing.Point(275, 70);
            this.txtTimKiemNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(88, 20);
            this.txtTimKiemNV.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dtgvChucVu);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtMaCV);
            this.groupBox2.Controls.Add(this.btnDeleteChucVu);
            this.groupBox2.Controls.Add(this.btnUpdateCV);
            this.groupBox2.Controls.Add(this.txtTenCV);
            this.groupBox2.Controls.Add(this.btnThemCV);
            this.groupBox2.Location = new System.Drawing.Point(450, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 384);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức vụ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "DeleteAll";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtgvChucVu
            // 
            this.dtgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChucVu.Location = new System.Drawing.Point(5, 210);
            this.dtgvChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvChucVu.Name = "dtgvChucVu";
            this.dtgvChucVu.RowHeadersWidth = 51;
            this.dtgvChucVu.RowTemplate.Height = 24;
            this.dtgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChucVu.Size = new System.Drawing.Size(355, 169);
            this.dtgvChucVu.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 31);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "Refesh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(24, 31);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(67, 20);
            this.txtMaCV.TabIndex = 18;
            // 
            // btnDeleteChucVu
            // 
            this.btnDeleteChucVu.Location = new System.Drawing.Point(213, 156);
            this.btnDeleteChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteChucVu.Name = "btnDeleteChucVu";
            this.btnDeleteChucVu.Size = new System.Drawing.Size(71, 40);
            this.btnDeleteChucVu.TabIndex = 11;
            this.btnDeleteChucVu.Text = "Delete";
            this.btnDeleteChucVu.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCV
            // 
            this.btnUpdateCV.Location = new System.Drawing.Point(213, 100);
            this.btnUpdateCV.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCV.Name = "btnUpdateCV";
            this.btnUpdateCV.Size = new System.Drawing.Size(76, 40);
            this.btnUpdateCV.TabIndex = 17;
            this.btnUpdateCV.Text = "Update";
            this.btnUpdateCV.UseVisualStyleBackColor = true;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(24, 57);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(128, 20);
            this.txtTenCV.TabIndex = 15;
            // 
            // btnThemCV
            // 
            this.btnThemCV.Location = new System.Drawing.Point(213, 31);
            this.btnThemCV.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.Size = new System.Drawing.Size(76, 46);
            this.btnThemCV.TabIndex = 16;
            this.btnThemCV.Text = "Tạo Bộ Phận";
            this.btnThemCV.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.btnUpdateNV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnUpdateNV;
        private System.Windows.Forms.Button btnDeleteNV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvQLNV;
        private System.Windows.Forms.TextBox txtTimKiemNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgvChucVu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.Button btnDeleteChucVu;
        private System.Windows.Forms.Button btnUpdateCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Button btnThemCV;
    }
}
