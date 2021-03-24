using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai4_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n = 0;
        string s;
        int h;
        int[] a = new int[100];
        public void TongMang()
        {

            int TM = 0;
            for (int i = 0; i <= n; i++)
            {

                TM = TM + a[i];
                txtTM.Text = TM.ToString();
            }
        }
        public void TSoChan()
        {
            int TC = 0;
            for (int i = 0; i <= n; i++)
            {
                if (a[i] % 2 == 0)
                    TC = TC + a[i];
                txtTC.Text = TC.ToString();
            }
        }
        public void TSoLe()
        {
            int TL = 0;

            for (int i = 0; i <= n; i++)
            {
                if (a[i] % 2 != 0)
                    TL = TL + a[i];
                txtTL.Text = TL.ToString();
            }
        }
        public void Max_Min()
        {
            int max = 0;
            for (int i = 0; i <= n; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            txtMax.Text = max.ToString();
            for (int i = 0; i <= n; i++)
            {
                if (a[i] < max)
                    max = a[i];
            }
            txtMin.Text = max.ToString();
        }
        public void SXT_SXG()
        {
            if (chkTang.Checked == true)
            {
                int tam = 0;
                for (int i = 0; i <= n; i++)
                    for (int j = i + 1; j <= n; j++)
                        if (a[i] > a[j])
                        {
                            tam = a[i];
                            a[i] = a[j];
                            a[j] = tam;

                        }
                s = " ";
                for (int i = 0; i <= n; i++)
                    s = s + " " + a[i].ToString();
                txtKQ.Text = s.Trim();
            }
            else if (chkGiam.Checked == true)
            {
                int tam = 0;
                for (int i = 0; i <= n; i++)
                    for (int j = i + 1; j <= n; j++)
                        if (a[i] < a[j])
                        {
                            tam = a[i];
                            a[i] = a[j];
                            a[j] = tam;

                        }
                s = " ";
                for (int i = 0; i <= n; i++)
                    s = s + " " + a[i].ToString();
                txtKQ.Text = s.Trim();
            }
            else
            {
                txtKQ.Text = "Bạn cần chọn 1 trong 2(SXT - SXG)!";
            }
        }
        public void TTViTri()
        {
            int l = int.Parse(txtVT.Text);
            int k = int.Parse(txtTT.Text);

            if (l <= n)
                a[l] = k;
            s = " ";
            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    s = s + a[i].ToString();
                }
                else
                    s = s + " " + a[i].ToString();
            }
            txtKQ.Text = s.Trim();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            s = (txtNhap.Text).Trim(); //cắt chuỗi
            h = s.LastIndexOf(" ");//tìm vị trí chỉ mục của lần xuất hiện cuối cùng của một ký tự được chỉ định trong Chuỗi
            string s1;
            while (h != -1)
            {
                s1 = s.Substring(h);//chuỗi con
                s = s.Substring(0, h);
                a[n] = Convert.ToInt32(s1);
                n++;
                h = s.LastIndexOf(" ");
            }
            a[n] = Convert.ToInt32(s);
            s = " ";
            for (h = n; h >= 0; h--)
                s = s + " " + a[h].ToString();
            txtKQ.Text = s.Trim();
        }

        private void btnLL_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= n; i++)
            {
                a[i] = a[i + 1];
                n--;
                s = " ";
                for (int y = 0; y <= n; y++)
                    s = s + " " + a[i].ToString();
                txtKQ.Text = s.Trim();
            }
            txtNhap.ResetText();
            txtKQ.ResetText();
            txtTL.ResetText();
            txtTC.ResetText();
            txtMax.ResetText();
            txtMin.ResetText();
            txtTM.ResetText();
            txtVT.ResetText();
            txtTT.ResetText();
            chkGiam.Checked = false;
            chkTang.Checked = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Max_Min();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            TongMang();
            TSoChan();
            TSoLe();
        }

        private void btnSX_Click(object sender, EventArgs e)
        {
            SXT_SXG();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            TTViTri();
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?",
                "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
