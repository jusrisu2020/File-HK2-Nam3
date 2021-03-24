using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
     class ptbachai
    {
        private int Soa;
        private int Sob;
        private int Soc;

        public ptbachai()
        {
            Soa = 0;
            Sob = 0;
            Soc = 0;
        }

        public ptbachai(int a, int b, int c)
        {
            this.Soa = a;
            this.Soa = b;
            this.Soc = c;
        }
        public int a
        {
            get { return Soa; }
            set { Soa = value; }
        }
        public int b
        {
            get { return Sob; }
            set { Sob = value; }
        }
        public int c
        {
            get { return Soc; }
            set { Soc = value; }
        }
        public void Nhap()
        {
            do
            {
                Console.Write("Nhập số a - khác 0 " +
                    "(nhập sai là nhập lại nhaaaaaaaaaaaa): ");
                a = int.Parse(Console.ReadLine());
            } while (a == 0);
            Console.Write("Nhập số b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhập số c: ");
            c = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("----PHƯƠNG TRÌNH CÓ DẠNG----");
            Console.WriteLine("   {0}*x^2 + {1}*x + {2} = 0", a, b, c);
        }
        public void Tinhptbachai()
        {
            int delta = this.b * this.b - (4 * this.a * this.c);
            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
            else if (delta > 0)
            {
                double x2 = (((-1) * b + Math.Sqrt(delta)) / (2 * a));

                double x1 = (((-1) * b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("phương trình có hai nghiệm phân biệt: x1 = {0} , x2 = {1} ", x1, x2);

            }
            else if (delta == 0)
            {
                float x = -b / 2 * a;
                Console.WriteLine("Phương trình có nghiệm kép: x = {0} ", x);

            }
        }
    }
}
