using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class RoomDAL
    {
        private static RoomDAL instance;

        public static RoomDAL Instance
        {
            get { if (instance == null)instance = new RoomDAL(); return RoomDAL.instance; }
            private set { RoomDAL.instance = value; }
        }
        private RoomDAL() { }

        public List<Room> GetRoomByCategiryID(int id)
        {
            List<Room> list = new List<Room>();

            string query = "select * from Room where idCategory = " + id; // lấy all thông tin trong bảng Room theo điều kiện là id mình truyền vào.
            DataTable data = Dataprovider.Instance.Excutequery(query);

            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                list.Add(room);
            }
            return list;
        }
    }
}
