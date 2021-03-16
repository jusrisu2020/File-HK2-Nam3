using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class CategoryDAL
    {
        private static CategoryDAL instance;

        public static CategoryDAL Instance 
        {
            get { if (instance == null) instance = new CategoryDAL(); return CategoryDAL.instance; }
            private set { CategoryDAL.instance = value; }   
        }
        private CategoryDAL() { }

        public  List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "select * from RoomCategory";
            DataTable data = Dataprovider.Instance.Excutequery(query);//datable để lấy dữ liệu ra

            foreach(DataRow item in data.Rows)
            {
                Category category= new Category(item);
                list.Add(category);
            }

            return list;
        }
    }
}
