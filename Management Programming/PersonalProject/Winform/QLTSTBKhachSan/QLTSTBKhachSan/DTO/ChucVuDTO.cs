using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DTO
{
    public class ChucVuDTO
    {
        public ChucVuDTO(int id, string macv, string tencv)
        {
            this.ID = id;
            this.MaCV = macv;
            this.TenCV = tencv;
        }

        public ChucVuDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.MaCV = row["macv"].ToString();
            this.TenCV = row["tencv"].ToString();
        }

        private int iD;
        private string maCV;
        private string tenCV;

        public int ID { get => iD; set => iD = value; }
        public string MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
    }
}
