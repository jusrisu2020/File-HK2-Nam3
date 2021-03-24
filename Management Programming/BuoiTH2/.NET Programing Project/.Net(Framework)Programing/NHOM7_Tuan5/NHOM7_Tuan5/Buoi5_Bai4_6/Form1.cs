using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai4_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = new int[100];
        int n = 0, i;
        string s, s1;


        private void rdoTongC_CheckedChanged(object sender, EventArgs e)
        {
            int t = 0;
            for (int i = 0; i <= n; i++)
            {
                if (a[i] % 2 == 0)
                    t += a[i];

            }
            txtKQ.Text = t.ToString();
        }

        private void rdoSLChan_CheckedChanged(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 0; i <= n; i++)
            {
                if (a[i] % 2 == 0)
                    s++;

            }
            txtKQ.Text = s.ToString();
        }

        private void rdoTongL_CheckedChanged(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 0; i <= n; i++)
            {
                if (a[i] % 2 != 0)
                    s += a[i];

            }
            txtKQ.Text = s.ToString();
        }

        private void rdoSLLe_CheckedChanged(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 0; i <= n; i++)
            {
                if (a[i] % 2 != 0)
                    s++;

            }
            txtKQ.Text = s.ToString();
        }

        private void rdoMin_CheckedChanged(object sender, EventArgs e)
        {
            int min = a[0];
            for (int i = 1; i <= n; i++)
            {
                if (min > a[i])
                    min = a[i];
            }
            txtKQ.Text = min.ToString();
        }

        private void btnXuatM_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Nhập mảng", "Thông báo");
            }
            else
            {
                n = 0;
                txtKQ.Clear();
                s = txtNhap.Text;
                i = s.LastIndexOf(" ");
                while (i != -1)
                {
                    s1 = s.Substring(i);
                    s = s.Substring(0, i);
                    a[n] = Convert.ToInt32(s1);
                    n++;
                    i = s.LastIndexOf(" ");
                }
                a[n] = Convert.ToInt32(s);
                s = " ";
                for (i = n; i >= 0; i--)
                    s = s + " " + a[i].ToString();
                txtKQ.Text = s.Trim();
            }
        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            txtNhap.Clear();
           this.txtNhap.Focus();
           
        }

        private void rdoChanCC_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = n - 1; i >= 0; i--)
                if (a[i] % 2 == 0)
                    txtKQ.Text = a[i].ToString();
        }

        private void rdoLKChan_CheckedChanged(object sender, EventArgs e)
        {
            s = "";
            for (int i = n; i >= 0; i--)
            {
                if (a[i] % 2 == 0)
                    s += a[i] + " ";
                txtKQ.Text = s.ToString();
            }
        }

    
    }
}
