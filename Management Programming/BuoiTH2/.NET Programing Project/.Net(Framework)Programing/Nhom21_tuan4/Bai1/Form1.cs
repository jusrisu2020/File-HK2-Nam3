using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] a = new int[100];
        int n = 0;
        int mang;
        private void btnNhap_Click(object sender, EventArgs e)
        {

            try
            {
                a[n] = int.Parse(this.txtNhap.Text);
                n++;
                this.lblKQ.Text += this.txtNhap.Text + " ";
                this.txtNhap.Clear();
                this.txtNhap.Focus();

                if (n > 0)
                    this.btnIn.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Hãy nhập phần tử nảng", "Thông báo");

            }

            /*if (this.n == this.mang)
            {
                this.txtNhap.Text = "";
                MessageBox.Show("Mảng đầy", "Thông báo");
            }
            else
            {
                if (this.txtNhap.Text == "")

                    MessageBox.Show("Hãy nhập phần tử nảng", "Thông báo");

                else
                {

                    a[n] = int.Parse(this.txtNhap.Text);
                    n++;
                    this.lblKQ.Text += this.txtNhap.Text + " ";
                    this.txtNhap.Clear();
                    this.txtNhap.Focus();

                    if (n > 0)
                        this.btnIn.Enabled = true;

                }
            }*/
        }









        private void btnIn_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Các phần tử trong mảng là: \n\r" + InMang();

        }

        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < n; i++)
                chuoi += a[i] + " ";
            return chuoi;
        }

        private void btnSLN_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                TimMax();
                this.lblKQ.Text = "Mang la: " + InMang() + " \n" + "SLN là: " + TimMax();

            }
        }


        public int TimMax()
        {
            int max = a[0];
            for (int i = 1; i < n; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }

        private void btnSNN_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                TimMin();
                this.lblKQ.Text = "Mang la: " + InMang() + " \n" + "SNN là: " + TimMin();

            }
        }
        public int TimMin()
        {
            int min = a[0];
            for (int i = 0; i < n; i++)
                if (a[i] < min)
                    min = a[i];
            return min;
        }


        private void btnTBMang_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                TrungBinhMang();
                this.lblKQ.Text = "Mang la: " + InMang() + " \n" + "Trung bình của mảng là: " + TrungBinhMang();

            }
        }
        public double TrungBinhMang()
        {
            int Tong = 0;
            for (int i = 0; i < n; i++)
                Tong += a[i];
            double TB = (double)Tong / (double)n;
            return TB;
        }
       

        private void btnUCLN_Click_1(object sender, EventArgs e)
        {
            lblKQ.Text = "Ƣớc chung lớn nhất 2 phần tử đầu " + a[0] + " và " + a[1] + " là " +
             timUCLN(a[0], a[1]).ToString();
        }
        public int timUCLN(int a, int b)
         {
             a = Math.Abs(a);
             b = Math.Abs(b);
             while (a != b)
             {
                 if (a > b) a = a - b;
                 else b = b - a;
             }
             return a;
         }
        private void btnSXTang_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                SapXepTang();
                this.lblKQ.Text = "Đã sắp xếp mảng tăng dần" + InMang();

            }
        }
        public void SapXepTang()
        {
            int tang;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {

                        tang = a[i];
                        a[i] = a[j];
                        a[j] = tang;
                    }
                }
            }
        }

        private void btnSXGiam_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                SapXepGiam();
                this.lblKQ.Text = "Đã sắp xếp mảng giảm dần " + InMang();
            }
        }

        public void SapXepGiam()
        {
            int giam;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        // Hoan vi 2 so a[i] va a[j]
                        giam = a[i];
                        a[i] = a[j];
                        a[j] = giam;
                    }
                }
            }
        }

        public Boolean kiemTraSNT(int so)
        {
            if (so <= 0)
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

        public int demSNT()
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (kiemTraSNT(a[i]))
                    dem++;
            }
            return dem;
        }

        public String inSNT()
        {
            String chuoi = "";
            for (int i = 0; i < n; i++)
            {

                if (kiemTraSNT(a[i]))
                    chuoi += a[i] + " ";

            }
            return chuoi;
        }

        private void btnSoNguyenTo_Click_1(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có " + demSNT().ToString() + " số nguyên tố là " + inSNT();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        long TongMang(int[] n)
        {
            long tong = 0;
            int i = 0;
            while(i<n.Length)
            {
                tong += n[i++];
            }
            return tong;
        }



        private void btnTong_Click(object sender, EventArgs e)
        {
            lblKQ.Text ="Mảng có: "+InMang() +"Tổng mảng là:"+"\n"+ Convert.ToString(TongMang(a));

        }



        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            this.lblKQ.Text = "";
            this.txtNhap.Focus();
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
        public int DSChan()
        {
            int chan = 0;
            for (int i = 0; i < n; i++)
                if (a[i] % 2 == 0)
                    chan++;
            return chan;

        }
        private void btnDSChan_Click_1(object sender, EventArgs e)
        {

         
            if (n == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có " + InMang() + "\n" + " số chẳn là " + DSChan();
        }

        public int DSLe()
        {
            int le = 0;
            for (int i = 0; i < n; i++)
                if (a[i] % 2 != 0)
                    le++;
            return le;

        }
        private void lblKQ_Click(object sender, EventArgs e)
        {

        }

        

        private void btnSoNguyenTo_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có " + demSNT().ToString() + " số nguyên tố là " + inSNT();
        }

        private void btnTBMang_Click_1(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có " + InMang() + "\n" + " Trung Bình mảng là:  " + TrungBinhMang();
        }

        private void btnDSLe_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có " + InMang() + "\n" + " số lẻ là " + DSLe();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblKQ.Text = " ";
            Array.Resize(ref a, 0);
            btnXoa.Enabled = false;
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }
        int sopt;
        public Boolean KTSHH(int so)
        {
            int sum = 0;
            for (int i = 1; i < sopt; i++)
            {
                if (so % i == sopt) sum += i;
            }
            if (sum == so) 
                return true;
            else return false;
        }
        public int DemSHH()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (KTSHH(a[i])) dem++;
            }
            return dem;
        }
        public String InSHH()
        {
            string chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (KTSHH(a[i]))
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }
        private void btnSoHoanHao_Click(object sender, EventArgs e)
        {
            if (lblKQ.Text == "")
            {
                lblKQ.Text = "Mang rong";
            } 
            else
            {
                lblKQ.Text = "Mang co " + DemSHH() + " SHH " + " la: " + InSHH();
            }
        }
    }
}
