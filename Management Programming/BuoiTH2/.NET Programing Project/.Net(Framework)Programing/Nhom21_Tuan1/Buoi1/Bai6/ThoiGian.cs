using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class ThoiGian
    {
        private int Date;
        private int Month;
        private int Year;
        private int Hour;
        private int Minute;
        private int Second;
        public int Ngay
        {
            get { return Date; }
            set
            {
                if ((value >= 1) && (value <= 30))
                    Date = value;
                else
                    Date = 0;
            }
        }
        public int Thang
        {
            get { return Month; }
            set
            {
                if ((value >= 1) && (value <= 12))
                    Month = value;
                else
                    Month = 0;
            }
        }
        public int Nam
        {
            get { return Year; }
            set { Year = value; }
        }
        public int Gio
        {
            get { return Hour; }
            set
            {
                if ((value >= 0) && (value <= 24))
                    Hour = value;
                else
                    Hour = 0;
            }
        }
        public int Phut
        {
            get { return Minute; }
            set
            {
                if ((value >= 0) && (value <= 60))
                    Minute = value;
                else
                    Minute = 0;
            }
        }

        public int Giay
        {
            get { return Second; }
            set
            {
                if (value <= 0 && value >= 59)
                    Giay = value;
                else
                    Second = 0;
            }
        }
        public ThoiGian()
        {
            this.Nam = 2014;
            this.Thang = 09;
            this.Ngay = 20;
            Gio = 10;
            Phut = 30;
            Giay = 40;
        }
        public ThoiGian(int Date, int Month, int Year, int Hour, int Minute, int Second)
        {
            Nam = Year;
            Thang = Month;
            Ngay = Date;
            Gio = Hour;
            Phut = Minute;
            Giay = Second;
        }
        public ThoiGian(int Ngay, int Thang, int Nam)
        {
            this.Ngay = Ngay;
            this.Thang = Thang;
            this.Nam = Nam;
        }
        public ThoiGian(ThoiGian tg)
        {
            Nam = tg.Nam;
            Thang = tg.Thang;
            Ngay = tg.Ngay;
            Gio = tg.Gio;
            Phut = tg.Phut;
            Giay = tg.Giay;
        }
        //hàm tạo với tham so lj đối tượng của lớp System.DateTime
        public ThoiGian(System.DateTime tg)
        {
            Nam = tg.Year;
            Thang = tg.Month;
            Ngay = tg.Day;
            Gio = tg.Hour;
            Phut = tg.Minute;
            Giay = tg.Second;
        }
        public void Hien()
        {
            System.Console.WriteLine("\t Ngày: {0}/{1}/{2}", Ngay, Thang, Nam);
            System.Console.WriteLine("\t Giờ: {0}:{1}:{2}", Gio, Phut, Giay);
        }
    }
}

