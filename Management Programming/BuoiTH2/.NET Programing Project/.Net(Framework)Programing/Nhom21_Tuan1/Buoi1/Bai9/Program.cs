using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ptbachai t = new ptbachai();
            t.Nhap();
            t.Xuat();
            t.Tinhptbachai();
            Console.ReadKey();
        }
    }
}
