
namespace QLTSTBKhachSan
{
    partial class TaiKhoan
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
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnBoPhan = new System.Windows.Forms.Button();
            this.cbTK = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(220, 222);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(109, 63);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnBoPhan
            // 
            this.btnBoPhan.Location = new System.Drawing.Point(108, 222);
            this.btnBoPhan.Name = "btnBoPhan";
            this.btnBoPhan.Size = new System.Drawing.Size(89, 61);
            this.btnBoPhan.TabIndex = 2;
            this.btnBoPhan.Text = "Bộ phận";
            this.btnBoPhan.UseVisualStyleBackColor = true;
            this.btnBoPhan.Click += new System.EventHandler(this.btnBoPhan_Click);
            // 
            // cbTK
            // 
            this.cbTK.FormattingEnabled = true;
            this.cbTK.Location = new System.Drawing.Point(208, 85);
            this.cbTK.Name = "cbTK";
            this.cbTK.Size = new System.Drawing.Size(121, 24);
            this.cbTK.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(402, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbTK);
            this.Controls.Add(this.btnBoPhan);
            this.Controls.Add(this.btnNhanVien);
            this.Name = "TaiKhoan";
            this.Text = "Tạo tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnBoPhan;
        private System.Windows.Forms.ComboBox cbTK;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

