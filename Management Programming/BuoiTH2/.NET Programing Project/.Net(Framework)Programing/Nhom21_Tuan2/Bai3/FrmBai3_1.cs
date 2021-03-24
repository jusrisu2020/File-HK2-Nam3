using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class FrmBai3_1 : Form
    {
        public FrmBai3_1()
        {
            InitializeComponent();
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int x, f;
            x = Int32.Parse(txtx.Text);
            if (x >= 2)
            {
                f = -8 * x * x * x - 12 * x - 1;
                txtKetQua.Text = f.ToString();
            }
            else if (x < 1 && x < 2)
            {
                f=x *x -6 * x - 19;
                txtKetQua.Text = f.ToString();

            }
            else
            {
                f = 7 * x;
                txtKetQua.Text = f.ToString();
            }
        }
    }
}
