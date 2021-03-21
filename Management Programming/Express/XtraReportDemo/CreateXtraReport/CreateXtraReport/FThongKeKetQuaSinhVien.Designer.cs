
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
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ tên";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(117, 27);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(493, 20);
            this.txtHoten.TabIndex = 1;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Location = new System.Drawing.Point(614, 20);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(101, 38);
            this.btnXemBaoCao.TabIndex = 2;
            this.btnXemBaoCao.Text = "Xem Báo Cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // rpvThongKeDiem
            // 
            this.rpvThongKeDiem.Location = new System.Drawing.Point(24, 78);
            this.rpvThongKeDiem.Margin = new System.Windows.Forms.Padding(2);
            this.rpvThongKeDiem.Name = "rpvThongKeDiem";
            this.rpvThongKeDiem.ServerReport.BearerToken = null;
            this.rpvThongKeDiem.Size = new System.Drawing.Size(692, 266);
            this.rpvThongKeDiem.TabIndex = 3;
            // 
            // FThongKeKetQuaSinhVien
            // 
            this.AcceptButton = this.btnXemBaoCao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 373);
            this.Controls.Add(this.rpvThongKeDiem);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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

