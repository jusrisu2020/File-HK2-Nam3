using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DTO
{
    public class TaiKhoanDTO
    {
		private int iD;
		private string maTK;
		private string maNV;
		private string tenTK;
		private string pAss;
		private string trangThai;
		private string loaiND;

        public int ID { get => iD; set => iD = value; }
        public string MaTK { get => maTK; set => maTK = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenTK { get => tenTK; set => tenTK = value; }
        public string PAss { get => pAss; set => pAss = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string LoaiND { get => loaiND; set => loaiND = value; }

        public TaiKhoanDTO(int id, string matk, string manv, string tentk, string pass, string trangthai, string loaind)
        {
            this.ID = id;
            this.MaTK = matk;
            this.MaNV = manv;
            this.TenTK = tentk;
            this.PAss = pass;
            this.TrangThai = trangthai;
            this.LoaiND = loaind;
        }

        public TaiKhoanDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.MaTK = row["matk"].ToString();
            this.MaNV = row["manv"].ToString();
            this.TenTK = row["tentk"].ToString();
            this.PAss = row["pass"].ToString();
            this.TrangThai = row["trangthai"].ToString();
            this.LoaiND = row["loaind"].ToString();
        }
    }
}
