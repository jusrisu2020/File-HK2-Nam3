
namespace CreateXtraReport
{
    partial class FThongKeKetQuaSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.rpvThongKeDiem = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ tên";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(157, 37);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(656, 22);
            this.txtHoten.TabIndex = 1;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Location = new System.Drawing.Point(819, 25);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(135, 47);
            this.btnXemBaoCao.TabIndex = 2;
            this.btnXemBaoCao.Text = "Xem Báo Cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // rpvThongKeDiem
            // 
            this.rpvThongKeDiem.Location = new System.Drawing.Point(32, 96);
            this.rpvThongKeDiem.Name = "rpvThongKeDiem";
            this.rpvThongKeDiem.ServerReport.BearerToken = null;
            this.rpvThongKeDiem.Size = new System.Drawing.Size(922, 327);
            this.rpvThongKeDiem.TabIndex = 3;
            // 
            // FThongKeKetQuaSinhVien
            // 
            this.AcceptButton = this.btnXemBaoCao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 505);
            this.Controls.Add(this.rpvThongKeDiem);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label1);
            this.Name = "FThongKeKetQuaSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê kết quả sinh viên";
            this.Load += new System.EventHandler(this.FThongKeKetQuaSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button btnXemBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer rpvThongKeDiem;
    }
}

