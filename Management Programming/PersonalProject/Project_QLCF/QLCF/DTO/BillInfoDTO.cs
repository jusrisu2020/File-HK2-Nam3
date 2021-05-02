using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DTO
{
    public class BillInfoDTO
    {
        public BillInfoDTO(int id, int idbill, int idfood, int count)
        {
            this.ID = id;
            this.IdBill = idbill;
            this.IdFood = idfood;
            this.Count = count;
        }

        public BillInfoDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IdBill = (int)row["idbill"];
            this.IdFood = (int)row["idfood"];
            this.Count = (int)row["count"];
        }

        private int iD;
        private int idBill;
        private int idFood;
        private int count;

        public int ID { get => iD; set => iD = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public int Count { get => count; set => count = value; }
    }
}
