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
    public partial class frmBai2_6 : Form
    {
        public frmBai2_6()
        {
            InitializeComponent();
        }

        private void txtSoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int t = int.Parse(txtSoA.Text) + int.Parse(txtSoB.Text);
            MessageBox.Show(t.ToString());
        }
    }
}
