
namespace LTQL_BuoiTH04
{
    partial class FrmMain
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
            this.mtTool = new System.Windows.Forms.MenuStrip();
            this.chươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmtChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.tmtNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mtTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtTool
            // 
            this.mtTool.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mtTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chươngTrìnhToolStripMenuItem,
            this.mtDanhMuc,
            this.nghiệpVụToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.giúpToolStripMenuItem});
            this.mtTool.Location = new System.Drawing.Point(0, 0);
            this.mtTool.Name = "mtTool";
            this.mtTool.Size = new System.Drawing.Size(800, 30);
            this.mtTool.TabIndex = 0;
            this.mtTool.Text = "menuStrip1";
            // 
            // chươngTrìnhToolStripMenuItem
            // 
            this.chươngTrìnhToolStripMenuItem.Name = "chươngTrìnhToolStripMenuItem";
            this.chươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.chươngTrìnhToolStripMenuItem.Text = "Chương trình";
            // 
            // mtDanhMuc
            // 
            this.mtDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmtChucVu,
            this.tmtNhanVien});
            this.mtDanhMuc.Name = "mtDanhMuc";
            this.mtDanhMuc.Size = new System.Drawing.Size(90, 26);
            this.mtDanhMuc.Text = "Danh mục";
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // giúpToolStripMenuItem
            // 
            this.giúpToolStripMenuItem.Name = "giúpToolStripMenuItem";
            this.giúpToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.giúpToolStripMenuItem.Text = "Giúp đỡ";
            // 
            // tmtChucVu
            // 
            this.tmtChucVu.Name = "tmtChucVu";
            this.tmtChucVu.Size = new System.Drawing.Size(224, 26);
            this.tmtChucVu.Text = "Chức vụ";
            // 
            // tmtNhanVien
            // 
            this.tmtNhanVien.Name = "tmtNhanVien";
            this.tmtNhanVien.Size = new System.Drawing.Size(224, 26);
            this.tmtNhanVien.Text = "Nhân viên";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtTool);
            this.Name = "FrmMain";
            this.Text = "Chương trình quản lí nhân viên";
            this.mtTool.ResumeLayout(false);
            this.mtTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mtTool;
        private System.Windows.Forms.ToolStripMenuItem chươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmtChucVu;
        private System.Windows.Forms.ToolStripMenuItem tmtNhanVien;
    }
}

