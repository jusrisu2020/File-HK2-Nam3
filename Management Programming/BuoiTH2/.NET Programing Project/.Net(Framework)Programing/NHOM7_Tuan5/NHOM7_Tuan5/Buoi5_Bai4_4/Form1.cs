using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?",
                "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void radVuong_CheckedChanged(object sender, EventArgs e)
        {
            gbHinhVuong.Visible = true;
            gbHinhCN.Visible = false;
            gbTron.Visible = false;
            gbTG.Visible = false;
            txtNhapA.Focus();

      

        }

        private void radTron_CheckedChanged(object sender, EventArgs e)
        {
            gbHinhVuong.Visible = false;
            gbHinhCN.Visible = false;
            gbTron.Visible = true;
            gbTG.Visible = false;
            txtTronr.Focus();

        }

        private void radTG_CheckedChanged(object sender, EventArgs e)
        {
            gbHinhVuong.Visible = false;
            gbHinhCN.Visible = false;
            gbTron.Visible = false;
            gbTG.Visible = true;
            txtTGca.Focus();
        }

        private void radCN_CheckedChanged(object sender, EventArgs e)
        {
            gbTG.Visible = false;
            gbHinhCN.Visible = true;
            gbTron.Visible = false;
            gbHinhVuong.Visible = false;
            txtHCNca.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radVuong.Checked = true;
            gbHinhVuong.Visible = true;
            gbHinhCN.Visible = false;
            gbTG.Visible = false;
            gbTron.Visible = false;

            txtNhapA.Focus();


            txtDT.Enabled = false;
            txtCV.Enabled = false;

            txtcvCN.Enabled = false;
            txtdtCN.Enabled = false;

            txtcvHT.Enabled = false;
            txtdtHT.Enabled = false;

            txtcvTG.Enabled = false;
            txtdtTG.Enabled = false;
            txtktTG.Enabled = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            if(radVuong.Checked)
            {
                int a = int.Parse(txtNhapA.Text);
                txtCV.Text = (a * 4).ToString();
                txtDT.Text = (a * a).ToString();
            }
            else if(radCN.Checked)
            {
                int a = int.Parse(txtHCNca.Text);
                int b = int.Parse(txtCNcb.Text);
                txtcvCN.Text = ((a + b) * 2).ToString();
                txtdtCN.Text = (a * b).ToString();
            }
            else if(radTron.Checked)
            {
                float r = float.Parse(txtTronr.Text);
                txtcvHT.Text = (r * 3.14 * 2).ToString();
                txtdtHT.Text = (r * r * 3.14).ToString();
            }
            else
            {
                float a = float.Parse(txtTGca.Text);
                float b = float.Parse(txtTGcb.Text);
                float c = float.Parse(txtTGcc.Text);
                float x, y, z;
                x = a * a;
                y = b * b;
                z = c * c;
                if(x==y||y==z||z==x)
                {
                    if (x == y && y == z)
                        txtktTG.Text = "Tam Giác Cân";
                    else
                    {
                        if (x == y + z || y == x + z || z == x + y)
                            txtktTG.Text = "Tam Giác Vuông Cân";
                        else
                            txtktTG.Text = "Tam Giác Cân";
                    }    

                }
                else
                {
                    if (x == y + z || y == x + z || z == x + y)
                        txtktTG.Text = "Tam Giác Vuông ";
                    else
                        txtktTG.Text = "Tam Giác Thường";
                }
                float p = (a + b + c) / 2;
                float dt = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                txtcvTG.Text = (a + b + c).ToString();
                txtdtTG.Text = dt.ToString();
            }
        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            txtNhapA.Clear();
            txtCV.Clear();
            txtDT.Clear();

            txtTGca.Clear();
            txtTGcb.Clear();
            txtTGcc.Clear();
            txtktTG.Clear();
            txtcvTG.Clear();
            txtdtTG.Clear();

            txtTronr.Clear();
            txtcvHT.Clear();
            txtdtHT.Clear();

            txtHCNca.Clear();
            txtCNcb.Clear();
            txtcvCN.Clear();
            txtdtCN.Clear();


        }
    }
}
