using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class FrmBai4_2 : Form
    {
        public FrmBai4_2()
        {
            InitializeComponent();
        }

        private void btnTính_Click(object sender, EventArgs e)
        {
            int s = 0;
            int n;
            int i = 1;
            n = int.Parse(txtn.Text);

            while (i <= n)
            {
                s = s + i*i;
                i++;

            }
            txts.Text = s.ToString();
        }
    }
}
