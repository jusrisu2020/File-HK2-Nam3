using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("- Nhập số lượng nhân viên: ");
            int n = Int32.Parse(Console.ReadLine());
            Employee[] nv = new Employee[n];
            while (n < 1)
            {
                Console.Write("Nhập lại số lượng nhân viên: ");
                n = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("-->Nhập nhân viên thứ {0}: ", (i + 1));
                nv[i] = new Employee();
                nv[i].InPut();
            }
            Console.WriteLine("\n----DANH SÁCH VỪA NHẬP----");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("-->Nhập nhân viên thứ {0}: ", (i + 1));
                nv[i].Display();
            }
            Console.ReadLine();
        }
    }
}
