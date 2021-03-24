using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float tu1, mau1, tu2, mau2,uc;

        private void btnNhan_Click(object sender, EventArgs e)
        {
            groupBox3.Text = "Kết Quả Nhân";
            float tu, mau;
            tu1 = int.Parse(txtTS1.Text);
            mau1 = int.Parse(txtMS1.Text);
            tu2 = int.Parse(txtTS2.Text);
            mau2 = int.Parse(txtMS2.Text);
            tu = (tu1 * tu2);
            mau = (mau1 * mau2);
            uc = uscln(tu, mau);
            txtTKQ.Text = (tu / uc).ToString();
            txtMKQ.Text = (mau / uc).ToString();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            float tu, mau;
            groupBox3.Text = "Kết Quả Cộng";
            tu1 = int.Parse(txtTS1.Text);
            mau1 = int.Parse(txtMS1.Text);
            tu2 = int.Parse(txtTS2.Text);
            mau2 = int.Parse(txtMS2.Text);
            tu = (tu1 * mau2)+(tu2*mau1);
            mau = (mau1 * mau2);
            uc = uscln(tu, mau);
            txtMKQ.Text = (mau / uc).ToString();
            txtTKQ.Text = (tu / uc).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            float tu, mau;
            groupBox3.Text = "Kết Quả Trừ";
            tu1 = int.Parse(txtTS1.Text);
            mau1 = int.Parse(txtMS1.Text);
            tu2 = int.Parse(txtTS2.Text);
            mau2 = int.Parse(txtMS2.Text);
            tu = (tu1 * mau2) - (tu2 * mau1);
            mau = (mau1 * mau2);
            uc = uscln(tu, mau);
            txtTKQ.Text = (tu / uc).ToString();
            txtMKQ.Text = (mau / uc).ToString();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            txtMS1.Clear();
            txtMS2.Clear();
            txtTS1.Clear();
            txtTS2.Clear();
            txtTKQ.Clear();
            txtMKQ.Clear();
            txtMS1.Focus();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            float tu, mau;
            groupBox3.Text = "Kết Quả Chia";
            tu1 = int.Parse(txtTS1.Text);
            mau1 = int.Parse(txtMS1.Text);
            tu2 = int.Parse(txtTS2.Text);
            mau2 = int.Parse(txtMS2.Text);
            tu = (tu1 * mau2);
            mau = (mau1 * tu2);
            uc = uscln(tu,mau);
            txtMKQ.Text = (mau / uc).ToString();
            txtTKQ.Text = (tu / uc).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?",
                "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
        public static float uscln(float a, float b)
        {
            if (b == 0)
                return a;
            else
                return uscln(b, a % b);
        }
    }
}
