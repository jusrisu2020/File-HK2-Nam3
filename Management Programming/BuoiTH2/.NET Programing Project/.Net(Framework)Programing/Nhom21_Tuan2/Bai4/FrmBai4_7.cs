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
    public partial class FrmBai4_7 : Form
    {
        public FrmBai4_7()
        {
            InitializeComponent();
        }

        private void btnTính_Click(object sender, EventArgs e)
        {
            int s = 1;
            int n;
            int i = 1;
            n = int.Parse(txtn.Text);

            while (i <= n)
            {
                s = s *i;
                i++;

            }
            txts.Text = s.ToString();
        }
    }
}
