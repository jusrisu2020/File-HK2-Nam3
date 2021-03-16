using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class BillInfo
    {
        public BillInfo(int id,int billID, int roomID,int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.RoomID = roomID;
            this.Count = count;
        }
        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID = (int)row["idBill"];
            this.RoomID = (int)row["idRoom"];
            this.Count = (int)row["count"];
        }
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private int roomID;
        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        private int billID;
        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

  
    }
}
