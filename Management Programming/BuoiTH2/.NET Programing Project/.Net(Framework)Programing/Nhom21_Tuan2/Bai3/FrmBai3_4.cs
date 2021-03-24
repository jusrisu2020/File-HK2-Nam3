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
    public partial class FrmBai3_4 : Form
    {
        public FrmBai3_4()
        {
            InitializeComponent();
        }

        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            int n, t, y;
            n = int.Parse(txtngay.Text);
            t = int.Parse(txtthang.Text);
            y = int.Parse(txtnam.Text);
            
            switch (t)
            {
                case 1:
                    if (t == 2 && n <= 28)
                    {
                        MessageBox.Show("Ngày hợp lệ!!!!");
                    }
                    break;

                    if (t == 1 || t == 3 || t == 5 || t == 7 || t == 8 || t == 10 || t == 12 && n <= 31)
                    {
                        MessageBox.Show("Ngày hợp lệ!!!!");
                    }
                    else if( t == 4 || t == 6 || t == 9 || t == 11 && n <= 30)
                    {
                        MessageBox.Show("Ngày hợp lệ!!!!");
                    }
                case 2:

                    MessageBox.Show("Ngày không hợp lệ!!!!");
                    break;
                
            }                         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
