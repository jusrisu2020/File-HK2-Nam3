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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            int[] a;
            int n;
        public void TaoMangRD(int n)
        {            
            a = new int[n];          
            int num1;
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                
                num1 = rd.Next(-10, 100);
                a[i] = num1;
            }
        }
        public string InMang()
        {
            string chuoi = "";
            for (int i = 0; i < a.Length; i++)
            {
                chuoi += a[i] + " ";
            }
            return chuoi;
        }
        private void btnTaoMang_Click(object sender, EventArgs e)
        {          
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Hãy nhập số phần tử mảng!", "Thông báo");
                txtNhap.Focus();            
            }
            else if(int.Parse(txtNhap.Text) < 0)
            {
                MessageBox.Show("Số phần tử < 0 nhé!, nhập lại bạn ê!", "Thông báo");
                txtNhap.Focus();
            }
            else
            {
                n = Convert.ToInt32(txtNhap.Text);
                TaoMangRD(n);
                MessageBox.Show("Mảng có " + n + " phần tử ngẫu nhiên vừa tạo: " + InMang());
                btnSum.Enabled = true;
                btnMax.Enabled = true;
            }
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            DialogResult ph;
            ph = MessageBox.Show("Các phần tử trong mảng: "+InMang()+" Bạn có muốn tính tổng? ","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(ph == DialogResult.Yes)
            {
                Form2 f2 = new Form2();
                Form1 f1 = new Form1();

                int[] b = new int[a.Length];
                a.CopyTo(b, 0);
                f2.SumMang(b);
                f1.Hide();
                f2.ShowDialog();
            }
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            DialogResult ph;
            ph = MessageBox.Show("Cac phan tu trong mang: " + InMang() + " Ban co muon tim MAX? ", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ph == DialogResult.Yes)
            {
                Form3 f3 = new Form3();
                Form1 f1 = new Form1();

                int[] c = new int[a.Length];
                a.CopyTo(c, 0);
                f3.MaxMang(c);
                f1.Hide();
                f3.ShowDialog();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
        }
    }
}
