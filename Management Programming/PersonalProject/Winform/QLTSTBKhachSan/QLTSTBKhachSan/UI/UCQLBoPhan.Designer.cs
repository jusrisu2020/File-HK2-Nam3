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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvQLBP = new System.Windows.Forms.DataGridView();
            this.btnSearchBoPhan = new System.Windows.Forms.Button();
            this.txtTKBoPhan = new System.Windows.Forms.TextBox();
            this.btnDeleteBoPhan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtThemBoPhan = new System.Windows.Forms.TextBox();
            this.btnInsertBP = new System.Windows.Forms.Button();
            this.btnUpdateBoPhan = new System.Windows.Forms.Button();
            this.txtMaBP = new System.Windows.Forms.TextBox();
            this.btnRefeshBoPhan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
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
            this.dtgvQLBP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvQLBP.CausesValidation = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQLBP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvQLBP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLBP.Location = new System.Drawing.Point(5, 210);
            this.dtgvQLBP.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvQLBP.Name = "dtgvQLBP";
            this.dtgvQLBP.ReadOnly = true;
            this.dtgvQLBP.RowHeadersVisible = false;
            this.dtgvQLBP.RowHeadersWidth = 51;
            this.dtgvQLBP.RowTemplate.Height = 24;
            this.dtgvQLBP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQLBP.Size = new System.Drawing.Size(355, 169);
            this.dtgvQLBP.TabIndex = 14;
            // 
            // btnSearchBoPhan
            // 
            this.btnSearchBoPhan.Location = new System.Drawing.Point(613, 24);
            this.btnSearchBoPhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchBoPhan.Name = "btnSearchBoPhan";
            this.btnSearchBoPhan.Size = new System.Drawing.Size(64, 30);
            this.btnSearchBoPhan.TabIndex = 13;
            this.btnSearchBoPhan.Text = "Search...";
            this.btnSearchBoPhan.UseVisualStyleBackColor = true;
            this.btnSearchBoPhan.Click += new System.EventHandler(this.btnSearchBoPhan_Click);
            // 
            // txtTKBoPhan
            // 
            this.txtTKBoPhan.Location = new System.Drawing.Point(447, 30);
            this.txtTKBoPhan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTKBoPhan.Name = "txtTKBoPhan";
            this.txtTKBoPhan.Size = new System.Drawing.Size(162, 20);
            this.txtTKBoPhan.TabIndex = 12;
            // 
            // btnDeleteBoPhan
            // 
            this.btnDeleteBoPhan.Location = new System.Drawing.Point(185, 108);
            this.btnDeleteBoPhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteBoPhan.Name = "btnDeleteBoPhan";
            this.btnDeleteBoPhan.Size = new System.Drawing.Size(94, 40);
            this.btnDeleteBoPhan.TabIndex = 11;
            this.btnDeleteBoPhan.Text = "Delete";
            this.btnDeleteBoPhan.UseVisualStyleBackColor = true;
            this.btnDeleteBoPhan.Click += new System.EventHandler(this.btnDeleteBoPhan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTKBoPhan);
            this.panel1.Controls.Add(this.btnSearchBoPhan);
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
            // btnInsertBP
            // 
            this.btnInsertBP.Location = new System.Drawing.Point(185, 14);
            this.btnInsertBP.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertBP.Name = "btnInsertBP";
            this.btnInsertBP.Size = new System.Drawing.Size(94, 46);
            this.btnInsertBP.TabIndex = 16;
            this.btnInsertBP.Text = "Thêm Bộ Phận";
            this.btnInsertBP.UseVisualStyleBackColor = true;
            this.btnInsertBP.Click += new System.EventHandler(this.btnInsertBP_Click);
            // 
            // btnUpdateBoPhan
            // 
            this.btnUpdateBoPhan.Location = new System.Drawing.Point(185, 64);
            this.btnUpdateBoPhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateBoPhan.Name = "btnUpdateBoPhan";
            this.btnUpdateBoPhan.Size = new System.Drawing.Size(94, 40);
            this.btnUpdateBoPhan.TabIndex = 17;
            this.btnUpdateBoPhan.Text = "Update";
            this.btnUpdateBoPhan.UseVisualStyleBackColor = true;
            this.btnUpdateBoPhan.Click += new System.EventHandler(this.btnUpdateBoPhan_Click);
            // 
            // txtMaBP
            // 
            this.txtMaBP.Location = new System.Drawing.Point(24, 31);
            this.txtMaBP.Name = "txtMaBP";
            this.txtMaBP.Size = new System.Drawing.Size(67, 20);
            this.txtMaBP.TabIndex = 18;
            // 
            // btnRefeshBoPhan
            // 
            this.btnRefeshBoPhan.Location = new System.Drawing.Point(319, 14);
            this.btnRefeshBoPhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefeshBoPhan.Name = "btnRefeshBoPhan";
            this.btnRefeshBoPhan.Size = new System.Drawing.Size(85, 40);
            this.btnRefeshBoPhan.TabIndex = 19;
            this.btnRefeshBoPhan.Text = "Refesh";
            this.btnRefeshBoPhan.UseVisualStyleBackColor = true;
            this.btnRefeshBoPhan.Click += new System.EventHandler(this.btnRefeshBoPhan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteAll);
            this.groupBox1.Controls.Add(this.dtgvQLBP);
            this.groupBox1.Controls.Add(this.btnRefeshBoPhan);
            this.groupBox1.Controls.Add(this.txtMaBP);
            this.groupBox1.Controls.Add(this.btnDeleteBoPhan);
            this.groupBox1.Controls.Add(this.btnUpdateBoPhan);
            this.groupBox1.Controls.Add(this.txtThemBoPhan);
            this.groupBox1.Controls.Add(this.btnInsertBP);
            this.groupBox1.Location = new System.Drawing.Point(22, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 384);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ Phận";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(310, 64);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(94, 40);
            this.btnDeleteAll.TabIndex = 20;
            this.btnDeleteAll.Text = "DeleteAll";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            // 
            // UCQuanLiBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.Button btnSearchBoPhan;
        private System.Windows.Forms.TextBox txtTKBoPhan;
        private System.Windows.Forms.Button btnDeleteBoPhan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtThemBoPhan;
        private System.Windows.Forms.Button btnInsertBP;
        private System.Windows.Forms.Button btnUpdateBoPhan;
        private System.Windows.Forms.TextBox txtMaBP;
        private System.Windows.Forms.Button btnRefeshBoPhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteAll;
    }
}
