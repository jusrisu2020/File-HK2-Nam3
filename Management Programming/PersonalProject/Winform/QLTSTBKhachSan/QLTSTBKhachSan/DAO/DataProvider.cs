using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance 
        {
            get
            {
                if(instance == null)
                    instance = new DataProvider();
                    return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            } 
                
        }
        private DataProvider() { }

        private String strcon = @"Data Source=.\SQLEXPRESS;Initial Catalog=TSTBKhachSan;Integrated Security=True";

        public DataTable ExecuteQuery(string Squery, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(strcon))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(Squery, conn);

                conn.Close();
            }

                return data;
        }
    }
}
