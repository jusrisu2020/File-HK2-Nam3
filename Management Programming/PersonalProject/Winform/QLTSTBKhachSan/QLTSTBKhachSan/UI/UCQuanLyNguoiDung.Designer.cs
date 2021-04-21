
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLND)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 81);
            this.panel1.TabIndex = 1;
            // 
            // btnCapNhatND
            // 
            this.btnCapNhatND.Location = new System.Drawing.Point(24, 93);
            this.btnCapNhatND.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapNhatND.Name = "btnCapNhatND";
            this.btnCapNhatND.Size = new System.Drawing.Size(76, 46);
            this.btnCapNhatND.TabIndex = 2;
            this.btnCapNhatND.Text = "Create User";
            this.btnCapNhatND.UseVisualStyleBackColor = true;
            this.btnCapNhatND.Click += new System.EventHandler(this.btnCapNhatND_Click);
            // 
            // btnPhanQuyenND
            // 
            this.btnPhanQuyenND.Location = new System.Drawing.Point(123, 95);
            this.btnPhanQuyenND.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPhanQuyenND.Name = "btnPhanQuyenND";
            this.btnPhanQuyenND.Size = new System.Drawing.Size(122, 50);
            this.btnPhanQuyenND.TabIndex = 3;
            this.btnPhanQuyenND.Text = "User Authorization";
            this.btnPhanQuyenND.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(290, 101);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(421, 111);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(162, 20);
            this.txtTimKiem.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(586, 101);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(64, 30);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Search...";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dtgvQLND
            // 
            this.dtgvQLND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLND.Location = new System.Drawing.Point(38, 211);
            this.dtgvQLND.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvQLND.Name = "dtgvQLND";
            this.dtgvQLND.RowHeadersWidth = 51;
            this.dtgvQLND.RowTemplate.Height = 24;
            this.dtgvQLND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQLND.Size = new System.Drawing.Size(544, 169);
            this.dtgvQLND.TabIndex = 7;
            // 
            // UCQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvQLND);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPhanQuyenND);
            this.Controls.Add(this.btnCapNhatND);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCQuanLyNguoiDung";
            this.Size = new System.Drawing.Size(900, 569);
            this.Load += new System.EventHandler(this.UCQuanLyNguoiDung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLND)).EndInit();
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
    }
}
