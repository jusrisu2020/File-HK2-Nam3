using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LTQL_BuoiTH04.DAO
{
    class DataProvider
    {
        public static SqlConnection OpenCon()
        {
            string strcon = @"Data Source=DESKTOP-VG1T5FL\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            return con;
        }

        public static DataTable Data(string squery, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
;       }

        public static bool Test(string squery, SqlConnection con)
        {
            try
            {
                SqlCommand cm = new SqlCommand(squery, con);
                cm.ExecuteNonQuery();
                return false;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
