namespace Bai4
{
    partial class FrmBai4_1
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnTính = new System.Windows.Forms.Button();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txts = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "s";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnTính
            // 
            this.btnTính.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTính.Location = new System.Drawing.Point(223, 243);
            this.btnTính.Name = "btnTính";
            this.btnTính.Size = new System.Drawing.Size(140, 44);
            this.btnTính.TabIndex = 2;
            this.btnTính.Text = "Tính";
            this.btnTính.UseVisualStyleBackColor = true;
            this.btnTính.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(223, 103);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(247, 20);
            this.txtn.TabIndex = 3;
            this.txtn.TextChanged += new System.EventHandler(this.txtn_TextChanged);
            // 
            // txts
            // 
            this.txts.Location = new System.Drawing.Point(223, 183);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(247, 20);
            this.txts.TabIndex = 4;
            this.txts.TextChanged += new System.EventHandler(this.txts_TextChanged);
            // 
            // FrmBai4_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.btnTính);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBai4_1";
            this.Text = "FrmBai4_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTính;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txts;
    }
}