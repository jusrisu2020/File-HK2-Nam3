using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNhapChuoi.Text != "")
                this.lstChuoi.Items.Add(this.txtNhapChuoi.Text);
            txtNhapChuoi.Text = "";
            txtNhapChuoi.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lstChuoi.Items.Remove(lstChuoi.Text);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult tl;
           tl =  MessageBox.Show("Bạn có muốn đóng ứng dụng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
                Application.Exit();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            if (d.ShowDialog() == DialogResult.OK)
                txtHienThi.ForeColor = d.Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            f.ShowColor = true;
            f.ShowApply = true;

            if (f.ShowDialog() == DialogResult.OK)
            {
                txtHienThi.Font = f.Font;
                txtHienThi.ForeColor = f.Color;
            }
        }
        void apply_font(object sender, EventArgs e)
        {
            FontDialog f = sender as FontDialog;
            txtHienThi.Font = f.Font;
            txtHienThi.ForeColor = f.Color;
        }

        private void btnMN_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
                txtHienThi.BackColor = c.Color;
        }

    }
}
