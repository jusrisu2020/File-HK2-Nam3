using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean KTSNT(int so)
        {
            if (so <= 1)
                return false;
            else
            {
                for (int i = 2; i <= so / 2; i++)
                {
                    if (so % i == 0)
                        return false;
                }
            }
            return true;
        }

      

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtKTSNT.Clear();
            txtTimSNT.Clear();
            txtN.Focus();
        }

        private void txtN_TextChanged_1(object sender, EventArgs e)
        {
            if (txtN.Text != String.Empty)
                if (txtN.Text != " ")
                {
                    int n = int.Parse(txtN.Text);
                    if (KTSNT(n))
                    {
                        txtKTSNT.Text = n + " Là Số Nguyên Tố:";

                    }
                    else
                        txtKTSNT.Text = n + " Không là Số Nguyên Tố:";
                    String snt = " ";
                    for (int i = 2; i < n; i++)
                    {
                        if (KTSNT(i))
                        {
                            snt += i + " ";
                            txtTimSNT.Text = snt;
                        }
                    }
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?",
                "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void txtTimSNT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
