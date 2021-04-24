
namespace QLTSTBKhachSan
{
    partial class FBoPhan
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
            this.txtThemBoPhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemBoPhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtThemBoPhan
            // 
            this.txtThemBoPhan.Location = new System.Drawing.Point(140, 85);
            this.txtThemBoPhan.Name = "txtThemBoPhan";
            this.txtThemBoPhan.Size = new System.Drawing.Size(172, 22);
            this.txtThemBoPhan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Bộ Phận";
            // 
            // btnThemBoPhan
            // 
            this.btnThemBoPhan.Location = new System.Drawing.Point(384, 73);
            this.btnThemBoPhan.Name = "btnThemBoPhan";
            this.btnThemBoPhan.Size = new System.Drawing.Size(121, 47);
            this.btnThemBoPhan.TabIndex = 2;
            this.btnThemBoPhan.Text = "Thêm Bộ Phận";
            this.btnThemBoPhan.UseVisualStyleBackColor = true;
            this.btnThemBoPhan.Click += new System.EventHandler(this.btnThemBoPhan_Click);
            // 
            // FBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 246);
            this.Controls.Add(this.btnThemBoPhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThemBoPhan);
            this.Name = "FBoPhan";
            this.Text = "Bộ phận";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThemBoPhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemBoPhan;
    }
}