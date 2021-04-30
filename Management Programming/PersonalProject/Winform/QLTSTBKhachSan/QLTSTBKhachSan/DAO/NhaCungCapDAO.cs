using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;
        public static NhaCungCapDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new NhaCungCapDAO();
                    return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private NhaCungCapDAO() { }
        public List<NhaCungCapDTO> LoadNCC()
        {
            List<NhaCungCapDTO> NCCList = new List<NhaCungCapDTO>();
            string Query = "EXEC USP_SelectNhaCungCap";
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                NhaCungCapDTO Table = new NhaCungCapDTO(item);
                NCCList.Add(Table);
            }
            return NCCList;
        }
    }
}
