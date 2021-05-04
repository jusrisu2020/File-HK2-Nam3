using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DTO
{
    public class DanhMucDTO
    {
        public DanhMucDTO(int id, string madanhmuc, string tendanhmuc)
        {
            this.ID = id;
            this.MaDanhMuc = madanhmuc;
            this.TenDanhMuc = tendanhmuc;
        }

        public DanhMucDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.MaDanhMuc = row["madanhmuc"].ToString();
            this.TenDanhMuc = row["tendanhmuc"].ToString();
        }

        private int iD;
        private string maDanhMuc;
        private string tenDanhMuc;

        public int ID { get => iD; set => iD = value; }
        public string MaDanhMuc { get => maDanhMuc; set => maDanhMuc = value; }
        public string TenDanhMuc { get => tenDanhMuc; set => tenDanhMuc = value; }
    }
}
