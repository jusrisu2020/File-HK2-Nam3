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

        public List<BoPhanDTO> LoadBoPhan()
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

        public bool ThemBoPhan(string tenbp)
        {
            string Query = string.Format("EXEC dbo.USP_ThemBoPhan N'{0}'",tenbp);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }
    }
}
