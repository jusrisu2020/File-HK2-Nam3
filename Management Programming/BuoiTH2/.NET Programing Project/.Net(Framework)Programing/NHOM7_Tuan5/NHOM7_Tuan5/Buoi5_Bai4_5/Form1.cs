using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai4_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Khai báo biến
        int[] a;
        //Để public để dễ sử dụng ở Form2
        public int n;

        //CÁC PHƯƠNG THỨC
        public void TaoMang(int n)
        {
            //Khai báo mảng có n phần tử nhập từ Textbox
            a = new int[n];

            //Khởi tạo giá tri ngẫu nhiên cho mảng
            int num1;
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                num1 = rd.Next(-10, 100);  //Tạo số ngẫu nhiên nằm giữa -10 và 100
                a[i] = num1;
            }
        }
        //Xuất mảng 
        public String XuatMang()
        {
            String chuoi = "";
            for (int i = 0; i < a.Length; i++)
                chuoi += a[i] + "  ";
            return chuoi;
        }

        //Tính tổng giá trị mảng
        public int Sum()
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s = s + a[i];
            }
            return s;
        }

        //Đếm số phần tử lẻ
        public int DemPTuLe()
        {
            int dem = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                    dem++;
            }
            return dem;
        }

        //Tổng giá trị phần tử lẻ
        public int TongLe()
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                    s = s + a[i];
            }
            return s;
        }

        //Tìm phần tử nhỏ nhất
        public int TimMin()
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            return min;
        }

        //Sắp xếp mảng tăng
        public void SapXepTang()
        {
            int temp;
            for (int i = 0; i < a.Length; i++)
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
        }

        //Sắp xếp mảng giảm
        public void SapXepGiam()
        {
            int temp;
            for (int i = 0; i < a.Length; i++)
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
        }

        //Tăng mỗi phần tử lên 2
        public void TangpPtu2()
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] + 2;
            }
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTongM_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng";
            else
            {
                lblKQ.Text = "Tổng mảng là: " + Sum();
            }
        }

        private void btnXM_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng";
            else
            {

                TaoMang(n);
               
                {
                    lblMang.Text = XuatMang();
                    lblKQ.Text = XuatMang();
                }
            }
        }

        private void btnDemle_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng";
            else
            {
                lblKQ.Text = "Số phần tử lẻ là:  " + DemPTuLe();
            }
        }

        private void btnTongle_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                lblKQ.Text = "Tổng các phần tử lẻ là: " + TongLe();
            }
        }

        private void btnTimNN_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng";
            else
            {
                lblKQ.Text = "Phần tử nhỏ nhất trong mảng là: " + TimMin();
            }
        }

        private void btnTangPT_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng";
            else
            {
                TangpPtu2();
                lblKQ.Text = XuatMang();
            }
        }

        private void btnSXT_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng";
            else
            {
                SapXepTang();
                lblKQ.Text = "Mảng tăng dần: " + XuatMang();
            }
        }

        private void btnSXG_Click(object sender, EventArgs e)
        {
            if (n == 0)
                lblKQ.Text = "Mảng rỗng";
            else
            {
                SapXepGiam();
                lblKQ.Text = "Mảng giảm dần: " + XuatMang();
            }
        }
    }
}
