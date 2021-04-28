namespace QLTSTBKhachSan.UI
{
    partial class UCQuanLiBoPhan
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvQLBP = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnThemBoPhan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtThemBoPhan = new System.Windows.Forms.TextBox();
            this.btnThemBP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLBP)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản Lí Bộ Phận";
            // 
            // dtgvQLBP
            // 
            this.dtgvQLBP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLBP.Location = new System.Drawing.Point(38, 211);
            this.dtgvQLBP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvQLBP.Name = "dtgvQLBP";
            this.dtgvQLBP.RowHeadersWidth = 51;
            this.dtgvQLBP.RowTemplate.Height = 24;
            this.dtgvQLBP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQLBP.Size = new System.Drawing.Size(256, 169);
            this.dtgvQLBP.TabIndex = 14;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(586, 101);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(64, 30);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Search...";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(421, 111);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(162, 20);
            this.txtTimKiem.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(201, 99);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 40);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnThemBoPhan
            // 
            this.btnThemBoPhan.Location = new System.Drawing.Point(74, 93);
            this.btnThemBoPhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemBoPhan.Name = "btnThemBoPhan";
            this.btnThemBoPhan.Size = new System.Drawing.Size(76, 46);
            this.btnThemBoPhan.TabIndex = 9;
            this.btnThemBoPhan.Text = "Tạo Bộ Phận";
            this.btnThemBoPhan.UseVisualStyleBackColor = true;
            this.btnThemBoPhan.Click += new System.EventHandler(this.btnThemBoPhan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 81);
            this.panel1.TabIndex = 8;
            // 
            // txtThemBoPhan
            // 
            this.txtThemBoPhan.Location = new System.Drawing.Point(466, 239);
            this.txtThemBoPhan.Name = "txtThemBoPhan";
            this.txtThemBoPhan.Size = new System.Drawing.Size(100, 20);
            this.txtThemBoPhan.TabIndex = 15;
            // 
            // btnThemBP
            // 
            this.btnThemBP.Location = new System.Drawing.Point(586, 225);
            this.btnThemBP.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemBP.Name = "btnThemBP";
            this.btnThemBP.Size = new System.Drawing.Size(76, 46);
            this.btnThemBP.TabIndex = 16;
            this.btnThemBP.Text = "Tạo Bộ Phận";
            this.btnThemBP.UseVisualStyleBackColor = true;
            this.btnThemBP.Click += new System.EventHandler(this.btnThemBP_Click);
            // 
            // UCQuanLiBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThemBP);
            this.Controls.Add(this.txtThemBoPhan);
            this.Controls.Add(this.dtgvQLBP);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnThemBoPhan);
            this.Controls.Add(this.panel1);
            this.Name = "UCQuanLiBoPhan";
            this.Size = new System.Drawing.Size(900, 569);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLBP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvQLBP;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnThemBoPhan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtThemBoPhan;
        private System.Windows.Forms.Button btnThemBP;
    }
}
