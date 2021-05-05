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
		private int idtrangThai;
        private string tenTT;
		private string maCV;

        public int ID { get => iD; set => iD = value; }
        public string MaTK { get => maTK; set => maTK = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenTK { get => tenTK; set => tenTK = value; }
        public string PAss { get => pAss; set => pAss = value; }
        public int IdtrangThai { get => idtrangThai; set => idtrangThai = value; }
        public string TenTT { get => tenTT; set => tenTT = value; }
        public string MaCV { get => maCV; set => maCV = value; }

        public TaiKhoanDTO(int id, string matk, string manv, string tentk, string pass, int idtrangthai,string tentt, string macv)
        {
            this.ID = id;
            this.MaTK = matk;
            this.MaNV = manv;
            this.TenTK = tentk;
            this.PAss = pass;
            this.IdtrangThai = idtrangthai;
            this.TenTT = tentt;
            this.MaCV = macv;
        }

        public TaiKhoanDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.MaTK = row["matk"].ToString();
            this.MaNV = row["manv"].ToString();
            this.TenTK = row["tentk"].ToString();
            this.PAss = row["pass"].ToString();
            this.IdtrangThai = (int)row["idtrangthai"];
            this.TenTT = row["tentt"].ToString();
            this.MaCV = row["Macv"].ToString();
        }
    }
}
