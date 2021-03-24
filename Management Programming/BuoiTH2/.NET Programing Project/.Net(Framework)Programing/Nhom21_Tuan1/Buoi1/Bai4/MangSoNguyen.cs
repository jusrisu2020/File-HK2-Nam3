using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class MangSoNguyen
    {
        //phuong thuc nhap mot so
        public int NhaSoDuong()
        {
            int so;
            do
            {
                so = Convert.ToInt32(Console.ReadLine());
            } while (so < 0);
            return so;
        }
        //phuong thuc nhap mot so
        public int NhapMotSo()
        {
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            return so;
        }
        //Phuong thuc nhap mang 
        public void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //phuong thuc in mang
        public void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(" {0} ", a[i]);
        }
        //Phuong thuc tim gia tri lon nhat 
        public int TimMax(int[] a)
        {
            int max;
            max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }
        //Phuong thuc tim so nho nhat
        public int TimMin(int[] a)
        {
            int min;
            min = a[0];
            for (int i = 0; i < a.Length; i++)
                if (min > a[i])
                    min = a[i];
            return min;
        }
        //Tong cac phan tu cua mang
        public int TinhTong(int[] a)
        {
            int s;
            s = a[0];
            for (int i = 1; i < a.Length; i++)
                s = s + a[i];
            return s;
        }
        //sap xep tang dan
        public void SapXepTang(int[] a)
        {
            int tam;
            for (int i = 0; i < a.Length; i++)
                for (int j = i + 1; j < a.Length; j++)
                    if (a[i] > a[j])
                    {
                        tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
        }
    }
}