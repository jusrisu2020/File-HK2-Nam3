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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radB = new System.Windows.Forms.RadioButton();
            this.radA = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbA = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbB = new System.Windows.Forms.ListBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labNot = new System.Windows.Forms.Label();
            this.labNot1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAB = new System.Windows.Forms.Button();
            this.btnallBA = new System.Windows.Forms.Button();
            this.btnallAB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Franko", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(74, 37);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(301, 20);
            this.txtNhap.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(716, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 66);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseMnemonic = false;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            this.btnAdd.Enter += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.radB);
            this.groupBox1.Controls.Add(this.radA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(620, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Class";
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.Location = new System.Drawing.Point(109, 31);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(80, 21);
            this.radB.TabIndex = 1;
            this.radB.TabStop = true;
            this.radB.Text = "Class B";
            this.radB.UseVisualStyleBackColor = true;
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Location = new System.Drawing.Point(17, 31);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(80, 21);
            this.radA.TabIndex = 0;
            this.radA.TabStop = true;
            this.radA.Text = "Class A";
            this.radA.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbA);
            this.groupBox2.Location = new System.Drawing.Point(237, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 251);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Class A";
            // 
            // lbA
            // 
            this.lbA.FormattingEnabled = true;
            this.lbA.Location = new System.Drawing.Point(6, 19);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(210, 212);
            this.lbA.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbB);
            this.groupBox3.Location = new System.Drawing.Point(472, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 250);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Class B";
            // 
            // lbB
            // 
            this.lbB.FormattingEnabled = true;
            this.lbB.Location = new System.Drawing.Point(8, 19);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(209, 212);
            this.lbB.TabIndex = 0;
            // 
            // btnTotal
            // 
            this.btnTotal.Image = ((System.Drawing.Image)(resources.GetObject("btnTotal.Image")));
            this.btnTotal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTotal.Location = new System.Drawing.Point(716, 268);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(89, 66);
            this.btnTotal.TabIndex = 10;
            this.btnTotal.Text = "Total  Students";
            this.btnTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            this.btnTotal.MouseEnter += new System.EventHandler(this.btnTotal_MouseEnter);
            this.btnTotal.MouseLeave += new System.EventHandler(this.btnTotal_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(716, 498);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 66);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // labNot
            // 
            this.labNot.AutoSize = true;
            this.labNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNot.ForeColor = System.Drawing.Color.Red;
            this.labNot.Location = new System.Drawing.Point(298, 161);
            this.labNot.Name = "labNot";
            this.labNot.Size = new System.Drawing.Size(11, 13);
            this.labNot.TabIndex = 12;
            this.labNot.Text = " ";
            // 
            // labNot1
            // 
            this.labNot1.AutoSize = true;
            this.labNot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNot1.ForeColor = System.Drawing.Color.Red;
            this.labNot1.Location = new System.Drawing.Point(647, 161);
            this.labNot1.Name = "labNot1";
            this.labNot1.Size = new System.Drawing.Size(11, 13);
            this.labNot1.TabIndex = 13;
            this.labNot1.Text = " ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNhap);
            this.panel1.Location = new System.Drawing.Point(223, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 67);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(217, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 81);
            this.panel3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(93, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "STUDENT MANAGEMENT";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.BlueViolet;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.btnAB);
            this.panel4.Controls.Add(this.btnallBA);
            this.panel4.Controls.Add(this.btnallAB);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.btnBA);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 616);
            this.panel4.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(68, 486);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btnAB
            // 
            this.btnAB.AutoSize = true;
            this.btnAB.BackColor = System.Drawing.Color.White;
            this.btnAB.FlatAppearance.BorderSize = 0;
            this.btnAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAB.Image = ((System.Drawing.Image)(resources.GetObject("btnAB.Image")));
            this.btnAB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAB.Location = new System.Drawing.Point(16, 214);
            this.btnAB.Name = "btnAB";
            this.btnAB.Size = new System.Drawing.Size(190, 54);
            this.btnAB.TabIndex = 19;
            this.btnAB.Text = "AB";
            this.btnAB.UseVisualStyleBackColor = false;
            this.btnAB.MouseEnter += new System.EventHandler(this.btnAB_MouseEnter_1);
            this.btnAB.MouseLeave += new System.EventHandler(this.btnAB_MouseLeave_1);
            // 
            // btnallBA
            // 
            this.btnallBA.AutoSize = true;
            this.btnallBA.BackColor = System.Drawing.Color.White;
            this.btnallBA.FlatAppearance.BorderSize = 0;
            this.btnallBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnallBA.Image = ((System.Drawing.Image)(resources.GetObject("btnallBA.Image")));
            this.btnallBA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnallBA.Location = new System.Drawing.Point(16, 378);
            this.btnallBA.Name = "btnallBA";
            this.btnallBA.Size = new System.Drawing.Size(190, 54);
            this.btnallBA.TabIndex = 9;
            this.btnallBA.Text = "BA";
            this.btnallBA.UseVisualStyleBackColor = false;
            this.btnallBA.Click += new System.EventHandler(this.btnallBA_Click);
            this.btnallBA.MouseEnter += new System.EventHandler(this.btnallBA_MouseEnter);
            this.btnallBA.MouseLeave += new System.EventHandler(this.btnallBA_MouseLeave);
            // 
            // btnallAB
            // 
            this.btnallAB.AutoSize = true;
            this.btnallAB.BackColor = System.Drawing.Color.White;
            this.btnallAB.FlatAppearance.BorderSize = 0;
            this.btnallAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnallAB.Image = ((System.Drawing.Image)(resources.GetObject("btnallAB.Image")));
            this.btnallAB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnallAB.Location = new System.Drawing.Point(16, 323);
            this.btnallAB.Name = "btnallAB";
            this.btnallAB.Size = new System.Drawing.Size(190, 54);
            this.btnallAB.TabIndex = 8;
            this.btnallAB.Text = "AB";
            this.btnallAB.UseVisualStyleBackColor = false;
            this.btnallAB.Click += new System.EventHandler(this.btnallAB_Click);
            this.btnallAB.MouseEnter += new System.EventHandler(this.btnallAB_MouseEnter);
            this.btnallAB.MouseLeave += new System.EventHandler(this.btnallAB_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnBA
            // 
            this.btnBA.AutoSize = true;
            this.btnBA.BackColor = System.Drawing.Color.White;
            this.btnBA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBA.BackgroundImage")));
            this.btnBA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBA.FlatAppearance.BorderSize = 0;
            this.btnBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBA.Location = new System.Drawing.Point(16, 268);
            this.btnBA.Name = "btnBA";
            this.btnBA.Size = new System.Drawing.Size(190, 48);
            this.btnBA.TabIndex = 7;
            this.btnBA.Text = "AB";
            this.btnBA.UseVisualStyleBackColor = false;
            this.btnBA.Click += new System.EventHandler(this.btnBA_Click);
            this.btnBA.MouseEnter += new System.EventHandler(this.btnBA_MouseEnter);
            this.btnBA.MouseLeave += new System.EventHandler(this.btnBA_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 462);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Application by Group 21";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 486);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Microsoft";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 486);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "IOS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(260, 505);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(423, 505);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 615);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labNot1);
            this.Controls.Add(this.labNot);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "LIST OF STUDENTS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbB;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labNot;
        private System.Windows.Forms.Label labNot1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnallBA;
        private System.Windows.Forms.Button btnallAB;
        private System.Windows.Forms.Button btnBA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

