namespace Buoi5_Bai4_5
{
    partial class Form1
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
            this.lblMang = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnXM = new System.Windows.Forms.Button();
            this.btnTimNN = new System.Windows.Forms.Button();
            this.btnTangPT = new System.Windows.Forms.Button();
            this.btnSXT = new System.Windows.Forms.Button();
            this.btnSXG = new System.Windows.Forms.Button();
            this.btnTongle = new System.Windows.Forms.Button();
            this.btnDemle = new System.Windows.Forms.Button();
            this.btnTongM = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMang
            // 
            this.lblMang.AutoSize = true;
            this.lblMang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMang.Location = new System.Drawing.Point(34, 42);
            this.lblMang.MaximumSize = new System.Drawing.Size(200, 150);
            this.lblMang.MinimumSize = new System.Drawing.Size(400, 30);
            this.lblMang.Name = "lblMang";
            this.lblMang.Size = new System.Drawing.Size(400, 30);
            this.lblMang.TabIndex = 0;
            this.lblMang.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMang);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng Gốc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblKQ);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(52, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 91);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblKQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(34, 42);
            this.lblKQ.MaximumSize = new System.Drawing.Size(200, 150);
            this.lblKQ.MinimumSize = new System.Drawing.Size(400, 30);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(400, 30);
            this.lblKQ.TabIndex = 0;
            // 
            // btnXM
            // 
            this.btnXM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXM.Location = new System.Drawing.Point(58, 283);
            this.btnXM.Name = "btnXM";
            this.btnXM.Size = new System.Drawing.Size(211, 39);
            this.btnXM.TabIndex = 3;
            this.btnXM.Text = "Xuất Mảng Ngẩu Nhiên";
            this.btnXM.UseVisualStyleBackColor = true;
            this.btnXM.Click += new System.EventHandler(this.btnXM_Click);
            // 
            // btnTimNN
            // 
            this.btnTimNN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNN.Location = new System.Drawing.Point(295, 274);
            this.btnTimNN.Name = "btnTimNN";
            this.btnTimNN.Size = new System.Drawing.Size(211, 39);
            this.btnTimNN.TabIndex = 4;
            this.btnTimNN.Text = "Tìm phần tử nhỏ nhất";
            this.btnTimNN.UseVisualStyleBackColor = true;
            this.btnTimNN.Click += new System.EventHandler(this.btnTimNN_Click);
            // 
            // btnTangPT
            // 
            this.btnTangPT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangPT.Location = new System.Drawing.Point(295, 328);
            this.btnTangPT.Name = "btnTangPT";
            this.btnTangPT.Size = new System.Drawing.Size(211, 39);
            this.btnTangPT.TabIndex = 5;
            this.btnTangPT.Text = "Tăng mỗi Ptử mảng lên 2";
            this.btnTangPT.UseVisualStyleBackColor = true;
            this.btnTangPT.Click += new System.EventHandler(this.btnTangPT_Click);
            // 
            // btnSXT
            // 
            this.btnSXT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSXT.Location = new System.Drawing.Point(295, 373);
            this.btnSXT.Name = "btnSXT";
            this.btnSXT.Size = new System.Drawing.Size(211, 39);
            this.btnSXT.TabIndex = 6;
            this.btnSXT.Text = "Sắp mảng tăng";
            this.btnSXT.UseVisualStyleBackColor = true;
            this.btnSXT.Click += new System.EventHandler(this.btnSXT_Click);
            // 
            // btnSXG
            // 
            this.btnSXG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSXG.Location = new System.Drawing.Point(295, 418);
            this.btnSXG.Name = "btnSXG";
            this.btnSXG.Size = new System.Drawing.Size(211, 39);
            this.btnSXG.TabIndex = 7;
            this.btnSXG.Text = "Sắp mảng giảm";
            this.btnSXG.UseVisualStyleBackColor = true;
            this.btnSXG.Click += new System.EventHandler(this.btnSXG_Click);
            // 
            // btnTongle
            // 
            this.btnTongle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongle.Location = new System.Drawing.Point(58, 418);
            this.btnTongle.Name = "btnTongle";
            this.btnTongle.Size = new System.Drawing.Size(211, 39);
            this.btnTongle.TabIndex = 8;
            this.btnTongle.Text = "Tổng Giá Trị Phần tử lẻ";
            this.btnTongle.UseVisualStyleBackColor = true;
            this.btnTongle.Click += new System.EventHandler(this.btnTongle_Click);
            // 
            // btnDemle
            // 
            this.btnDemle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemle.Location = new System.Drawing.Point(58, 373);
            this.btnDemle.Name = "btnDemle";
            this.btnDemle.Size = new System.Drawing.Size(211, 39);
            this.btnDemle.TabIndex = 9;
            this.btnDemle.Text = "Đếm số phần tử lẻ";
            this.btnDemle.UseVisualStyleBackColor = true;
            this.btnDemle.Click += new System.EventHandler(this.btnDemle_Click);
            // 
            // btnTongM
            // 
            this.btnTongM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongM.Location = new System.Drawing.Point(58, 328);
            this.btnTongM.Name = "btnTongM";
            this.btnTongM.Size = new System.Drawing.Size(211, 39);
            this.btnTongM.TabIndex = 10;
            this.btnTongM.Text = "Tính Tổng Giá Trị Mảng";
            this.btnTongM.UseVisualStyleBackColor = true;
            this.btnTongM.Click += new System.EventHandler(this.btnTongM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.btnTongM);
            this.Controls.Add(this.btnDemle);
            this.Controls.Add(this.btnTongle);
            this.Controls.Add(this.btnSXG);
            this.Controls.Add(this.btnSXT);
            this.Controls.Add(this.btnTangPT);
            this.Controls.Add(this.btnTimNN);
            this.Controls.Add(this.btnXM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnXM;
        private System.Windows.Forms.Button btnTimNN;
        private System.Windows.Forms.Button btnTangPT;
        private System.Windows.Forms.Button btnSXT;
        private System.Windows.Forms.Button btnSXG;
        private System.Windows.Forms.Button btnTongle;
        private System.Windows.Forms.Button btnDemle;
        private System.Windows.Forms.Button btnTongM;
    }
}

