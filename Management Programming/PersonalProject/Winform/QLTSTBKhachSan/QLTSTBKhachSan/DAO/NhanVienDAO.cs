using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                    return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<NhanVienDTO> LoadNhanVien()
        {
            List<NhanVienDTO> NhanVienList = new List<NhanVienDTO>();
            string SNhanVien = "EXEC dbo.USP_SelectNhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(SNhanVien);
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO table = new NhanVienDTO(item);
                NhanVienList.Add(table);
            }
            return NhanVienList;
        }
        public void DeleteNhanVienByBoPhan(string mabp)
        {
            string Query = "DELETE dbo.NhanVien WHERE MaBP = N'" + mabp + "'";
            DataProvider.Instance.ExecuteQuery(Query);
        }

    }
}
