using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DTO
{
    public class ThietBiDTO
    {
        private int iD;
        private string maTB;
        private string tenTB;
        private string donVi;
        private int soLuongHienHuu;
        private string maDanhMuc;
        private string maBP;
        private string thoiGianBH;
        private string tinhTrangTB;
        private string maNCC;
        private string maHDMuaTB;
        private string ghiChu;

        
        public int ID { get => iD; set => iD = value; }
        public string MaTB { get => maTB; set => maTB = value; }
        public string TenTB { get => tenTB; set => tenTB = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public int SoLuongHienHuu { get => soLuongHienHuu; set => soLuongHienHuu = value; }
        public string MaDanhMuc { get => maDanhMuc; set => maDanhMuc = value; }
        public string MaBP { get => maBP; set => maBP = value; }
        public string ThoiGianBH { get => thoiGianBH; set => thoiGianBH = value; }
        public string TinhTrangTB { get => tinhTrangTB; set => tinhTrangTB = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string MaHDMuaTB { get => maHDMuaTB; set => maHDMuaTB = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public ThietBiDTO(int id, string matb, string tentb, string donvi,
                        int soluonghienhuu, string madanhmuc, string mabp, string thoigianbaohanh,
                        string tinhtrangthietbi, string mancc, string mahdmuatb, string ghichu
                            )
        {
            this.ID = id;
            this.MaTB = matb;
            this.TenTB = tentb;
            this.DonVi = donvi;
            this.SoLuongHienHuu = soluonghienhuu;
            this.MaDanhMuc = madanhmuc;
            this.MaBP = mabp;
            this.ThoiGianBH = thoigianbaohanh;
            this.TinhTrangTB = tinhtrangthietbi;
            this.MaNCC = mancc;
            this.MaHDMuaTB = mahdmuatb;
            this.GhiChu = ghichu;
        }
        
        public ThietBiDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.MaTB = row["matb"].ToString();
            this.TenTB = row["tentb"].ToString();
            this.DonVi = row["donvi"].ToString();
            this.SoLuongHienHuu = (int)row["SoLuongHienHuu"];
            this.MaDanhMuc = row["madanhmuc"].ToString();
            this.MaBP = row["mabp"].ToString();
            this.ThoiGianBH = row["ThoiGianBH"].ToString();
            this.TinhTrangTB = row["TinhTrangTB"].ToString();
            this.MaNCC = row["mancc"].ToString();
            this.MaHDMuaTB = row["MaHDMuaTB"].ToString();
            this.GhiChu = row["GhiChu"].ToString();
        }
    }
}
