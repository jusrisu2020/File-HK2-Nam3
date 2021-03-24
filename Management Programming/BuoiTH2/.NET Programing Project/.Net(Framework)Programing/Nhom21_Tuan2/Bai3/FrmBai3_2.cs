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
    public partial class FrmBai3_2 : Form
    {
        public FrmBai3_2()
        {
            InitializeComponent();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            int f = int.Parse(txtThang.Text);
            if ((f >= 1) && (f <= 3))
            {
                MessageBox.Show("Mua Xuan");
            }
            else if ((f >= 4) && (f <= 6))
            {
                MessageBox.Show("Mua Ha");
            }
            else if ((f >= 7) && (f <= 9))
            {
                MessageBox.Show("Mua Thu");
            }
            else if ((f >= 10) && (f <= 12))
            {
                MessageBox.Show("Mua Dong");
            }
        }
    }
   }

