namespace QLTSTBKhachSan.UI
{
    partial class SaveImg
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.picTest = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(32, 281);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(153, 281);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 28);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(281, 281);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // picTest
            // 
            this.picTest.Location = new System.Drawing.Point(32, 32);
            this.picTest.Margin = new System.Windows.Forms.Padding(4);
            this.picTest.Name = "picTest";
            this.picTest.Size = new System.Drawing.Size(349, 208);
            this.picTest.TabIndex = 0;
            this.picTest.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(451, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 140;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(600, 468);
            this.dataGridView1.TabIndex = 4;
            // 
            // FHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picTest);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveXuatImg";
            this.Load += new System.EventHandler(this.SaveXuatImg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picTest;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}