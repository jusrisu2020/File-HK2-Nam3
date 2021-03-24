using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.Write("- Nhập số lượng sinh viên: ");
            n = int.Parse(Console.ReadLine());

            Student[] _arrStudent = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("->Nhập thông tin sinh viên thứ: " + (i + 1).ToString());
                _arrStudent[i] = new Student();
                _arrStudent[i].nhap();
            }
            Console.WriteLine("----Danh sách sinh viên----");
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "Họ Tên", "Điểm Toán", "Điểm Văn", "DTB");

            for (int i = 0; i < n; i++)
            {
                _arrStudent[i].xuat();
            }
            Console.ReadLine();
        }
    }
}
