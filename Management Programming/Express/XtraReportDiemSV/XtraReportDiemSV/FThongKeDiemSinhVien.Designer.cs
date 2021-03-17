namespace XtraReportDiemSV
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
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rpvThongKeDiemSV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Location = new System.Drawing.Point(664, 11);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(101, 38);
            this.btnXemBaoCao.TabIndex = 5;
            this.btnXemBaoCao.Text = "Xem Báo Cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(142, 21);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(493, 20);
            this.txtHoten.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập họ tên";
            // 
            // rpvThongKeDiemSV
            // 
            this.rpvThongKeDiemSV.Location = new System.Drawing.Point(13, 67);
            this.rpvThongKeDiemSV.Name = "rpvThongKeDiemSV";
            this.rpvThongKeDiemSV.ServerReport.BearerToken = null;
            this.rpvThongKeDiemSV.Size = new System.Drawing.Size(775, 371);
            this.rpvThongKeDiemSV.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvThongKeDiemSV);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Thống Kê Điểm Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvThongKeDiemSV;
    }
}

