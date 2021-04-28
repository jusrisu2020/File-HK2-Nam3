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

        public bool Login(string TenTK, string Pass)
        {
            string TaiKhoanQuery = "EXEC USP_DangNhap  @TenTK , @Pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(TaiKhoanQuery, new object[] { TenTK, Pass });
            return result.Rows.Count > 0;
        }

        public List<TaiKhoanDTO> LoadTaiKhoan()
        {
            List<TaiKhoanDTO> TaiKhoanList = new List<TaiKhoanDTO>();
            string SATaiKhoan = "EXEC USP_SelectATaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(SATaiKhoan);

            foreach(DataRow item in data.Rows)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO(item);
                TaiKhoanList.Add(tk);
            }
            return TaiKhoanList;
        }

        public bool ThemTaiKhoan(string manv, string tentk, string pass, string trangthai, string loaind)
        {
            string TaiKhoanQuery = string.Format("EXEC dbo.USP_ThemTaiKhoan {0},{1},{2},N'{3}',{4}", manv,tentk,pass,trangthai,loaind);
            int result = DataProvider.Instance.ExecuteNonQuery(TaiKhoanQuery);
            return result > 0;
        }

    }
}
