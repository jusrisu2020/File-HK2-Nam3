using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._1
{
    public partial class frmBai2_11 : Form
    {
        public frmBai2_11()
        {
            InitializeComponent();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            int t = (int.Parse(txtSoA.Text) + int.Parse(txtSoB.Text)) * 2;
         
            txtKetQua.Text = t.ToString();
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            int t = (int.Parse(txtSoA.Text) * int.Parse(txtSoB.Text));
         
            txtKetQua.Text = t.ToString();
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            int N =int.Parse(txtSoA.Text) * int.Parse(txtSoA.Text);
            int M = int.Parse(txtSoB.Text) * int.Parse(txtSoB.Text);
            double t = Math.Sqrt(N + M);
            txtKetQua.Text = t.ToString();




        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
