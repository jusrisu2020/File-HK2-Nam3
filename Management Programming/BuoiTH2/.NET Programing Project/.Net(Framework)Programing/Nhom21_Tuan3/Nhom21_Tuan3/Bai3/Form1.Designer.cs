namespace Bai3
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
            this.btnreset = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstweb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(180, 218);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 9;
            this.btnreset.Text = "reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(315, 110);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKQ.Size = new System.Drawing.Size(231, 131);
            this.txtKQ.TabIndex = 8;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(99, 218);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 7;
            this.btnok.Text = "ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Liên kết website";
            // 
            // lstweb
            // 
            this.lstweb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstweb.FormattingEnabled = true;
            this.lstweb.ItemHeight = 21;
            this.lstweb.Items.AddRange(new object[] {
            "- Tuổi trẻ.",
            "- Thanh niên.",
            "- VNExpress.",
            "- Dân trí.",
            "- Công an."});
            this.lstweb.Location = new System.Drawing.Point(99, 110);
            this.lstweb.Name = "lstweb";
            this.lstweb.Size = new System.Drawing.Size(138, 67);
            this.lstweb.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstweb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstweb;
    }
}

