using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QLCF.DAO
{
    public class DataProvider
    {
        private string ConnectionStr = @"Data Source=DESKTOP-J6DGHEU\SQLEXPRESS;Initial Catalog=QLCF;Integrated Security=True";
        
        public DataTable ExecuteQuery(string AccountQuery)
        {
            DataTable data = new DataTable(); 
            using (SqlConnection conn = new SqlConnection(ConnectionStr)) // Hàm using sau khi chạy đoạn code bên trong nó tự được giải phóng  
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(AccountQuery, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
               
                adapter.Fill(data);

                conn.Close();
            }
            return data;
        }
    }
}
