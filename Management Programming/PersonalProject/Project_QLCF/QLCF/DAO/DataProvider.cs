﻿using System;
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
        private static DataProvider instance;
        private string ConnectionStr = @"Data Source=DESKTOP-J6DGHEU\SQLEXPRESS;Initial Catalog=QLCF;Integrated Security=True";

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
                instance = value;
            }
        }

        public DataTable ExecuteQuery(string AccountQuery,object[] parameter = null)
        {
            DataTable data = new DataTable(); 
            using (SqlConnection conn = new SqlConnection(ConnectionStr)) // Hàm using sau khi chạy đoạn code bên trong nó tự được giải phóng  
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(AccountQuery, conn);

                if(parameter != null)
                {
                    string[] listPara = AccountQuery.Split(' ');
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

        public int ExecuteNonQuery(string AccountQuery, object[] parameter = null)
        {

            int data = 0;
            using (SqlConnection conn = new SqlConnection(ConnectionStr)) // Hàm using sau khi chạy đoạn code bên trong nó tự được giải phóng  
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(AccountQuery, conn);

                if (parameter != null)
                {
                    string[] listPara = AccountQuery.Split(' ');
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

        public object ExecuteScalar(string AccountQuery, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(ConnectionStr)) // Hàm using sau khi chạy đoạn code bên trong nó tự được giải phóng  
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(AccountQuery, conn);

                if (parameter != null)
                {
                    string[] listPara = AccountQuery.Split(' ');
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
