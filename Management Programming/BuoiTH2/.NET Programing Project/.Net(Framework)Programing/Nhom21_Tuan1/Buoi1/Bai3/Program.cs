using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            GiaiThuaN gtn = new GiaiThuaN();
            Console.Write("Nhập số n = "); n =
            gtn.NhapMotSo();
            Console.WriteLine("Giai thừa của {0} là {1}", n, gtn.TinhGiaiThuaN(n));
            Console.ReadLine();


        }
    }
}
