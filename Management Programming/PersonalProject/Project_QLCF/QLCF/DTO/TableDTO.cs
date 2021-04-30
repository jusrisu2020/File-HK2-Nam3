using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DTO
{
    public class TableDTO
    {
        public TableDTO(int id, string nametext, string status)
        {
            this.ID = id;
            this.NameText = nametext;
            this.StaTus = status;
        }

       
        public TableDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.NameText = row["nametext"].ToString();
            this.StaTus = row["status"].ToString();
        }

        private int iD;
        private string nameText;
        private string staTus;

        public int ID { get => iD; set => iD = value; }
        public string NameText { get => nameText; set => nameText = value; }
        public string StaTus { get => staTus; set => staTus = value; }
    }
}
