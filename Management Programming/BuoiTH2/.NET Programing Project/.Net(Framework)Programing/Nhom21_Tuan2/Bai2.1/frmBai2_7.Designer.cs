namespace Bai2._1
{
    partial class frmBai2_7
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
            this.btnTong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHieu = new System.Windows.Forms.Button();
            this.btnThuong = new System.Windows.Forms.Button();
            this.btnTich = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(25, 239);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(97, 56);
            this.btnTong.TabIndex = 12;
            this.btnTong.Text = "Tong";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoB);
            this.groupBox1.Controls.Add(this.txtSoA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(62, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 117);
            this.groupBox1.TabIndex = 11;
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
            this.label1.Location = new System.Drawing.Point(103, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "PHEP TOAN ";
            // 
            // btnHieu
            // 
            this.btnHieu.Location = new System.Drawing.Point(148, 239);
            this.btnHieu.Name = "btnHieu";
            this.btnHieu.Size = new System.Drawing.Size(97, 56);
            this.btnHieu.TabIndex = 13;
            this.btnHieu.Text = "Hieu";
            this.btnHieu.UseVisualStyleBackColor = true;
            this.btnHieu.Click += new System.EventHandler(this.btnHieu_Click);
            // 
            // btnThuong
            // 
            this.btnThuong.Location = new System.Drawing.Point(271, 239);
            this.btnThuong.Name = "btnThuong";
            this.btnThuong.Size = new System.Drawing.Size(97, 56);
            this.btnThuong.TabIndex = 14;
            this.btnThuong.Text = "Thuong";
            this.btnThuong.UseVisualStyleBackColor = true;
            this.btnThuong.Click += new System.EventHandler(this.btnThuong_Click);
            // 
            // btnTich
            // 
            this.btnTich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTich.Location = new System.Drawing.Point(392, 239);
            this.btnTich.Name = "btnTich";
            this.btnTich.Size = new System.Drawing.Size(97, 56);
            this.btnTich.TabIndex = 15;
            this.btnTich.Text = "Tich";
            this.btnTich.UseVisualStyleBackColor = true;
            this.btnTich.Click += new System.EventHandler(this.btnTich_Click);
            // 
            // frmBai2_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTich);
            this.Controls.Add(this.btnThuong);
            this.Controls.Add(this.btnHieu);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2_7";
            this.Text = "frmBai2_7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHieu;
        private System.Windows.Forms.Button btnThuong;
        private System.Windows.Forms.Button btnTich;
    }
}