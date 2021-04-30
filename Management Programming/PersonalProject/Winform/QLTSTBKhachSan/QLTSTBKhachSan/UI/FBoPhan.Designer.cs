
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
            this.components = new System.ComponentModel.Container();
            this.txtThemBoPhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemBoPhan = new System.Windows.Forms.Button();
            this.tSTBKhachSanDataSet = new QLTSTBKhachSan.TSTBKhachSanDataSet();
            this.boPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boPhanTableAdapter = new QLTSTBKhachSan.TSTBKhachSanDataSetTableAdapters.BoPhanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tSTBKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boPhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtThemBoPhan
            // 
            this.txtThemBoPhan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boPhanBindingSource, "TenBP", true));
            this.txtThemBoPhan.Location = new System.Drawing.Point(107, 42);
            this.txtThemBoPhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtThemBoPhan.Name = "txtThemBoPhan";
            this.txtThemBoPhan.Size = new System.Drawing.Size(130, 20);
            this.txtThemBoPhan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Bộ Phận";
            // 
            // btnThemBoPhan
            // 
            this.btnThemBoPhan.Location = new System.Drawing.Point(287, 32);
            this.btnThemBoPhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemBoPhan.Name = "btnThemBoPhan";
            this.btnThemBoPhan.Size = new System.Drawing.Size(91, 38);
            this.btnThemBoPhan.TabIndex = 2;
            this.btnThemBoPhan.Text = "Thêm Bộ Phận";
            this.btnThemBoPhan.UseVisualStyleBackColor = true;
            this.btnThemBoPhan.Click += new System.EventHandler(this.btnThemBoPhan_Click);
            // 
            // tSTBKhachSanDataSet
            // 
            this.tSTBKhachSanDataSet.DataSetName = "TSTBKhachSanDataSet";
            this.tSTBKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boPhanBindingSource
            // 
            this.boPhanBindingSource.DataMember = "BoPhan";
            this.boPhanBindingSource.DataSource = this.tSTBKhachSanDataSet;
            // 
            // boPhanTableAdapter
            // 
            this.boPhanTableAdapter.ClearBeforeFill = true;
            // 
            // FBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 200);
            this.Controls.Add(this.btnThemBoPhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThemBoPhan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FBoPhan";
            this.Text = "Bộ phận";
            this.Load += new System.EventHandler(this.FBoPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tSTBKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boPhanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThemBoPhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemBoPhan;
        private TSTBKhachSanDataSet tSTBKhachSanDataSet;
        private System.Windows.Forms.BindingSource boPhanBindingSource;
        private TSTBKhachSanDataSetTableAdapters.BoPhanTableAdapter boPhanTableAdapter;
    }
}