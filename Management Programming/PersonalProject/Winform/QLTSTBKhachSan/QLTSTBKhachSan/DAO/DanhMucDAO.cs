using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class DanhMucDAO
    {
        private static DanhMucDAO instance;
        public static DanhMucDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new DanhMucDAO();
                    return instance;
            }
            private set => instance = value;
        }

        public List<DanhMucDTO> LoadDanhMuc()
        {
            List<DanhMucDTO> DanhMucList = new List<DanhMucDTO>();
            string Query = "EXEC USP_SelectDanhMuc";
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                DanhMucDTO dm = new DanhMucDTO(item);
                DanhMucList.Add(dm);
            }
            return DanhMucList;
        }
    }
}
