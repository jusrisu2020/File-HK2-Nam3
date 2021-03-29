namespace QLTSTBKhachSan.UI
{
    partial class FTrangChu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTrangChu));
            this.pnBgLeft = new System.Windows.Forms.Panel();
            this.gnEFTrangChu = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnDCFTrangChu = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gnEBgLeft = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnEQLND = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ucQLNV = new QLTSTBKhachSan.UI.UCQuanLyNhanVien();
            this.ucQLND = new QLTSTBKhachSan.UI.UCQuanLyNguoiDung();
            this.gnQLNV = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gnBtnCaiDat = new Guna.UI2.WinForms.Guna2Button();
            this.gnBtnQLTB = new Guna.UI2.WinForms.Guna2Button();
            this.gnBtnQLBP = new Guna.UI2.WinForms.Guna2Button();
            this.gnBtnQLNV = new Guna.UI2.WinForms.Guna2Button();
            this.gnBtnQLND = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pnBgLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBgLeft
            // 
            this.pnBgLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.pnBgLeft.Controls.Add(this.pictureBox2);
            this.pnBgLeft.Controls.Add(this.gnBtnQLTB);
            this.pnBgLeft.Controls.Add(this.gnBtnQLBP);
            this.pnBgLeft.Controls.Add(this.gnBtnQLNV);
            this.pnBgLeft.Controls.Add(this.gnBtnQLND);
            this.pnBgLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBgLeft.Location = new System.Drawing.Point(0, 0);
            this.pnBgLeft.Name = "pnBgLeft";
            this.pnBgLeft.Size = new System.Drawing.Size(300, 800);
            this.pnBgLeft.TabIndex = 0;
            // 
            // gnEFTrangChu
            // 
            this.gnEFTrangChu.BorderRadius = 30;
            this.gnEFTrangChu.TargetControl = this;
            // 
            // gnDCFTrangChu
            // 
            this.gnDCFTrangChu.ContainerControl = this;
            this.gnDCFTrangChu.TargetControl = this;
            this.gnDCFTrangChu.TransparentWhileDrag = true;
            this.gnDCFTrangChu.UseTransparentDrag = true;
            // 
            // gnEBgLeft
            // 
            this.gnEBgLeft.BorderRadius = 30;
            this.gnEBgLeft.TargetControl = this.pnBgLeft;
            // 
            // gnEQLND
            // 
            this.gnEQLND.BorderRadius = 30;
            this.gnEQLND.TargetControl = this.gnBtnQLND;
            // 
            // ucQLNV
            // 
            this.ucQLNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ucQLNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucQLNV.Location = new System.Drawing.Point(1300, 0);
            this.ucQLNV.Name = "ucQLNV";
            this.ucQLNV.Size = new System.Drawing.Size(1000, 800);
            this.ucQLNV.TabIndex = 2;
            // 
            // ucQLND
            // 
            this.ucQLND.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucQLND.Location = new System.Drawing.Point(300, 0);
            this.ucQLND.Name = "ucQLND";
            this.ucQLND.Size = new System.Drawing.Size(1000, 800);
            this.ucQLND.TabIndex = 1;
            // 
            // gnQLNV
            // 
            this.gnQLNV.BorderRadius = 30;
            this.gnQLNV.TargetControl = this.ucQLNV;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // gnBtnCaiDat
            // 
            this.gnBtnCaiDat.BackColor = System.Drawing.Color.Transparent;
            this.gnBtnCaiDat.BorderRadius = 16;
            this.gnBtnCaiDat.CheckedState.Parent = this.gnBtnCaiDat;
            this.gnBtnCaiDat.CustomImages.Parent = this.gnBtnCaiDat;
            this.gnBtnCaiDat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.gnBtnCaiDat.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.gnBtnCaiDat.ForeColor = System.Drawing.Color.White;
            this.gnBtnCaiDat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.gnBtnCaiDat.HoverState.Parent = this.gnBtnCaiDat;
            this.gnBtnCaiDat.Image = global::QLTSTBKhachSan.Properties.Resources.settings_50px;
            this.gnBtnCaiDat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gnBtnCaiDat.ImageSize = new System.Drawing.Size(30, 30);
            this.gnBtnCaiDat.Location = new System.Drawing.Point(9, 3);
            this.gnBtnCaiDat.Name = "gnBtnCaiDat";
            this.gnBtnCaiDat.ShadowDecoration.BorderRadius = 0;
            this.gnBtnCaiDat.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gnBtnCaiDat.ShadowDecoration.Parent = this.gnBtnCaiDat;
            this.gnBtnCaiDat.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.gnBtnCaiDat.Size = new System.Drawing.Size(232, 55);
            this.gnBtnCaiDat.TabIndex = 7;
            this.gnBtnCaiDat.Text = "Cài Đặt";
            this.gnBtnCaiDat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gnBtnCaiDat.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // gnBtnQLTB
            // 
            this.gnBtnQLTB.BackColor = System.Drawing.Color.Transparent;
            this.gnBtnQLTB.BorderRadius = 16;
            this.gnBtnQLTB.CheckedState.Parent = this.gnBtnQLTB;
            this.gnBtnQLTB.CustomImages.Parent = this.gnBtnQLTB;
            this.gnBtnQLTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.gnBtnQLTB.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.gnBtnQLTB.ForeColor = System.Drawing.Color.White;
            this.gnBtnQLTB.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.gnBtnQLTB.HoverState.Parent = this.gnBtnQLTB;
            this.gnBtnQLTB.Image = global::QLTSTBKhachSan.Properties.Resources.light_64px;
            this.gnBtnQLTB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gnBtnQLTB.ImageSize = new System.Drawing.Size(40, 40);
            this.gnBtnQLTB.Location = new System.Drawing.Point(23, 408);
            this.gnBtnQLTB.Name = "gnBtnQLTB";
            this.gnBtnQLTB.ShadowDecoration.BorderRadius = 0;
            this.gnBtnQLTB.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gnBtnQLTB.ShadowDecoration.Parent = this.gnBtnQLTB;
            this.gnBtnQLTB.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.gnBtnQLTB.Size = new System.Drawing.Size(232, 55);
            this.gnBtnQLTB.TabIndex = 6;
            this.gnBtnQLTB.Text = "Quản Lí Thiết Bị";
            this.gnBtnQLTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gnBtnQLTB.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // gnBtnQLBP
            // 
            this.gnBtnQLBP.BackColor = System.Drawing.Color.Transparent;
            this.gnBtnQLBP.BorderRadius = 16;
            this.gnBtnQLBP.CheckedState.Parent = this.gnBtnQLBP;
            this.gnBtnQLBP.CustomImages.Parent = this.gnBtnQLBP;
            this.gnBtnQLBP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.gnBtnQLBP.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.gnBtnQLBP.ForeColor = System.Drawing.Color.White;
            this.gnBtnQLBP.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.gnBtnQLBP.HoverState.Parent = this.gnBtnQLBP;
            this.gnBtnQLBP.Image = global::QLTSTBKhachSan.Properties.Resources.department_50px;
            this.gnBtnQLBP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gnBtnQLBP.ImageSize = new System.Drawing.Size(30, 30);
            this.gnBtnQLBP.Location = new System.Drawing.Point(23, 322);
            this.gnBtnQLBP.Name = "gnBtnQLBP";
            this.gnBtnQLBP.ShadowDecoration.BorderRadius = 0;
            this.gnBtnQLBP.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gnBtnQLBP.ShadowDecoration.Parent = this.gnBtnQLBP;
            this.gnBtnQLBP.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.gnBtnQLBP.Size = new System.Drawing.Size(232, 55);
            this.gnBtnQLBP.TabIndex = 5;
            this.gnBtnQLBP.Text = "Quản Lí Bộ Phận";
            this.gnBtnQLBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gnBtnQLBP.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // gnBtnQLNV
            // 
            this.gnBtnQLNV.BackColor = System.Drawing.Color.Transparent;
            this.gnBtnQLNV.BorderRadius = 16;
            this.gnBtnQLNV.CheckedState.Parent = this.gnBtnQLNV;
            this.gnBtnQLNV.CustomImages.Parent = this.gnBtnQLNV;
            this.gnBtnQLNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.gnBtnQLNV.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.gnBtnQLNV.ForeColor = System.Drawing.Color.White;
            this.gnBtnQLNV.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.gnBtnQLNV.HoverState.Parent = this.gnBtnQLNV;
            this.gnBtnQLNV.Image = global::QLTSTBKhachSan.Properties.Resources.management_30px;
            this.gnBtnQLNV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gnBtnQLNV.ImageSize = new System.Drawing.Size(30, 30);
            this.gnBtnQLNV.Location = new System.Drawing.Point(23, 241);
            this.gnBtnQLNV.Name = "gnBtnQLNV";
            this.gnBtnQLNV.ShadowDecoration.BorderRadius = 0;
            this.gnBtnQLNV.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gnBtnQLNV.ShadowDecoration.Parent = this.gnBtnQLNV;
            this.gnBtnQLNV.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.gnBtnQLNV.Size = new System.Drawing.Size(232, 55);
            this.gnBtnQLNV.TabIndex = 4;
            this.gnBtnQLNV.Text = "Quản Lí Nhân Viên";
            this.gnBtnQLNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gnBtnQLNV.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.gnBtnQLNV.Click += new System.EventHandler(this.gnBtnQLNV_Click);
            // 
            // gnBtnQLND
            // 
            this.gnBtnQLND.BackColor = System.Drawing.Color.Transparent;
            this.gnBtnQLND.BorderRadius = 16;
            this.gnBtnQLND.CheckedState.Parent = this.gnBtnQLND;
            this.gnBtnQLND.CustomImages.Parent = this.gnBtnQLND;
            this.gnBtnQLND.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.gnBtnQLND.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnBtnQLND.ForeColor = System.Drawing.Color.White;
            this.gnBtnQLND.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.gnBtnQLND.HoverState.Parent = this.gnBtnQLND;
            this.gnBtnQLND.Image = ((System.Drawing.Image)(resources.GetObject("gnBtnQLND.Image")));
            this.gnBtnQLND.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gnBtnQLND.ImageSize = new System.Drawing.Size(30, 30);
            this.gnBtnQLND.Location = new System.Drawing.Point(23, 169);
            this.gnBtnQLND.Name = "gnBtnQLND";
            this.gnBtnQLND.ShadowDecoration.BorderRadius = 0;
            this.gnBtnQLND.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gnBtnQLND.ShadowDecoration.Parent = this.gnBtnQLND;
            this.gnBtnQLND.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.gnBtnQLND.Size = new System.Drawing.Size(232, 55);
            this.gnBtnQLND.TabIndex = 2;
            this.gnBtnQLND.Text = "QUẢN LÍ NGƯỜI DÙNG";
            this.gnBtnQLND.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gnBtnQLND.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.gnBtnQLND.Click += new System.EventHandler(this.gnBtnQLND_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.gnBtnCaiDat);
            this.panel1.Location = new System.Drawing.Point(613, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 233);
            this.panel1.TabIndex = 8;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 16;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::QLTSTBKhachSan.Properties.Resources.settings_50px;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(9, 61);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.BorderRadius = 0;
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.guna2Button1.Size = new System.Drawing.Size(193, 55);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Cài Đặt";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 16;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::QLTSTBKhachSan.Properties.Resources.settings_50px;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(9, 122);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.BorderRadius = 0;
            this.guna2Button2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.guna2Button2.Size = new System.Drawing.Size(193, 55);
            this.guna2Button2.TabIndex = 9;
            this.guna2Button2.Text = "Cài Đặt";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // FTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucQLNV);
            this.Controls.Add(this.ucQLND);
            this.Controls.Add(this.pnBgLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTrangChu";
            this.Load += new System.EventHandler(this.FTrangChu_Load);
            this.pnBgLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBgLeft;
        private Guna.UI2.WinForms.Guna2Button gnBtnQLND;
        private Guna.UI2.WinForms.Guna2Button gnBtnQLBP;
        private Guna.UI2.WinForms.Guna2Button gnBtnQLNV;
        private Guna.UI2.WinForms.Guna2Button gnBtnCaiDat;
        private Guna.UI2.WinForms.Guna2Button gnBtnQLTB;
        private Guna.UI2.WinForms.Guna2Elipse gnEFTrangChu;
        private Guna.UI2.WinForms.Guna2DragControl gnDCFTrangChu;
        private Guna.UI2.WinForms.Guna2Elipse gnEBgLeft;
        private Guna.UI2.WinForms.Guna2Elipse gnEQLND;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UCQuanLyNhanVien ucQLNV;
        private UCQuanLyNguoiDung ucQLND;
        private Guna.UI2.WinForms.Guna2Elipse gnQLNV;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}