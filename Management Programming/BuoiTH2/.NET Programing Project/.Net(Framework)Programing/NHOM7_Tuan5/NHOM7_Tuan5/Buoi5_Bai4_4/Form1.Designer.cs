namespace Buoi5_Bai4_4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radTron = new System.Windows.Forms.RadioButton();
            this.radCN = new System.Windows.Forms.RadioButton();
            this.radVuong = new System.Windows.Forms.RadioButton();
            this.radTG = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTT = new System.Windows.Forms.Button();
            this.btnRS = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNhapA = new System.Windows.Forms.TextBox();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.gbHinhVuong = new System.Windows.Forms.GroupBox();
            this.gbHinhCN = new System.Windows.Forms.GroupBox();
            this.txtdtCN = new System.Windows.Forms.TextBox();
            this.txtcvCN = new System.Windows.Forms.TextBox();
            this.txtHCNca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCNcb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbTron = new System.Windows.Forms.GroupBox();
            this.txtdtHT = new System.Windows.Forms.TextBox();
            this.txtcvHT = new System.Windows.Forms.TextBox();
            this.txtTronr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbTG = new System.Windows.Forms.GroupBox();
            this.txtTGcb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdtTG = new System.Windows.Forms.TextBox();
            this.txtcvTG = new System.Windows.Forms.TextBox();
            this.txtTGca = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTGcc = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtktTG = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbHinhVuong.SuspendLayout();
            this.gbHinhCN.SuspendLayout();
            this.gbTron.SuspendLayout();
            this.gbTG.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Chu Vi và Diện Tích";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(251, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hình Tròn - Hình Vuông";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(204, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình Tam Giác - Hình Chữ Nhật";
            // 
            // radTron
            // 
            this.radTron.AutoSize = true;
            this.radTron.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTron.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radTron.Location = new System.Drawing.Point(33, 29);
            this.radTron.Name = "radTron";
            this.radTron.Size = new System.Drawing.Size(117, 27);
            this.radTron.TabIndex = 3;
            this.radTron.TabStop = true;
            this.radTron.Text = "Hình Tròn";
            this.radTron.UseVisualStyleBackColor = true;
            this.radTron.CheckedChanged += new System.EventHandler(this.radTron_CheckedChanged);
            // 
            // radCN
            // 
            this.radCN.AutoSize = true;
            this.radCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCN.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radCN.Location = new System.Drawing.Point(211, 77);
            this.radCN.Name = "radCN";
            this.radCN.Size = new System.Drawing.Size(159, 27);
            this.radCN.TabIndex = 4;
            this.radCN.TabStop = true;
            this.radCN.Text = "Hình Chữ Nhật";
            this.radCN.UseVisualStyleBackColor = true;
            this.radCN.CheckedChanged += new System.EventHandler(this.radCN_CheckedChanged);
            // 
            // radVuong
            // 
            this.radVuong.AutoSize = true;
            this.radVuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVuong.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radVuong.Location = new System.Drawing.Point(208, 29);
            this.radVuong.Name = "radVuong";
            this.radVuong.Size = new System.Drawing.Size(129, 27);
            this.radVuong.TabIndex = 5;
            this.radVuong.TabStop = true;
            this.radVuong.Text = "Hình Vuông";
            this.radVuong.UseVisualStyleBackColor = true;
            this.radVuong.CheckedChanged += new System.EventHandler(this.radVuong_CheckedChanged);
            // 
            // radTG
            // 
            this.radTG.AutoSize = true;
            this.radTG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTG.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radTG.Location = new System.Drawing.Point(33, 77);
            this.radTG.Name = "radTG";
            this.radTG.Size = new System.Drawing.Size(158, 27);
            this.radTG.TabIndex = 6;
            this.radTG.TabStop = true;
            this.radTG.Text = "Hình Tam Giác";
            this.radTG.UseVisualStyleBackColor = true;
            this.radTG.CheckedChanged += new System.EventHandler(this.radTG_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radTG);
            this.groupBox1.Controls.Add(this.radVuong);
            this.groupBox1.Controls.Add(this.radCN);
            this.groupBox1.Controls.Add(this.radTron);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(172, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // btnTT
            // 
            this.btnTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTT.Location = new System.Drawing.Point(78, 314);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(127, 44);
            this.btnTT.TabIndex = 8;
            this.btnTT.Text = "thực hiện";
            this.btnTT.UseVisualStyleBackColor = true;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // btnRS
            // 
            this.btnRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRS.Location = new System.Drawing.Point(283, 314);
            this.btnRS.Name = "btnRS";
            this.btnRS.Size = new System.Drawing.Size(127, 44);
            this.btnRS.TabIndex = 9;
            this.btnRS.Text = "RESET";
            this.btnRS.UseVisualStyleBackColor = true;
            this.btnRS.Click += new System.EventHandler(this.btnRS_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(478, 314);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 44);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nhập Cạnh A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Diện Tích:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Chu Vi:";
            // 
            // txtNhapA
            // 
            this.txtNhapA.Location = new System.Drawing.Point(159, 38);
            this.txtNhapA.Name = "txtNhapA";
            this.txtNhapA.Size = new System.Drawing.Size(183, 22);
            this.txtNhapA.TabIndex = 14;
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(159, 76);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(183, 22);
            this.txtCV.TabIndex = 15;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(160, 118);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(183, 22);
            this.txtDT.TabIndex = 16;
            // 
            // gbHinhVuong
            // 
            this.gbHinhVuong.Controls.Add(this.txtDT);
            this.gbHinhVuong.Controls.Add(this.txtCV);
            this.gbHinhVuong.Controls.Add(this.txtNhapA);
            this.gbHinhVuong.Controls.Add(this.label6);
            this.gbHinhVuong.Controls.Add(this.label5);
            this.gbHinhVuong.Controls.Add(this.label4);
            this.gbHinhVuong.Location = new System.Drawing.Point(65, 424);
            this.gbHinhVuong.Name = "gbHinhVuong";
            this.gbHinhVuong.Size = new System.Drawing.Size(365, 146);
            this.gbHinhVuong.TabIndex = 17;
            this.gbHinhVuong.TabStop = false;
            this.gbHinhVuong.Text = "Hinh Vuông";
            // 
            // gbHinhCN
            // 
            this.gbHinhCN.Controls.Add(this.txtCNcb);
            this.gbHinhCN.Controls.Add(this.label10);
            this.gbHinhCN.Controls.Add(this.txtdtCN);
            this.gbHinhCN.Controls.Add(this.txtcvCN);
            this.gbHinhCN.Controls.Add(this.txtHCNca);
            this.gbHinhCN.Controls.Add(this.label7);
            this.gbHinhCN.Controls.Add(this.label8);
            this.gbHinhCN.Controls.Add(this.label9);
            this.gbHinhCN.Location = new System.Drawing.Point(267, 412);
            this.gbHinhCN.Name = "gbHinhCN";
            this.gbHinhCN.Size = new System.Drawing.Size(392, 209);
            this.gbHinhCN.TabIndex = 18;
            this.gbHinhCN.TabStop = false;
            this.gbHinhCN.Text = "Hinh Chữ Nhật";
            // 
            // txtdtCN
            // 
            this.txtdtCN.Location = new System.Drawing.Point(160, 145);
            this.txtdtCN.Name = "txtdtCN";
            this.txtdtCN.Size = new System.Drawing.Size(183, 22);
            this.txtdtCN.TabIndex = 16;
            // 
            // txtcvCN
            // 
            this.txtcvCN.Location = new System.Drawing.Point(159, 103);
            this.txtcvCN.Name = "txtcvCN";
            this.txtcvCN.Size = new System.Drawing.Size(183, 22);
            this.txtcvCN.TabIndex = 15;
            // 
            // txtHCNca
            // 
            this.txtHCNca.Location = new System.Drawing.Point(159, 38);
            this.txtHCNca.Name = "txtHCNca";
            this.txtHCNca.Size = new System.Drawing.Size(183, 22);
            this.txtHCNca.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Chu Vi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Diện Tích:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nhập Cạnh A:";
            // 
            // txtCNcb
            // 
            this.txtCNcb.Location = new System.Drawing.Point(160, 66);
            this.txtCNcb.Name = "txtCNcb";
            this.txtCNcb.Size = new System.Drawing.Size(183, 22);
            this.txtCNcb.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nhập Cạnh B:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // gbTron
            // 
            this.gbTron.Controls.Add(this.txtdtHT);
            this.gbTron.Controls.Add(this.txtcvHT);
            this.gbTron.Controls.Add(this.txtTronr);
            this.gbTron.Controls.Add(this.label11);
            this.gbTron.Controls.Add(this.label12);
            this.gbTron.Controls.Add(this.label13);
            this.gbTron.Location = new System.Drawing.Point(640, 276);
            this.gbTron.Name = "gbTron";
            this.gbTron.Size = new System.Drawing.Size(365, 146);
            this.gbTron.TabIndex = 19;
            this.gbTron.TabStop = false;
            this.gbTron.Text = "Hinh Tron";
            // 
            // txtdtHT
            // 
            this.txtdtHT.Location = new System.Drawing.Point(160, 118);
            this.txtdtHT.Name = "txtdtHT";
            this.txtdtHT.Size = new System.Drawing.Size(183, 22);
            this.txtdtHT.TabIndex = 16;
            // 
            // txtcvHT
            // 
            this.txtcvHT.Location = new System.Drawing.Point(159, 76);
            this.txtcvHT.Name = "txtcvHT";
            this.txtcvHT.Size = new System.Drawing.Size(183, 22);
            this.txtcvHT.TabIndex = 15;
            // 
            // txtTronr
            // 
            this.txtTronr.Location = new System.Drawing.Point(159, 38);
            this.txtTronr.Name = "txtTronr";
            this.txtTronr.Size = new System.Drawing.Size(183, 22);
            this.txtTronr.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "Chu Vi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 19);
            this.label12.TabIndex = 12;
            this.label12.Text = "Diện Tích:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 19);
            this.label13.TabIndex = 11;
            this.label13.Text = "Nhập BK R:";
            // 
            // gbTG
            // 
            this.gbTG.Controls.Add(this.txtktTG);
            this.gbTG.Controls.Add(this.label19);
            this.gbTG.Controls.Add(this.txtTGcc);
            this.gbTG.Controls.Add(this.label18);
            this.gbTG.Controls.Add(this.txtTGcb);
            this.gbTG.Controls.Add(this.label14);
            this.gbTG.Controls.Add(this.txtdtTG);
            this.gbTG.Controls.Add(this.txtcvTG);
            this.gbTG.Controls.Add(this.txtTGca);
            this.gbTG.Controls.Add(this.label15);
            this.gbTG.Controls.Add(this.label16);
            this.gbTG.Controls.Add(this.label17);
            this.gbTG.Location = new System.Drawing.Point(613, 412);
            this.gbTG.Name = "gbTG";
            this.gbTG.Size = new System.Drawing.Size(392, 209);
            this.gbTG.TabIndex = 19;
            this.gbTG.TabStop = false;
            this.gbTG.Text = "Hinh Tam Giác";
            // 
            // txtTGcb
            // 
            this.txtTGcb.Location = new System.Drawing.Point(160, 66);
            this.txtTGcb.Name = "txtTGcb";
            this.txtTGcb.Size = new System.Drawing.Size(183, 22);
            this.txtTGcb.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 19);
            this.label14.TabIndex = 17;
            this.label14.Text = "Nhập Cạnh B:";
            // 
            // txtdtTG
            // 
            this.txtdtTG.Location = new System.Drawing.Point(159, 181);
            this.txtdtTG.Name = "txtdtTG";
            this.txtdtTG.Size = new System.Drawing.Size(183, 22);
            this.txtdtTG.TabIndex = 16;
            // 
            // txtcvTG
            // 
            this.txtcvTG.Location = new System.Drawing.Point(159, 152);
            this.txtcvTG.Name = "txtcvTG";
            this.txtcvTG.Size = new System.Drawing.Size(183, 22);
            this.txtcvTG.TabIndex = 15;
            // 
            // txtTGca
            // 
            this.txtTGca.Location = new System.Drawing.Point(159, 38);
            this.txtTGca.Name = "txtTGca";
            this.txtTGca.Size = new System.Drawing.Size(183, 22);
            this.txtTGca.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(28, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 19);
            this.label15.TabIndex = 13;
            this.label15.Text = "Chu Vi:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 19);
            this.label16.TabIndex = 12;
            this.label16.Text = "Diện Tích:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 19);
            this.label17.TabIndex = 11;
            this.label17.Text = "Nhập Cạnh A:";
            // 
            // txtTGcc
            // 
            this.txtTGcc.Location = new System.Drawing.Point(163, 96);
            this.txtTGcc.Name = "txtTGcc";
            this.txtTGcc.Size = new System.Drawing.Size(183, 22);
            this.txtTGcc.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(28, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 19);
            this.label18.TabIndex = 19;
            this.label18.Text = "Nhập Cạnh C:";
            // 
            // txtktTG
            // 
            this.txtktTG.Location = new System.Drawing.Point(160, 124);
            this.txtktTG.Name = "txtktTG";
            this.txtktTG.Size = new System.Drawing.Size(183, 22);
            this.txtktTG.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(37, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 19);
            this.label19.TabIndex = 21;
            this.label19.Text = "KT Tam Giác";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 624);
            this.Controls.Add(this.gbHinhCN);
            this.Controls.Add(this.gbTron);
            this.Controls.Add(this.gbTG);
            this.Controls.Add(this.gbHinhVuong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnRS);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbHinhVuong.ResumeLayout(false);
            this.gbHinhVuong.PerformLayout();
            this.gbHinhCN.ResumeLayout(false);
            this.gbHinhCN.PerformLayout();
            this.gbTron.ResumeLayout(false);
            this.gbTron.PerformLayout();
            this.gbTG.ResumeLayout(false);
            this.gbTG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radTron;
        private System.Windows.Forms.RadioButton radCN;
        private System.Windows.Forms.RadioButton radVuong;
        private System.Windows.Forms.RadioButton radTG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Button btnRS;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNhapA;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.GroupBox gbHinhVuong;
        private System.Windows.Forms.GroupBox gbHinhCN;
        private System.Windows.Forms.TextBox txtdtCN;
        private System.Windows.Forms.TextBox txtcvCN;
        private System.Windows.Forms.TextBox txtHCNca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCNcb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbTron;
        private System.Windows.Forms.TextBox txtdtHT;
        private System.Windows.Forms.TextBox txtcvHT;
        private System.Windows.Forms.TextBox txtTronr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbTG;
        private System.Windows.Forms.TextBox txtTGcc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTGcb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtdtTG;
        private System.Windows.Forms.TextBox txtcvTG;
        private System.Windows.Forms.TextBox txtTGca;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtktTG;
        private System.Windows.Forms.Label label19;
    }
}

