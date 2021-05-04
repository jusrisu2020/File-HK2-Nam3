using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DTO
{
    public class TrangThaiDTO
    {
        public TrangThaiDTO(int id, string tentt)
        {
            this.ID = id;
            this.TenTT = tentt;
        }

        public TrangThaiDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.TenTT = row["TenTT"].ToString();
        }

        private int iD;
        private string tenTT;

        public int ID { get => iD; set => iD = value; }
        public string TenTT { get => tenTT; set => tenTT = value; }
    }
}
