using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DTO
{
    public class NhanVienDTO
    {
        public NhanVienDTO(int id, string manv, string hoten, string gioitinh,
                           string ngaysinh, string diachi, string sdt, string email, string tongiao,
                           string cmnd, string mabp, string macv)
        {
            this.ID = id;
            this.MaNV = manv;
            this.HoTen = hoten;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaysinh;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.Email = email;
            this.TonGiao = tongiao;
            this.CMND = cmnd;
            this.MaBP = mabp;
            this.MaCV = macv;
        }

        public NhanVienDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.MaNV = row["manv"].ToString();
            this.HoTen = row["hoten"].ToString();
            this.GioiTinh = row["gioiTinh"].ToString();
            this.NgaySinh = row["ngaysinh"].ToString();
            this.DiaChi = row["diachi"].ToString();
            this.SDT = row["sdt"].ToString();
            this.Email = row["email"].ToString();
            this.TonGiao = row["tongiao"].ToString();
            this.CMND = row["cmnd"].ToString();
            this.MaBP = row["mabp"].ToString();
            this.MaCV = row["macv"].ToString();
        }
        private int iD;
        private string maNV;
        private string hoTen;
        private string gioiTinh;
        private string ngaySinh;
        private string diaChi;
        private string sDT;
        private string email;
        private string tonGiao;
        private string cMND;
        private string maBP;
        private string maCV;

        public int ID { get => iD; set => iD = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Email { get => email; set => email = value; }
        public string TonGiao { get => tonGiao; set => tonGiao = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string MaBP { get => maBP; set => maBP = value; }
        public string MaCV { get => maCV; set => maCV = value; }
    }
}
