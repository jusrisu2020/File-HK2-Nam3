
namespace TaoButtonTuDong
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
            this.btnTaoButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaoButton
            // 
            this.btnTaoButton.Location = new System.Drawing.Point(98, 95);
            this.btnTaoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaoButton.Name = "btnTaoButton";
            this.btnTaoButton.Size = new System.Drawing.Size(94, 23);
            this.btnTaoButton.TabIndex = 0;
            this.btnTaoButton.Text = "Tạo Button";
            this.btnTaoButton.UseVisualStyleBackColor = true;
            this.btnTaoButton.Click += new System.EventHandler(this.btnTaoButton_Click);
            this.btnTaoButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTaoButton_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 131);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTaoButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaoButton;
        private System.Windows.Forms.Button button2;
    }
}

