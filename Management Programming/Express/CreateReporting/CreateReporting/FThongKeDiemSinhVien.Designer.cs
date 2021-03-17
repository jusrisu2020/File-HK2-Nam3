
namespace CreateReporting
{
    partial class FThongKeDiemSinhVien
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
            this.rpvThongKeDiem = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rpvThongKeDiem
            // 
            this.rpvThongKeDiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rpvThongKeDiem.Location = new System.Drawing.Point(0, 74);
            this.rpvThongKeDiem.Name = "rpvThongKeDiem";
            this.rpvThongKeDiem.ServerReport.BearerToken = null;
            this.rpvThongKeDiem.Size = new System.Drawing.Size(602, 293);
            this.rpvThongKeDiem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Họ Và Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(192, 38);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(227, 22);
            this.txtHoTen.TabIndex = 2;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Location = new System.Drawing.Point(445, 35);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(124, 33);
            this.btnXemBaoCao.TabIndex = 3;
            this.btnXemBaoCao.Text = "Xem Báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            // 
            // FThongKeDiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 367);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpvThongKeDiem);
            this.Name = "FThongKeDiemSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê điểm Sinh viên";
            this.Load += new System.EventHandler(this.FThongKeDiemSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvThongKeDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnXemBaoCao;
    }
}

