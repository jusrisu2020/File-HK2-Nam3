namespace Bai3
{
    partial class Form3
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
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.cmbWeb = new System.Windows.Forms.ComboBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(117, 170);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(295, 102);
            this.txtKQ.TabIndex = 15;
            // 
            // cmbWeb
            // 
            this.cmbWeb.FormattingEnabled = true;
            this.cmbWeb.Location = new System.Drawing.Point(117, 98);
            this.cmbWeb.Name = "cmbWeb";
            this.cmbWeb.Size = new System.Drawing.Size(121, 21);
            this.cmbWeb.TabIndex = 14;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(342, 98);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(70, 23);
            this.btnreset.TabIndex = 13;
            this.btnreset.Text = "reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(266, 98);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(70, 23);
            this.btnok.TabIndex = 12;
            this.btnok.Text = "ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Liên kết website";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.cmbWeb);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.ComboBox cmbWeb;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label1;
    }
}