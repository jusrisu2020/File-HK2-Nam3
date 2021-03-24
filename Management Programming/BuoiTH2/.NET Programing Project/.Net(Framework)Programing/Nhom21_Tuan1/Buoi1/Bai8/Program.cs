using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TamGiac tg = new TamGiac();
            tg.Nhap();
            tg.Xuat();
            Console.ReadLine();
        }
    }
}

