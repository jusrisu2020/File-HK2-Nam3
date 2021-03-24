namespace Bai2._1
{
    partial class frmBai2_10
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDuongCheo = new System.Windows.Forms.Button();
            this.btnDienTich = new System.Windows.Forms.Button();
            this.btnChuVi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.Location = new System.Drawing.Point(483, 235);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 56);
            this.btnThoat.TabIndex = 37;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDuongCheo
            // 
            this.btnDuongCheo.Location = new System.Drawing.Point(362, 235);
            this.btnDuongCheo.Name = "btnDuongCheo";
            this.btnDuongCheo.Size = new System.Drawing.Size(97, 56);
            this.btnDuongCheo.TabIndex = 36;
            this.btnDuongCheo.Text = "Duong Cheo";
            this.btnDuongCheo.UseVisualStyleBackColor = true;
            this.btnDuongCheo.Click += new System.EventHandler(this.btnDuongCheo_Click);
            // 
            // btnDienTich
            // 
            this.btnDienTich.Location = new System.Drawing.Point(239, 235);
            this.btnDienTich.Name = "btnDienTich";
            this.btnDienTich.Size = new System.Drawing.Size(97, 56);
            this.btnDienTich.TabIndex = 35;
            this.btnDienTich.Text = "Dien Tich";
            this.btnDienTich.UseVisualStyleBackColor = true;
            this.btnDienTich.Click += new System.EventHandler(this.btnDienTich_Click);
            // 
            // btnChuVi
            // 
            this.btnChuVi.Location = new System.Drawing.Point(116, 235);
            this.btnChuVi.Name = "btnChuVi";
            this.btnChuVi.Size = new System.Drawing.Size(97, 56);
            this.btnChuVi.TabIndex = 34;
            this.btnChuVi.Text = "Chu vi";
            this.btnChuVi.UseVisualStyleBackColor = true;
            this.btnChuVi.Click += new System.EventHandler(this.btnChuVi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoB);
            this.groupBox1.Controls.Add(this.txtSoA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(153, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 117);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(101, 64);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(100, 20);
            this.txtSoB.TabIndex = 4;
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(101, 24);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(100, 20);
            this.txtSoA.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "a: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 36);
            this.label1.TabIndex = 32;
            this.label1.Text = "Hinh Chu Nhat";
            // 
            // frmBai2_10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDuongCheo);
            this.Controls.Add(this.btnDienTich);
            this.Controls.Add(this.btnChuVi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2_10";
            this.Text = "frmBai2_10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDuongCheo;
        private System.Windows.Forms.Button btnDienTich;
        private System.Windows.Forms.Button btnChuVi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}