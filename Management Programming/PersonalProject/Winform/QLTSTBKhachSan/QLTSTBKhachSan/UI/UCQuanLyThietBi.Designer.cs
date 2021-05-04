
namespace QLTSTBKhachSan.UI
{
    partial class UCQuanLyThietBi
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
            this.flpBtnBoPhan = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgvThietBi = new System.Windows.Forms.DataGridView();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.btnThemDanhMuc = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLoadAllThietBi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí thiết bị";
            // 
            // flpBtnBoPhan
            // 
            this.flpBtnBoPhan.AutoScroll = true;
            this.flpBtnBoPhan.Location = new System.Drawing.Point(25, 166);
            this.flpBtnBoPhan.Name = "flpBtnBoPhan";
            this.flpBtnBoPhan.Size = new System.Drawing.Size(1167, 223);
            this.flpBtnBoPhan.TabIndex = 2;
            // 
            // dtgvThietBi
            // 
            this.dtgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThietBi.Location = new System.Drawing.Point(13, 456);
            this.dtgvThietBi.Name = "dtgvThietBi";
            this.dtgvThietBi.ReadOnly = true;
            this.dtgvThietBi.RowHeadersVisible = false;
            this.dtgvThietBi.RowHeadersWidth = 51;
            this.dtgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvThietBi.Size = new System.Drawing.Size(1167, 147);
            this.dtgvThietBi.TabIndex = 0;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(730, 32);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(159, 24);
            this.cbDanhMuc.TabIndex = 6;
            // 
            // btnThemDanhMuc
            // 
            this.btnThemDanhMuc.Location = new System.Drawing.Point(1064, 102);
            this.btnThemDanhMuc.Name = "btnThemDanhMuc";
            this.btnThemDanhMuc.Size = new System.Drawing.Size(128, 40);
            this.btnThemDanhMuc.TabIndex = 9;
            this.btnThemDanhMuc.Text = "Thêm Danh Mục";
            this.btnThemDanhMuc.UseVisualStyleBackColor = true;
            this.btnThemDanhMuc.Click += new System.EventHandler(this.btnThemDanhMuc_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(912, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(128, 40);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLoadAllThietBi
            // 
            this.btnLoadAllThietBi.Location = new System.Drawing.Point(25, 120);
            this.btnLoadAllThietBi.Name = "btnLoadAllThietBi";
            this.btnLoadAllThietBi.Size = new System.Drawing.Size(128, 40);
            this.btnLoadAllThietBi.TabIndex = 11;
            this.btnLoadAllThietBi.Text = "Tất cả thiết bị";
            this.btnLoadAllThietBi.UseVisualStyleBackColor = true;
            this.btnLoadAllThietBi.Click += new System.EventHandler(this.btnLoadAllThietBi_Click);
            // 
            // UCQuanLyThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoadAllThietBi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThemDanhMuc);
            this.Controls.Add(this.dtgvThietBi);
            this.Controls.Add(this.flpBtnBoPhan);
            this.Controls.Add(this.cbDanhMuc);
            this.Controls.Add(this.label1);
            this.Name = "UCQuanLyThietBi";
            this.Size = new System.Drawing.Size(1200, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpBtnBoPhan;
        private System.Windows.Forms.DataGridView dtgvThietBi;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.Button btnThemDanhMuc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLoadAllThietBi;
    }
}
