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
        private string tenHienThi;
		private string pAss;
		private string maCV;

        public int ID { get => iD; set => iD = value; }
        public string MaTK { get => maTK; set => maTK = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenTK { get => tenTK; set => tenTK = value; }
        public string TenHienThi { get => tenHienThi; set => tenHienThi = value; }
        public string PAss { get => pAss; set => pAss = value; }
        public string MaCV { get => maCV; set => maCV = value; }

        public TaiKhoanDTO(int id, string matk, string manv, string tentk,string tenhienthi, string pass, string macv)
        {
            this.ID = id;
            this.MaTK = matk;
            this.MaNV = manv;
            this.TenTK = tentk;
            this.TenHienThi = tenhienthi;
            this.PAss = pass;
            this.MaCV = macv;
        }

        public TaiKhoanDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.MaTK = row["matk"].ToString();
            this.MaNV = row["manv"].ToString();
            this.TenTK = row["tentk"].ToString();
            this.TenHienThi = row["tenhienthi"].ToString();
            this.PAss = row["pass"].ToString();
            this.MaCV = row["Macv"].ToString();
        }
    }
}
