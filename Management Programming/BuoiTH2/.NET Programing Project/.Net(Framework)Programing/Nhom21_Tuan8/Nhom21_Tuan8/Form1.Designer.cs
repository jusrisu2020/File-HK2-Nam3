namespace Nhom21_Tuan8
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCircle = new System.Windows.Forms.RadioButton();
            this.radRectangle = new System.Windows.Forms.RadioButton();
            this.radSquare = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtWide = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPerform = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbNot = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULATE THE AREA AND PERIMETER";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCircle);
            this.groupBox1.Controls.Add(this.radRectangle);
            this.groupBox1.Controls.Add(this.radSquare);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // radCircle
            // 
            this.radCircle.AutoSize = true;
            this.radCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCircle.Location = new System.Drawing.Point(25, 121);
            this.radCircle.Name = "radCircle";
            this.radCircle.Size = new System.Drawing.Size(60, 20);
            this.radCircle.TabIndex = 2;
            this.radCircle.TabStop = true;
            this.radCircle.Text = "Circle";
            this.radCircle.UseVisualStyleBackColor = true;
            this.radCircle.CheckedChanged += new System.EventHandler(this.radCircle_CheckedChanged);
            // 
            // radRectangle
            // 
            this.radRectangle.AutoSize = true;
            this.radRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRectangle.Location = new System.Drawing.Point(25, 80);
            this.radRectangle.Name = "radRectangle";
            this.radRectangle.Size = new System.Drawing.Size(88, 20);
            this.radRectangle.TabIndex = 1;
            this.radRectangle.TabStop = true;
            this.radRectangle.Text = "Rectangle";
            this.radRectangle.UseVisualStyleBackColor = true;
            this.radRectangle.CheckedChanged += new System.EventHandler(this.radRectangle_CheckedChanged);
            // 
            // radSquare
            // 
            this.radSquare.AutoSize = true;
            this.radSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSquare.Location = new System.Drawing.Point(25, 38);
            this.radSquare.Name = "radSquare";
            this.radSquare.Size = new System.Drawing.Size(70, 20);
            this.radSquare.TabIndex = 0;
            this.radSquare.TabStop = true;
            this.radSquare.Text = "Square";
            this.radSquare.UseVisualStyleBackColor = true;
            this.radSquare.CheckedChanged += new System.EventHandler(this.radSquare_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRadius);
            this.panel1.Controls.Add(this.txtLong);
            this.panel1.Controls.Add(this.txtWide);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEdge);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(240, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 183);
            this.panel1.TabIndex = 1;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(83, 144);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 7;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(83, 58);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(100, 20);
            this.txtLong.TabIndex = 6;
            // 
            // txtWide
            // 
            this.txtWide.Location = new System.Drawing.Point(83, 101);
            this.txtWide.Name = "txtWide";
            this.txtWide.Size = new System.Drawing.Size(100, 20);
            this.txtWide.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Radius R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wide";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Long";
            // 
            // txtEdge
            // 
            this.txtEdge.Location = new System.Drawing.Point(83, 13);
            this.txtEdge.Name = "txtEdge";
            this.txtEdge.Size = new System.Drawing.Size(100, 20);
            this.txtEdge.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Edge";
            // 
            // btnPerform
            // 
            this.btnPerform.Location = new System.Drawing.Point(120, 293);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(95, 48);
            this.btnPerform.TabIndex = 2;
            this.btnPerform.Text = "Perform";
            this.btnPerform.UseVisualStyleBackColor = true;
            this.btnPerform.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(256, 293);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 48);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbNot
            // 
            this.lbNot.AutoSize = true;
            this.lbNot.ForeColor = System.Drawing.Color.Red;
            this.lbNot.Location = new System.Drawing.Point(183, 268);
            this.lbNot.Name = "lbNot";
            this.lbNot.Size = new System.Drawing.Size(16, 13);
            this.lbNot.TabIndex = 4;
            this.lbNot.Text = "   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 358);
            this.Controls.Add(this.lbNot);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPerform);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Exercise";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCircle;
        private System.Windows.Forms.RadioButton radRectangle;
        private System.Windows.Forms.RadioButton radSquare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtWide;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPerform;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbNot;
    }
}

