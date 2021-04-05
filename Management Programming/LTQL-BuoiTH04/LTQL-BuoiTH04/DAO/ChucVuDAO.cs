using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LTQL_BuoiTH04.DTO;
using System.Data;

namespace LTQL_BuoiTH04.DAO
{
    public class ChucVuDAO
    {
        static SqlConnection con;
        public static List<ChucVuDTO> LayChucVu()
        {
            string squery = "SELECT * FROM CHUCVU";
            con = DataProvider.OpenCon();
            DataTable dt = DataProvider.Data(squery,con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }

            List<ChucVuDTO> lstChucVu = new List<ChucVuDTO>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVuDTO cv = new ChucVuDTO();
                cv.SManv = dt.Rows[i]["macv"].ToString();
                cv.STencv = dt.Rows[i]["tencv"].ToString();
                cv.FHSPC = float.Parse(dt.Rows[i]["tencv"].ToString());
                lstChucVu.Add(cv);
            }
            return lstChucVu;
        }
    }
}
