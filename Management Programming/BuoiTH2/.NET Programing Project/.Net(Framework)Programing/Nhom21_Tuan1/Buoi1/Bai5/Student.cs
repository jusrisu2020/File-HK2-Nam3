using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Student
    {
        private string _hoTen;
        private int _tuoi;
        private double _diemToan;
        private double _diemVan;
        private double _dtb;
        //Hàm khởi tạo không có tham số
        public Student()
        {
            HoTen = "";
            DiemVan = 0;
            DiemToan = 0;
            Dtb = 0;
        }
        //Các phương thức Properties để get/set giá trị cho các thuộc tính
        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        public int Tuoi
        {
            get { return _tuoi; }
            set { _tuoi = value; }

        }
        public double DiemToan
        {
            get { return _diemToan; }
            set { _diemToan = value; }
        }
        public double DiemVan
        {
            get { return _diemVan; }
            set { _diemVan = value; }
        }
        public double Dtb
        {
            get { return Math.Round(((DiemToan + DiemVan) / 2), 2); }
            set { _dtb = value; }
        }
        //Các phương thức nhập/xuất dữ liệu
        public void nhap()
        {
            Console.Write(" \t -Nhap ho ten:");
            HoTen = Console.ReadLine();
            Console.Write(" \t -Nhap diem toan:");
            Double temp;
            temp = double.Parse(Console.ReadLine());
            if (temp > 10 || temp < 0)
            {
                Console.WriteLine(" \t !!! Diem phai nam trong khoang 0 -> 10");
                Console.Write(" \t -Nhap lai diem toan:");
                temp = double.Parse(Console.ReadLine());
            }
            DiemToan = temp;
            Console.Write(" \t -Nhap diem van:");
            temp = double.Parse(Console.ReadLine());
            if (temp > 10 || temp < 0)
            {
                Console.WriteLine(" \t -Diem phai nam trong khoang 0 -> 10");
                Console.Write(" \t -Nhap lai diem Van:");
                temp = double.Parse(Console.ReadLine());
            }
            DiemVan = temp;
        }
        public void xuat()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", HoTen, DiemToan, DiemVan, Dtb);
        }
    }
}

