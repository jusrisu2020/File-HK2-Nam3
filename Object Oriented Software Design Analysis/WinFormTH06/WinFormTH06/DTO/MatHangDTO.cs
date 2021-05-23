using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTH06.DTO
{
    public class MatHangDTO
    {
        private int maMH;
        private string ten;
        private int donGia;
        private int soLuongTon;
        private int maLH;

        public int MaMH { get => maMH; set => maMH = value; }
        public string Ten { get => ten; set => ten = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
        public int MaLH { get => maLH; set => maLH = value; }


        public MatHangDTO(int mamh, string ten, int dongia, int soluongton, int malh)
        {
            this.MaMH = mamh;
            this.Ten = ten;
            this.DonGia = dongia;
            this.SoLuongTon = soluongton;
            this.MaLH = malh;
        }

        public MatHangDTO(DataRow row)
        {
            this.MaMH = (int)row["mamh"];
            this.Ten = row["ten"].ToString();
            this.DonGia = (int)row["don_gia"];
            this.SoLuongTon = row["So_luong_ton"];
            this.MaLH = (int)row["malh"];
        }
    }
}
