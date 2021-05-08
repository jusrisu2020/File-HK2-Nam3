using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class BoPhanDAO
    {
        private static BoPhanDAO instance;
        public static BoPhanDAO Instance 
        { 
            get
            {
                if(instance == null)
                    instance = new BoPhanDAO();
                    return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<BoPhanDTO> LoadListBoPhan()
        {
            List<BoPhanDTO> BoPhanList = new List<BoPhanDTO>();
            string SBoPhan = "USP_SelectBoPhan";
            DataTable data = DataProvider.Instance.ExecuteQuery(SBoPhan);
            foreach (DataRow item in data.Rows)
            {
                BoPhanDTO table = new BoPhanDTO(item);
                BoPhanList.Add(table);
            }
            return BoPhanList;
        }

        public bool InsertBoPhan(string tenbp)
        {
            string Query = string.Format("EXEC dbo.USP_ThemBoPhan N'{0}'",tenbp);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }

        public bool UpdateBoPhan(string mabp,string tenbp)
        {
            string Query = string.Format("UPDATE dbo.BoPhan SET TenBP = N'{0}' WHERE MaBP = N'{1}'", tenbp, mabp);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }
        
        
        
        public bool DeleteBoPhan(string mabp)
        {
            NhanVienDAO.Instance.DeleteNhanVienByBoPhan(mabp);
            string Query = string.Format("DELETE dbo.BoPhan WHERE MaBP = N'{0}'", mabp);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }
        

        public List<BoPhanDTO> SearchBoPhan(string name)
        {
            List<BoPhanDTO> BoPhanList = new List<BoPhanDTO>();
            
            string SBoPhan = string.Format("EXEC USP_TKTenBoPhan N'{0}'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(SBoPhan);
            foreach (DataRow item in data.Rows)
            {
                BoPhanDTO table = new BoPhanDTO(item);
                BoPhanList.Add(table);
            }
            return BoPhanList;
        }
    }
}
