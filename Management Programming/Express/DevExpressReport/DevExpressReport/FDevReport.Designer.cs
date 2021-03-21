namespace DevExpressReport
{
    partial class FDevReport
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
            this.tableAdapterManager1 = new DevExpressReport.ReportDoanhSoDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHienThiHet = new System.Windows.Forms.Button();
            this.txtBaoCao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.DoanhSoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = DevExpressReport.ReportDoanhSoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Báo Cáo Doanh Số";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(147, 109);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(89, 36);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnHienThiHet
            // 
            this.btnHienThiHet.Location = new System.Drawing.Point(52, 109);
            this.btnHienThiHet.Name = "btnHienThiHet";
            this.btnHienThiHet.Size = new System.Drawing.Size(89, 36);
            this.btnHienThiHet.TabIndex = 2;
            this.btnHienThiHet.Text = "Hiển Thị Hết";
            this.btnHienThiHet.UseVisualStyleBackColor = true;
            this.btnHienThiHet.Click += new System.EventHandler(this.btnHienThiHet_Click);
            // 
            // txtBaoCao
            // 
            this.txtBaoCao.Location = new System.Drawing.Point(68, 62);
            this.txtBaoCao.Name = "txtBaoCao";
            this.txtBaoCao.Size = new System.Drawing.Size(155, 20);
            this.txtBaoCao.TabIndex = 1;
            // 
            // FDevReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 164);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHienThiHet);
            this.Controls.Add(this.txtBaoCao);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "FDevReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReportDoanhSoDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnHienThiHet;
        private System.Windows.Forms.TextBox txtBaoCao;
    }
}

