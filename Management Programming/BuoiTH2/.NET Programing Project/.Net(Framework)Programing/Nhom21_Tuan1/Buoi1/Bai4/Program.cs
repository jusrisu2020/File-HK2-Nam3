using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MangSoNguyen msn = new MangSoNguyen();
            int n;
            Console.Write("Nhập vào số phần tử của mảng: ");
            n = msn.NhaSoDuong();
            int[] a = new int[n];
            msn.NhapMang(a);
            Console.WriteLine("---Mảng vừa nhập---");
            msn.InMang(a);
            Console.WriteLine("\n- Số lớn nhất trong mảng: {0}", msn.TimMax(a));
            Console.WriteLine("\n- Số nhỏ nhất trong mảng: {0}", msn.TimMin(a));
            Console.WriteLine("\n- Tổng các phần tử trong mảng: {0}", msn.TinhTong(a));
            msn.SapXepTang(a);
            Console.WriteLine("\n---Danh sách sắp xếp tăng---");
            msn.InMang(a);
            Console.ReadLine();
        }
    }
}
