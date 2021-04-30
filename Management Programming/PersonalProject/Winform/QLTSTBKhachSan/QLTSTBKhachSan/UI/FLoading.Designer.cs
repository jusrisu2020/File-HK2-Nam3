
namespace QLTSTBKhachSan.UI
{
    partial class FLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLoading));
            this.PgbLoading = new System.Windows.Forms.ProgressBar();
            this.tmLoading = new System.Windows.Forms.Timer(this.components);
            this.lbPercent = new System.Windows.Forms.Label();
            this.PtbLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // PgbLoading
            // 
            this.PgbLoading.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PgbLoading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PgbLoading.Location = new System.Drawing.Point(0, 386);
            this.PgbLoading.Margin = new System.Windows.Forms.Padding(2);
            this.PgbLoading.Name = "PgbLoading";
            this.PgbLoading.Size = new System.Drawing.Size(600, 14);
            this.PgbLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PgbLoading.TabIndex = 1;
            // 
            // tmLoading
            // 
            this.tmLoading.Enabled = true;
            this.tmLoading.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercent.Location = new System.Drawing.Point(11, 368);
            this.lbPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(27, 16);
            this.lbPercent.TabIndex = 2;
            this.lbPercent.Text = "0%";
            this.lbPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PtbLoading
            // 
            this.PtbLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtbLoading.Image = ((System.Drawing.Image)(resources.GetObject("PtbLoading.Image")));
            this.PtbLoading.Location = new System.Drawing.Point(0, 0);
            this.PtbLoading.Name = "PtbLoading";
            this.PtbLoading.Size = new System.Drawing.Size(600, 400);
            this.PtbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbLoading.TabIndex = 3;
            this.PtbLoading.TabStop = false;
            // 
            // FLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lbPercent);
            this.Controls.Add(this.PgbLoading);
            this.Controls.Add(this.PtbLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            ((System.ComponentModel.ISupportInitialize)(this.PtbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar PgbLoading;
        private System.Windows.Forms.Timer tmLoading;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.PictureBox PtbLoading;
    }
}