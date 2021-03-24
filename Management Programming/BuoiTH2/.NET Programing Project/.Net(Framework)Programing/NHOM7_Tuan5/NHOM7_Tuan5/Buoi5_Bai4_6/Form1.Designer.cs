namespace Buoi5_Bai4_6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoMin = new System.Windows.Forms.RadioButton();
            this.grpSoLe = new System.Windows.Forms.GroupBox();
            this.rdoSLLe = new System.Windows.Forms.RadioButton();
            this.rdoTongL = new System.Windows.Forms.RadioButton();
            this.grpSoChan = new System.Windows.Forms.GroupBox();
            this.rdoSLChan = new System.Windows.Forms.RadioButton();
            this.rdoChanCC = new System.Windows.Forms.RadioButton();
            this.rdoTongC = new System.Windows.Forms.RadioButton();
            this.rdoLKChan = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnXuatM = new System.Windows.Forms.Button();
            this.btnRS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpSoLe.SuspendLayout();
            this.grpSoChan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoMin);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(739, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 126);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng";
            // 
            // rdoMin
            // 
            this.rdoMin.AutoSize = true;
            this.rdoMin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMin.Location = new System.Drawing.Point(6, 42);
            this.rdoMin.Name = "rdoMin";
            this.rdoMin.Size = new System.Drawing.Size(112, 26);
            this.rdoMin.TabIndex = 9;
            this.rdoMin.TabStop = true;
            this.rdoMin.Text = "Min Mảng";
            this.rdoMin.UseVisualStyleBackColor = true;
            this.rdoMin.CheckedChanged += new System.EventHandler(this.rdoMin_CheckedChanged);
            // 
            // grpSoLe
            // 
            this.grpSoLe.Controls.Add(this.rdoSLLe);
            this.grpSoLe.Controls.Add(this.rdoTongL);
            this.grpSoLe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSoLe.Location = new System.Drawing.Point(500, 199);
            this.grpSoLe.Name = "grpSoLe";
            this.grpSoLe.Size = new System.Drawing.Size(202, 126);
            this.grpSoLe.TabIndex = 15;
            this.grpSoLe.TabStop = false;
            this.grpSoLe.Text = "Số Lẻ";
            // 
            // rdoSLLe
            // 
            this.rdoSLLe.AutoSize = true;
            this.rdoSLLe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSLLe.Location = new System.Drawing.Point(17, 77);
            this.rdoSLLe.Name = "rdoSLLe";
            this.rdoSLLe.Size = new System.Drawing.Size(159, 26);
            this.rdoSLLe.TabIndex = 3;
            this.rdoSLLe.TabStop = true;
            this.rdoSLLe.Text = "Số Lượng Số Lẻ";
            this.rdoSLLe.UseVisualStyleBackColor = true;
            this.rdoSLLe.CheckedChanged += new System.EventHandler(this.rdoSLLe_CheckedChanged);
            // 
            // rdoTongL
            // 
            this.rdoTongL.AutoSize = true;
            this.rdoTongL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTongL.Location = new System.Drawing.Point(15, 42);
            this.rdoTongL.Name = "rdoTongL";
            this.rdoTongL.Size = new System.Drawing.Size(158, 26);
            this.rdoTongL.TabIndex = 3;
            this.rdoTongL.TabStop = true;
            this.rdoTongL.Text = "Tổng Các Số Lẻ";
            this.rdoTongL.UseVisualStyleBackColor = true;
            this.rdoTongL.CheckedChanged += new System.EventHandler(this.rdoTongL_CheckedChanged);
            // 
            // grpSoChan
            // 
            this.grpSoChan.Controls.Add(this.rdoSLChan);
            this.grpSoChan.Controls.Add(this.rdoChanCC);
            this.grpSoChan.Controls.Add(this.rdoTongC);
            this.grpSoChan.Controls.Add(this.rdoLKChan);
            this.grpSoChan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSoChan.Location = new System.Drawing.Point(22, 199);
            this.grpSoChan.Name = "grpSoChan";
            this.grpSoChan.Size = new System.Drawing.Size(458, 126);
            this.grpSoChan.TabIndex = 16;
            this.grpSoChan.TabStop = false;
            this.grpSoChan.Text = "Số Chẵn";
            // 
            // rdoSLChan
            // 
            this.rdoSLChan.AutoSize = true;
            this.rdoSLChan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSLChan.Location = new System.Drawing.Point(252, 77);
            this.rdoSLChan.Name = "rdoSLChan";
            this.rdoSLChan.Size = new System.Drawing.Size(179, 26);
            this.rdoSLChan.TabIndex = 4;
            this.rdoSLChan.TabStop = true;
            this.rdoSLChan.Text = "Số Lượng Số Chẵn";
            this.rdoSLChan.UseVisualStyleBackColor = true;
            this.rdoSLChan.CheckedChanged += new System.EventHandler(this.rdoSLChan_CheckedChanged);
            // 
            // rdoChanCC
            // 
            this.rdoChanCC.AutoSize = true;
            this.rdoChanCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChanCC.Location = new System.Drawing.Point(25, 77);
            this.rdoChanCC.Name = "rdoChanCC";
            this.rdoChanCC.Size = new System.Drawing.Size(186, 26);
            this.rdoChanCC.TabIndex = 3;
            this.rdoChanCC.TabStop = true;
            this.rdoChanCC.Text = "Số Chẵn Cuối Cùng";
            this.rdoChanCC.UseVisualStyleBackColor = true;
            this.rdoChanCC.CheckedChanged += new System.EventHandler(this.rdoChanCC_CheckedChanged);
            // 
            // rdoTongC
            // 
            this.rdoTongC.AutoSize = true;
            this.rdoTongC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTongC.Location = new System.Drawing.Point(250, 42);
            this.rdoTongC.Name = "rdoTongC";
            this.rdoTongC.Size = new System.Drawing.Size(178, 26);
            this.rdoTongC.TabIndex = 3;
            this.rdoTongC.TabStop = true;
            this.rdoTongC.Text = "Tổng Các Số Chẵn";
            this.rdoTongC.UseVisualStyleBackColor = true;
            this.rdoTongC.CheckedChanged += new System.EventHandler(this.rdoTongC_CheckedChanged);
            // 
            // rdoLKChan
            // 
            this.rdoLKChan.AutoSize = true;
            this.rdoLKChan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLKChan.Location = new System.Drawing.Point(25, 42);
            this.rdoLKChan.Name = "rdoLKChan";
            this.rdoLKChan.Size = new System.Drawing.Size(161, 26);
            this.rdoLKChan.TabIndex = 3;
            this.rdoLKChan.TabStop = true;
            this.rdoLKChan.Text = "Liệt Kê Số Chẵn";
            this.rdoLKChan.UseVisualStyleBackColor = true;
            this.rdoLKChan.CheckedChanged += new System.EventHandler(this.rdoLKChan_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kết quả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(264, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 43);
            this.label3.TabIndex = 20;
            this.label3.Text = "MẢNG SỐ NGUYÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(45, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nhập mảng:";
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(199, 153);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(521, 30);
            this.txtKQ.TabIndex = 19;
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(199, 86);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(521, 30);
            this.txtNhap.TabIndex = 18;
            // 
            // btnXuatM
            // 
            this.btnXuatM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatM.Location = new System.Drawing.Point(739, 81);
            this.btnXuatM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXuatM.Name = "btnXuatM";
            this.btnXuatM.Size = new System.Drawing.Size(107, 38);
            this.btnXuatM.TabIndex = 23;
            this.btnXuatM.Text = "Xuất Mảng";
            this.btnXuatM.UseVisualStyleBackColor = true;
            this.btnXuatM.Click += new System.EventHandler(this.btnXuatM_Click);
            // 
            // btnRS
            // 
            this.btnRS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRS.Location = new System.Drawing.Point(739, 145);
            this.btnRS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRS.Name = "btnRS";
            this.btnRS.Size = new System.Drawing.Size(107, 38);
            this.btnRS.TabIndex = 24;
            this.btnRS.Text = "Reset";
            this.btnRS.UseVisualStyleBackColor = true;
            this.btnRS.Click += new System.EventHandler(this.btnRS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.btnRS);
            this.Controls.Add(this.btnXuatM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSoLe);
            this.Controls.Add(this.grpSoChan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSoLe.ResumeLayout(false);
            this.grpSoLe.PerformLayout();
            this.grpSoChan.ResumeLayout(false);
            this.grpSoChan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoMin;
        private System.Windows.Forms.GroupBox grpSoLe;
        private System.Windows.Forms.RadioButton rdoSLLe;
        private System.Windows.Forms.RadioButton rdoTongL;
        private System.Windows.Forms.GroupBox grpSoChan;
        private System.Windows.Forms.RadioButton rdoSLChan;
        private System.Windows.Forms.RadioButton rdoChanCC;
        private System.Windows.Forms.RadioButton rdoTongC;
        private System.Windows.Forms.RadioButton rdoLKChan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnXuatM;
        private System.Windows.Forms.Button btnRS;
    }
}

