using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DTO
{
    public  class BillDTO
    {
        public BillDTO(int id, DateTime? datecheckin, DateTime? datecheckout, int status)
        {
            this.ID = id;
            this.DateCheckIn = datecheckin;
            this.DateCheckOut = datecheckout;
            this.Status = status;
        }

        public BillDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["datacheckin"];

            var dateCheckOutTemp = row["datecheckout"];
            if(dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;

            this.Status = (int)row["status"];
        }

        private int iD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int status;

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
    }
}
