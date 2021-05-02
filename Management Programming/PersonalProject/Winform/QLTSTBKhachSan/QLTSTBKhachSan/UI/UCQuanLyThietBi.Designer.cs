
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
            this.flpBtnBoPhan.Location = new System.Drawing.Point(25, 34);
            this.flpBtnBoPhan.Name = "flpBtnBoPhan";
            this.flpBtnBoPhan.Size = new System.Drawing.Size(1155, 159);
            this.flpBtnBoPhan.TabIndex = 2;
            // 
            // dtgvThietBi
            // 
            this.dtgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThietBi.Location = new System.Drawing.Point(13, 257);
            this.dtgvThietBi.Name = "dtgvThietBi";
            this.dtgvThietBi.ReadOnly = true;
            this.dtgvThietBi.RowHeadersWidth = 51;
            this.dtgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvThietBi.Size = new System.Drawing.Size(1167, 346);
            this.dtgvThietBi.TabIndex = 0;
            // 
            // UCQuanLyThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvThietBi);
            this.Controls.Add(this.flpBtnBoPhan);
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
    }
}
