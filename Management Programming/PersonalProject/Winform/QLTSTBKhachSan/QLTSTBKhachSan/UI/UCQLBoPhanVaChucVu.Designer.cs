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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtThemBoPhan = new System.Windows.Forms.TextBox();
            this.btnThemBP = new System.Windows.Forms.Button();
            this.btnSuaBoPhan = new System.Windows.Forms.Button();
            this.txtMaBP = new System.Windows.Forms.TextBox();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flpBoPhan = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLBP)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản Lí Bộ Phận và Chức vụ";
            // 
            // dtgvQLBP
            // 
            this.dtgvQLBP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLBP.Location = new System.Drawing.Point(5, 210);
            this.dtgvQLBP.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvQLBP.Name = "dtgvQLBP";
            this.dtgvQLBP.RowHeadersWidth = 51;
            this.dtgvQLBP.RowTemplate.Height = 24;
            this.dtgvQLBP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQLBP.Size = new System.Drawing.Size(355, 169);
            this.dtgvQLBP.TabIndex = 14;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(613, 24);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(64, 30);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Search...";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(438, 30);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(162, 20);
            this.txtTimKiem.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(213, 144);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 40);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 81);
            this.panel1.TabIndex = 8;
            // 
            // txtThemBoPhan
            // 
            this.txtThemBoPhan.Location = new System.Drawing.Point(24, 57);
            this.txtThemBoPhan.Name = "txtThemBoPhan";
            this.txtThemBoPhan.Size = new System.Drawing.Size(128, 20);
            this.txtThemBoPhan.TabIndex = 15;
            // 
            // btnThemBP
            // 
            this.btnThemBP.Location = new System.Drawing.Point(213, 31);
            this.btnThemBP.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemBP.Name = "btnThemBP";
            this.btnThemBP.Size = new System.Drawing.Size(76, 46);
            this.btnThemBP.TabIndex = 16;
            this.btnThemBP.Text = "Tạo Bộ Phận";
            this.btnThemBP.UseVisualStyleBackColor = true;
            this.btnThemBP.Click += new System.EventHandler(this.btnThemBP_Click);
            // 
            // btnSuaBoPhan
            // 
            this.btnSuaBoPhan.Location = new System.Drawing.Point(213, 100);
            this.btnSuaBoPhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaBoPhan.Name = "btnSuaBoPhan";
            this.btnSuaBoPhan.Size = new System.Drawing.Size(76, 40);
            this.btnSuaBoPhan.TabIndex = 17;
            this.btnSuaBoPhan.Text = "Update";
            this.btnSuaBoPhan.UseVisualStyleBackColor = true;
            this.btnSuaBoPhan.Click += new System.EventHandler(this.btnSuaBoPhan_Click);
            // 
            // txtMaBP
            // 
            this.txtMaBP.Location = new System.Drawing.Point(24, 31);
            this.txtMaBP.Name = "txtMaBP";
            this.txtMaBP.Size = new System.Drawing.Size(67, 20);
            this.txtMaBP.TabIndex = 18;
            // 
            // btnRefesh
            // 
            this.btnRefesh.Location = new System.Drawing.Point(308, 31);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(71, 40);
            this.btnRefesh.TabIndex = 19;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteAll);
            this.groupBox1.Controls.Add(this.dtgvQLBP);
            this.groupBox1.Controls.Add(this.btnRefesh);
            this.groupBox1.Controls.Add(this.txtMaBP);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSuaBoPhan);
            this.groupBox1.Controls.Add(this.txtThemBoPhan);
            this.groupBox1.Controls.Add(this.btnThemBP);
            this.groupBox1.Location = new System.Drawing.Point(22, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 384);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ Phận";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(308, 100);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(71, 40);
            this.btnDeleteAll.TabIndex = 20;
            this.btnDeleteAll.Text = "DeleteAll";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            // 
            // flpBoPhan
            // 
            this.flpBoPhan.AutoScroll = true;
            this.flpBoPhan.Location = new System.Drawing.Point(438, 101);
            this.flpBoPhan.Name = "flpBoPhan";
            this.flpBoPhan.Size = new System.Drawing.Size(444, 448);
            this.flpBoPhan.TabIndex = 21;
            // 
            // UCQuanLiBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpBoPhan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "UCQuanLiBoPhan";
            this.Size = new System.Drawing.Size(900, 569);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLBP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvQLBP;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtThemBoPhan;
        private System.Windows.Forms.Button btnThemBP;
        private System.Windows.Forms.Button btnSuaBoPhan;
        private System.Windows.Forms.TextBox txtMaBP;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.FlowLayoutPanel flpBoPhan;
    }
}
