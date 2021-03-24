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
    public partial class FrmBai4_4 : Form
    {
        public FrmBai4_4()
        {
            InitializeComponent();
        }

        private void btnTính_Click(object sender, EventArgs e)
        {
            int s = 0;
            int n;
            int i = 0;
            n = int.Parse(txtn.Text);

            while (i < n)
            {
                s = s + ((2 * i)+1) ;
                i++;

            }
            txts.Text = s.ToString();
        }
    }
}
