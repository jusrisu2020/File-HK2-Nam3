using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TimSLN sln = new TimSLN();
            int n;
            Console.Write("Nhập n = "); 
            n = sln.NhapMotSo();
            Console.WriteLine("Số lớn nhất trong {0} vừa nhập là {1} ", n, sln.TimMax(n));
            Console.ReadLine();
        }
    }
}
