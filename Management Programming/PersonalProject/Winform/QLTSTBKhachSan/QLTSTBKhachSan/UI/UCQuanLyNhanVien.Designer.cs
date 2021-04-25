
namespace QLTSTBKhachSan.UI
{
    partial class UCQuanLyNhanVien
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
            this.btnUpdateNV = new System.Windows.Forms.Button();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvQLNV = new System.Windows.Forms.DataGridView();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // btnUpdateNV
            // 
            this.btnUpdateNV.Location = new System.Drawing.Point(18, 69);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Size = new System.Drawing.Size(188, 57);
            this.btnUpdateNV.TabIndex = 1;
            this.btnUpdateNV.Text = "Add...";
            this.btnUpdateNV.UseVisualStyleBackColor = true;
            this.btnUpdateNV.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Location = new System.Drawing.Point(270, 69);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(77, 57);
            this.btnDeleteNV.TabIndex = 2;
            this.btnDeleteNV.Text = "Delete";
            this.btnDeleteNV.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(516, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Search...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvQLNV
            // 
            this.dgvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNV.Location = new System.Drawing.Point(31, 244);
            this.dgvQLNV.Name = "dgvQLNV";
            this.dgvQLNV.RowHeadersWidth = 51;
            this.dgvQLNV.RowTemplate.Height = 24;
            this.dgvQLNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLNV.Size = new System.Drawing.Size(516, 216);
            this.dgvQLNV.TabIndex = 4;
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.Location = new System.Drawing.Point(367, 86);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(116, 22);
            this.txtTimKiemNV.TabIndex = 5;
            // 
            // UCQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTimKiemNV);
            this.Controls.Add(this.dgvQLNV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDeleteNV);
            this.Controls.Add(this.btnUpdateNV);
            this.Controls.Add(this.label1);
            this.Name = "UCQuanLyNhanVien";
            this.Size = new System.Drawing.Size(1200, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateNV;
        private System.Windows.Forms.Button btnDeleteNV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvQLNV;
        private System.Windows.Forms.TextBox txtTimKiemNV;
    }
}
