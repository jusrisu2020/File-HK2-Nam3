namespace Bai3
{
    partial class Form2
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
            this.lstweb = new System.Windows.Forms.ListBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstweb
            // 
            this.lstweb.FormattingEnabled = true;
            this.lstweb.Location = new System.Drawing.Point(87, 122);
            this.lstweb.Name = "lstweb";
            this.lstweb.Size = new System.Drawing.Size(156, 95);
            this.lstweb.TabIndex = 13;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(313, 122);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKQ.Size = new System.Drawing.Size(240, 95);
            this.txtKQ.TabIndex = 12;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(168, 243);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 11;
            this.btnreset.Text = "reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(87, 243);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 10;
            this.btnok.Text = "ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Liên kết website";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstweb);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstweb;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label1;
    }
}