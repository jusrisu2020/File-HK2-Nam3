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
        private static DataProvider instance; // PHÍM TẮT ĐÓNG GÓI Ctrl + R + E
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                    return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }
        private DataProvider() { }
        

        private string ConnectionStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLCF;Integrated Security=True";
        public DataTable ExecuteQuery(string SQuery,object[] parameter = null)
        {
            DataTable data = new DataTable(); 
            using (SqlConnection conn = new SqlConnection(ConnectionStr)) // Hàm using sau khi chạy đoạn code bên trong nó tự được giải phóng  
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(SQuery, conn);

                if(parameter != null)
                {
                    string[] listPara = SQuery.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
               
                adapter.Fill(data);

                conn.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string SQuery, object[] parameter = null)
        {

            int data = 0;
            using (SqlConnection conn = new SqlConnection(ConnectionStr)) // Hàm using sau khi chạy đoạn code bên trong nó tự được giải phóng  
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(SQuery, conn);

                if (parameter != null)
                {
                    string[] listPara = SQuery.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();

                conn.Close();
            }
            return data;
        }

        public object ExecuteScalar(string SQuery, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(ConnectionStr)) // Hàm using sau khi chạy đoạn code bên trong nó tự được giải phóng  
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(SQuery, conn);

                if (parameter != null)
                {
                    string[] listPara = SQuery.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();

                conn.Close();
            }
            return data;
        }

    }
}
