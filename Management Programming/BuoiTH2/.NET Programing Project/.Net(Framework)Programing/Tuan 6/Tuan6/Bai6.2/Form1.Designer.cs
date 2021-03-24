namespace Bai6._2
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
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radA = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.ListBox();
            this.lbB = new System.Windows.Forms.ListBox();
            this.btnAB = new System.Windows.Forms.Button();
            this.btnBA = new System.Windows.Forms.Button();
            this.btnAllAB = new System.Windows.Forms.Button();
            this.btnAllBA = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(83, 13);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(246, 20);
            this.txtAdd.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(344, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radB);
            this.groupBox1.Controls.Add(this.radA);
            this.groupBox1.Location = new System.Drawing.Point(108, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 53);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Class";
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Location = new System.Drawing.Point(22, 19);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(60, 17);
            this.radA.TabIndex = 4;
            this.radA.TabStop = true;
            this.radA.Text = "Class A";
            this.radA.UseVisualStyleBackColor = true;
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.Location = new System.Drawing.Point(121, 19);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(60, 17);
            this.radB.TabIndex = 5;
            this.radB.TabStop = true;
            this.radB.Text = "Class B";
            this.radB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Class A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class B";
            // 
            // lbA
            // 
            this.lbA.FormattingEnabled = true;
            this.lbA.Location = new System.Drawing.Point(10, 144);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(160, 238);
            this.lbA.TabIndex = 6;
            // 
            // lbB
            // 
            this.lbB.FormattingEnabled = true;
            this.lbB.Location = new System.Drawing.Point(260, 144);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(160, 238);
            this.lbB.TabIndex = 7;
            // 
            // btnAB
            // 
            this.btnAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAB.Location = new System.Drawing.Point(179, 151);
            this.btnAB.Name = "btnAB";
            this.btnAB.Size = new System.Drawing.Size(75, 51);
            this.btnAB.TabIndex = 8;
            this.btnAB.Text = ">";
            this.btnAB.UseVisualStyleBackColor = true;
            this.btnAB.Click += new System.EventHandler(this.btnAB_Click);
            // 
            // btnBA
            // 
            this.btnBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBA.Location = new System.Drawing.Point(179, 208);
            this.btnBA.Name = "btnBA";
            this.btnBA.Size = new System.Drawing.Size(75, 51);
            this.btnBA.TabIndex = 9;
            this.btnBA.Text = "<";
            this.btnBA.UseVisualStyleBackColor = true;
            this.btnBA.Click += new System.EventHandler(this.btnBA_Click);
            // 
            // btnAllAB
            // 
            this.btnAllAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllAB.Location = new System.Drawing.Point(179, 265);
            this.btnAllAB.Name = "btnAllAB";
            this.btnAllAB.Size = new System.Drawing.Size(75, 51);
            this.btnAllAB.TabIndex = 10;
            this.btnAllAB.Text = ">>";
            this.btnAllAB.UseVisualStyleBackColor = true;
            this.btnAllAB.Click += new System.EventHandler(this.btnAllAB_Click);
            // 
            // btnAllBA
            // 
            this.btnAllBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllBA.Location = new System.Drawing.Point(179, 322);
            this.btnAllBA.Name = "btnAllBA";
            this.btnAllBA.Size = new System.Drawing.Size(75, 51);
            this.btnAllBA.TabIndex = 11;
            this.btnAllBA.Text = "<<";
            this.btnAllBA.UseVisualStyleBackColor = true;
            this.btnAllBA.Click += new System.EventHandler(this.btnAllBA_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(63, 403);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(122, 51);
            this.btnTong.TabIndex = 12;
            this.btnTong.Text = "Sumation Student";
            this.btnTong.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(250, 403);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 51);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 470);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnAllBA);
            this.Controls.Add(this.btnAllAB);
            this.Controls.Add(this.btnBA);
            this.Controls.Add(this.btnAB);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbA;
        private System.Windows.Forms.ListBox lbB;
        private System.Windows.Forms.Button btnAB;
        private System.Windows.Forms.Button btnBA;
        private System.Windows.Forms.Button btnAllAB;
        private System.Windows.Forms.Button btnAllBA;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnExit;
    }
}

