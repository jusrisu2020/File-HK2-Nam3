using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class TrangThaiDAO
    {
        private static TrangThaiDAO instance;

        public static TrangThaiDAO Instance 
        {
            get
            {
                if(instance == null)
                    instance = new TrangThaiDAO();
                    return instance;
            }
            private set => instance = value; 
        }
        private TrangThaiDAO() { }

        public List<TrangThaiDTO> LoadTrangThai()
        {
            List<TrangThaiDTO> TrangThaiList = new List<TrangThaiDTO>();
            string Query = "EXEC USP_SelectTrangThai";
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach(DataRow item in data.Rows)
            {
                TrangThaiDTO tt = new TrangThaiDTO(item);
                TrangThaiList.Add(tt);
            }
            return TrangThaiList;
        }
    }
}
