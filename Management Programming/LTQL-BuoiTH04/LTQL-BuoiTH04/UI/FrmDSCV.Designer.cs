
namespace LTQL_BuoiTH04.UI
{
    partial class FrmDSCV
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
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.rpvDSCV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.txtHSPC = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chức vụ";
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(137, 14);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(153, 22);
            this.txtMaCV.TabIndex = 1;
            // 
            // rpvDSCV
            // 
            this.rpvDSCV.Location = new System.Drawing.Point(12, 182);
            this.rpvDSCV.Name = "rpvDSCV";
            this.rpvDSCV.ServerReport.BearerToken = null;
            this.rpvDSCV.Size = new System.Drawing.Size(557, 246);
            this.rpvDSCV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hệ số phụ cấp";
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(137, 71);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(153, 22);
            this.txtTenCV.TabIndex = 5;
            // 
            // txtHSPC
            // 
            this.txtHSPC.Location = new System.Drawing.Point(137, 132);
            this.txtHSPC.Name = "txtHSPC";
            this.txtHSPC.Size = new System.Drawing.Size(153, 22);
            this.txtHSPC.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenCV);
            this.panel1.Controls.Add(this.txtHSPC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaCV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 167);
            this.panel1.TabIndex = 7;
            // 
            // FrmDSCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rpvDSCV);
            this.Name = "FrmDSCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Chức Vụ";
            this.Load += new System.EventHandler(this.FrmDSCV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCV;
        private Microsoft.Reporting.WinForms.ReportViewer rpvDSCV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.TextBox txtHSPC;
        private System.Windows.Forms.Panel panel1;
    }
}