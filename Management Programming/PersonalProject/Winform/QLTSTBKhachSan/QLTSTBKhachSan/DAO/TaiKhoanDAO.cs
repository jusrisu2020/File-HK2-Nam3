using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance 
        {
            get
            {
                if(instance == null)
                    instance = new TaiKhoanDAO();
                    return TaiKhoanDAO.instance;
            }
            private set
            {
                TaiKhoanDAO.instance = value;
            }
        }
        private TaiKhoanDAO() { }
        public List<TaiKhoanDTO> LoadListAccount()
        {
            List<TaiKhoanDTO> TaiKhoanList = new List<TaiKhoanDTO>();
            string SATaiKhoan = "EXEC USP_SelectATaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(SATaiKhoan);

            foreach (DataRow item in data.Rows)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO(item);
                TaiKhoanList.Add(tk);
            }
            return TaiKhoanList;
        }

        public bool Login(string TenTK, string Pass)
        {
            string TaiKhoanQuery = "EXEC USP_DangNhap  @TenTK , @Pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(TaiKhoanQuery, new object[] { TenTK, Pass });
            return result.Rows.Count > 0;
        }

        public bool InsertAccount(string manv, string tentk ,string pass ,string macv)
        {
            string TaiKhoanQuery = string.Format("EXEC dbo.USP_ThemTaiKhoan '{0}','{1}','{2}','{3}'", manv, tentk, pass, macv);
            int result = DataProvider.Instance.ExecuteNonQuery(TaiKhoanQuery);
            return result > 0;
        }
        //Thay đổi thông tin tài khoản từ các người dùng
        public bool UpdateAccountByUser(string tentk, string tenhienthi, string pass, string newPass)
        {
            string Query = string.Format("EXEC USP_UpdateTaiKhoan '{0}','{1}',{2},{3}", tentk, tenhienthi, pass, newPass);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }

        /*public bool UpdateAccountByAdmin(string tentk, string tenhienthi, string pass, string newPass)
        {
            string Query = string.Format("EXEC USP_UpdateTaiKhoan '{0}','{1}',{2},{3}", tentk, tenhienthi, pass, newPass);
            int result = DataProvider.Instance.ExecuteNonQuery(Query);
            return result > 0;
        }*/

        public bool DeleteAccount(string matk)
        {
            string TaiKhoanQuery = string.Format("DELETE dbo.TaiKhoan WHERE MaTK = '{0}'", matk);
            int result = DataProvider.Instance.ExecuteNonQuery(TaiKhoanQuery);
            return result > 0;
        }
        //Phân quyền và Hiển thị tên người dùng
        public TaiKhoanDTO GetAccountByUserName(string tentk)
        {
            string Query = "SELECT * FROM dbo.TaiKhoan WHERE TenTK = '" + tentk + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);

            foreach(DataRow item in data.Rows)
            {
                return new TaiKhoanDTO(item);
            }
            return null;
        }
    }
}
