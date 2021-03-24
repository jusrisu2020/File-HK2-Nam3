using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class TamGiac
    {
        private int _canh1;
        private int _canh2;
        private int _canh3;
        private int _chuvi;
        private int _loai;
        private float _dientich;

        //xay dung cac thuoc tinh property
        public int a
        {
            get { return _canh1; }
            set { _canh1 = value; }
        }
        public int b
        {
            get { return _canh2; }
            set { _canh2 = value; }
        }
        public int c
        {
            get { return _canh3; }
            set { _canh3 = value; }
        }
        public int Chuvi
        {
            get { return _chuvi; }
            set { _chuvi = value; }
        }
        public int Loai
        {
            get { return _loai; }
            set { _loai = value; }
        }
        public float Dientich
        {
            get { return _dientich; }
            set { _dientich = value; }
        }
        //ham tao khong tham so
        public TamGiac()
        {
            a = 2;
            b = 3;
            c = -5;
        }
        //ham tao 3 tham so
        public TamGiac(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Nhap()
        {
            Console.Write("- Nhập cạnh 1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("- Nhập cạnh 2: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("- Nhập cạnh 3: ");
            c = Convert.ToInt32(Console.ReadLine());
            while ((a + b <= c) || (b + c <= a) || (a + c <= b))
            {
                Console.WriteLine("Bạn nhập sai!!");
                Console.WriteLine("Mời Nhập lại:");
                Nhap();

            }


        }
        public void Xuat()
        {
            Console.WriteLine("----THONG TIN TAM GIAC VUA NHAP----");
            Console.WriteLine("- Cạnh 1: {0}", a);
            Console.WriteLine("- Cạnh 2: {0}", b);
            Console.WriteLine("- Cạnh 3: {0}", c);
            Console.WriteLine(" Chu vi tam giác = {0} ", ChuVi());
            Console.Write(" Diện tích tam giác = {0} ", DienTich());
            int i = Timtamgiac();
            switch (i)
            {
                case 1:
                    Console.WriteLine("\n--> Tam giác trên là tam giác đều.");
                    break;
                case 2:
                    Console.WriteLine("\n--> Tam giác trên là tam giác vuông cân.");
                    break;
                case 3:
                    Console.WriteLine("\n--> Tam giác trên là tam giác cân.");
                    break;
                case 4:
                    Console.WriteLine("\n--> Tam giác trên là tam giác vuông.");
                    break;
                case 5:
                    Console.WriteLine("\n--> Tam giác trên là tam giác thường.");
                    break;
            }


        }
        //tinh chu vi
        public int ChuVi()
        {
            return (a + b + c);
        }
        //tinh dien tich
        public double DienTich()
        {
            float p = ChuVi() / 2f;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        //kiem tra tam giac nhap vao la tam giac gi
        public int Timtamgiac()
        {
            if ((a == b) && (b == c))
                return 1;
            else
            {
                if (((a == b) || (b == c) || (a == c)) && ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b)))
                    return 2;
                else
                {
                    if ((a == b) || (b == c) || (a == c))
                        return 3;
                    else
                    {
                        if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b))
                            return 4;
                        else
                            return 5;
                    }
                }
            }
        }
    }
}
