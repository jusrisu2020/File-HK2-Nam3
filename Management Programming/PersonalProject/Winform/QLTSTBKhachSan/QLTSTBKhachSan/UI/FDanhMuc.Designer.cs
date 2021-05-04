
namespace QLTSTBKhachSan
{
    partial class FDanhMuc
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
            this.gbDanhMuc = new System.Windows.Forms.GroupBox();
            this.lbMaDanhMuc = new System.Windows.Forms.Label();
            this.txtMaDanhMuc = new System.Windows.Forms.MaskedTextBox();
            this.lbTenDanhMuc = new System.Windows.Forms.Label();
            this.txtTenDanhMuc = new System.Windows.Forms.MaskedTextBox();
            this.btnThemDanhMuc = new System.Windows.Forms.Button();
            this.gbTool = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSuaDanhMuc = new System.Windows.Forms.Button();
            this.dtgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.gbDanhMuc.SuspendLayout();
            this.gbTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDanhMuc
            // 
            this.gbDanhMuc.Controls.Add(this.lbMaDanhMuc);
            this.gbDanhMuc.Controls.Add(this.txtMaDanhMuc);
            this.gbDanhMuc.Controls.Add(this.lbTenDanhMuc);
            this.gbDanhMuc.Controls.Add(this.txtTenDanhMuc);
            this.gbDanhMuc.Location = new System.Drawing.Point(12, 12);
            this.gbDanhMuc.Name = "gbDanhMuc";
            this.gbDanhMuc.Size = new System.Drawing.Size(323, 116);
            this.gbDanhMuc.TabIndex = 9;
            this.gbDanhMuc.TabStop = false;
            this.gbDanhMuc.Text = "Danh Mục";
            // 
            // lbMaDanhMuc
            // 
            this.lbMaDanhMuc.AutoSize = true;
            this.lbMaDanhMuc.Location = new System.Drawing.Point(62, 33);
            this.lbMaDanhMuc.Name = "lbMaDanhMuc";
            this.lbMaDanhMuc.Size = new System.Drawing.Size(95, 17);
            this.lbMaDanhMuc.TabIndex = 10;
            this.lbMaDanhMuc.Text = "Mã Danh Mục";
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Location = new System.Drawing.Point(169, 33);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.Size = new System.Drawing.Size(148, 22);
            this.txtMaDanhMuc.TabIndex = 9;
            // 
            // lbTenDanhMuc
            // 
            this.lbTenDanhMuc.AutoSize = true;
            this.lbTenDanhMuc.Location = new System.Drawing.Point(62, 71);
            this.lbTenDanhMuc.Name = "lbTenDanhMuc";
            this.lbTenDanhMuc.Size = new System.Drawing.Size(101, 17);
            this.lbTenDanhMuc.TabIndex = 8;
            this.lbTenDanhMuc.Text = "Tên Danh Mục";
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Location = new System.Drawing.Point(169, 68);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(148, 22);
            this.txtTenDanhMuc.TabIndex = 4;
            // 
            // btnThemDanhMuc
            // 
            this.btnThemDanhMuc.Location = new System.Drawing.Point(21, 21);
            this.btnThemDanhMuc.Name = "btnThemDanhMuc";
            this.btnThemDanhMuc.Size = new System.Drawing.Size(102, 40);
            this.btnThemDanhMuc.TabIndex = 7;
            this.btnThemDanhMuc.Text = "Thêm";
            this.btnThemDanhMuc.UseVisualStyleBackColor = true;
            this.btnThemDanhMuc.Click += new System.EventHandler(this.btnThemDanhMuc_Click);
            // 
            // gbTool
            // 
            this.gbTool.Controls.Add(this.button3);
            this.gbTool.Controls.Add(this.btnXoa);
            this.gbTool.Controls.Add(this.btnSuaDanhMuc);
            this.gbTool.Controls.Add(this.btnThemDanhMuc);
            this.gbTool.Location = new System.Drawing.Point(366, 12);
            this.gbTool.Name = "gbTool";
            this.gbTool.Size = new System.Drawing.Size(251, 126);
            this.gbTool.TabIndex = 10;
            this.gbTool.TabStop = false;
            this.gbTool.Text = "Công Cụ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(21, 70);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 40);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSuaDanhMuc
            // 
            this.btnSuaDanhMuc.Location = new System.Drawing.Point(129, 21);
            this.btnSuaDanhMuc.Name = "btnSuaDanhMuc";
            this.btnSuaDanhMuc.Size = new System.Drawing.Size(102, 40);
            this.btnSuaDanhMuc.TabIndex = 8;
            this.btnSuaDanhMuc.Text = "Sửa";
            this.btnSuaDanhMuc.UseVisualStyleBackColor = true;
            // 
            // dtgvDanhMuc
            // 
            this.dtgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhMuc.Location = new System.Drawing.Point(33, 177);
            this.dtgvDanhMuc.Name = "dtgvDanhMuc";
            this.dtgvDanhMuc.RowHeadersWidth = 51;
            this.dtgvDanhMuc.RowTemplate.Height = 24;
            this.dtgvDanhMuc.Size = new System.Drawing.Size(360, 174);
            this.dtgvDanhMuc.TabIndex = 11;
            // 
            // FDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvDanhMuc);
            this.Controls.Add(this.gbTool);
            this.Controls.Add(this.gbDanhMuc);
            this.Name = "FDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục";
            this.gbDanhMuc.ResumeLayout(false);
            this.gbDanhMuc.PerformLayout();
            this.gbTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDanhMuc;
        private System.Windows.Forms.Label lbTenDanhMuc;
        private System.Windows.Forms.MaskedTextBox txtTenDanhMuc;
        private System.Windows.Forms.Button btnThemDanhMuc;
        private System.Windows.Forms.Label lbMaDanhMuc;
        private System.Windows.Forms.MaskedTextBox txtMaDanhMuc;
        private System.Windows.Forms.GroupBox gbTool;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSuaDanhMuc;
        private System.Windows.Forms.DataGridView dtgvDanhMuc;
    }
}