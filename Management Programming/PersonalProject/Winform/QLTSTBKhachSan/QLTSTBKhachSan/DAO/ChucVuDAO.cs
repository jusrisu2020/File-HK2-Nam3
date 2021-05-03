using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class ChucVuDAO
    {
        private static ChucVuDAO instance;
        public static ChucVuDAO Instance 
        { get
            {
                if (instance == null)
                    instance = new ChucVuDAO();
                    return instance;
            }
            private set => instance = value; 
        }

        public List<ChucVuDTO> LoadChucVu() 
        {
            List<ChucVuDTO> ChucVuList = new List<ChucVuDTO>();
            string Query = "EXEC USP_SelectChucVu";
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach(DataRow item in data.Rows)
            {
                ChucVuDTO cv = new ChucVuDTO(item);
                ChucVuList.Add(cv);
            }
            return ChucVuList;
        }
    }
}
