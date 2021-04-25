using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DTO
{
    public class BoPhanDTO
    {
        private int iD;
        private string maBP;
        private string tenBP;
        public int ID { get => iD; set => iD = value; }
        public string MaBP { get => maBP; set => maBP = value; }
        public string TenBP { get => tenBP; set => tenBP = value; }

        public BoPhanDTO(int id, string mabp, string tenbp)
        {
            this.ID = id;
            this.MaBP = mabp;
            this.TenBP = tenbp;
        }

        public BoPhanDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.MaBP = row["MaBP"].ToString();
            this.TenBP = row["TenBP"].ToString();
        }
    }
}
