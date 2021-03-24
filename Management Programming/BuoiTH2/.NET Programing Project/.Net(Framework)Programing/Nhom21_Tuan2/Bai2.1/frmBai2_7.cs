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
    public partial class frmBai2_7 : Form
    {
        public frmBai2_7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int t = int.Parse(txtSoA.Text) + int.Parse(txtSoB.Text);
            MessageBox.Show(t.ToString());
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int t = int.Parse(txtSoA.Text) - int.Parse(txtSoB.Text);
            MessageBox.Show(t.ToString());
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            int t = int.Parse(txtSoA.Text) / int.Parse(txtSoB.Text);
            MessageBox.Show(t.ToString());
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            int t = int.Parse(txtSoA.Text) * int.Parse(txtSoB.Text);
            MessageBox.Show(t.ToString());
        }
    }
}
