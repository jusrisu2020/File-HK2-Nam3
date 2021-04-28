using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DTO
{
    public class NhaCungCapDTO
    {
		private int iD;
		private string maNCC;
		private string tenNCC;
		private string sDT;
		private string diaChi;
		private string eMail;
		private string sTK;
		private string tenCongTy;

        public int ID { get => iD; set => iD = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string STK { get => sTK; set => sTK = value; }
        public string TenCongTy { get => tenCongTy; set => tenCongTy = value; }

        public NhaCungCapDTO(int id, string mancc, string tenncc, string sdt, string diachi, string email, string stk, string tencongty)
        {
            this.ID = id;
            this.MaNCC = mancc;
            this.TenNCC = tenncc;
            this.SDT = sdt;
            this.DiaChi = diachi;
            this.EMail = email;
            this.STK = stk;
            this.TenCongTy = tencongty;
        }

        public NhaCungCapDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.MaNCC = row["mancc"].ToString();
            this.TenNCC = row["tenncc"].ToString();
            this.SDT = row["sdt"].ToString();
            this.DiaChi = row["diachi"].ToString();
            this.EMail = row["email"].ToString();
            this.STK = row["stk"].ToString();
            this.TenCongTy = row["tencongty"].ToString();
        }

    }
}
