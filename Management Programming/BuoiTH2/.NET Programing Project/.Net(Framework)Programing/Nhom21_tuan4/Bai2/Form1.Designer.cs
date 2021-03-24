namespace Bai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnTaomang = new System.Windows.Forms.Button();
            this.btnInmang = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(45, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số phần tử mảng";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(300, 66);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(100, 20);
            this.txtNhap.TabIndex = 1;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // btnTaomang
            // 
            this.btnTaomang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaomang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTaomang.Location = new System.Drawing.Point(420, 56);
            this.btnTaomang.Name = "btnTaomang";
            this.btnTaomang.Size = new System.Drawing.Size(171, 41);
            this.btnTaomang.TabIndex = 2;
            this.btnTaomang.Text = "Tạo mảng Random";
            this.btnTaomang.UseVisualStyleBackColor = true;
            this.btnTaomang.Click += new System.EventHandler(this.btnTaomang_Click);
            // 
            // btnInmang
            // 
            this.btnInmang.Enabled = false;
            this.btnInmang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInmang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnInmang.Location = new System.Drawing.Point(125, 230);
            this.btnInmang.Name = "btnInmang";
            this.btnInmang.Size = new System.Drawing.Size(88, 46);
            this.btnInmang.TabIndex = 18;
            this.btnInmang.Text = "In mảng";
            this.btnInmang.UseVisualStyleBackColor = true;
            this.btnInmang.Click += new System.EventHandler(this.btnInmang_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(376, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 46);
            this.button3.TabIndex = 19;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.BackColor = System.Drawing.Color.Salmon;
            this.lblKQ.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKQ.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblKQ.Location = new System.Drawing.Point(68, 100);
            this.lblKQ.MinimumSize = new System.Drawing.Size(500, 100);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(500, 100);
            this.lblKQ.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnInmang);
            this.Controls.Add(this.btnTaomang);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnTaomang;
        private System.Windows.Forms.Button btnInmang;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblKQ;
    }
}

