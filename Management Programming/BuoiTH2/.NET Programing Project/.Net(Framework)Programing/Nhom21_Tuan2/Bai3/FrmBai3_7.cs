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
    public partial class FrmBai3_7 : Form
    {
        public FrmBai3_7()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(txta.Text);
            b = int.Parse(txtb.Text);
            c = int.Parse(txtc.Text);

            if (a == 0)
            {
                if (b == 0)
                    if (c == 0)
                        txtKQ.Text = "Phương trình vô số nghiệm";
                    else
                        txtKQ.Text = "Phương trình vô nghiệm";
                else
                {
                    txtKQ.Text = "Phương trình có một nghiệm: x=" + ((-c) / b);
                }

            }
            else
            {
                float d = (float)(b * b -  (4* a * c));
                if (d < 0)
                    txtKQ.Text = "Phương trình vô nghiệm";
                else if (d == 0)
                    txtKQ.Text = "Phương trình có nghiệm kép:x1=x2=" + ((float)(-b / 2 * a));
                else
                {
                    txtKQ.Text = "Phương trình có hai nghiệm phân biệt:x1=" + (float)((-b + Math.Sqrt(d)) / (2 * a)) + ";x2=" + (float)((-b - Math.Sqrt(d)) / (2 * a));
                }    
            }    
        }
    }
}
