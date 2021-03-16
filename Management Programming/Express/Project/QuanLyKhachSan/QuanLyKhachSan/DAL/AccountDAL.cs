using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class AccountDAL
    {
        private static AccountDAL instance;

        public static AccountDAL Instance 
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set { AccountDAL.instance = value; }
        }
        private AccountDAL() { }
        public bool Login (string UserName, string Password)

        {
            string query = "USP_Login @userName , @passWord";
            DataTable result = Dataprovider.Instance.Excutequery(query, new object[] { UserName, Password });
            return result.Rows.Count > 0;
        }
    }

}
