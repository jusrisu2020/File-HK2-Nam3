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
        public List<TaiKhoanDTO> LoadTaiKhoan()
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
        public List<TaiKhoanDTO> ShowTenCVByTaiKhoan(string macv)
        {
            List<TaiKhoanDTO> TaiKhoanList = new List<TaiKhoanDTO>();

            string Query = string.Format("SELECT TenCV FROM dbo.ChucVu WHERE MaCV = '{0}'", macv);
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO(item);
                TaiKhoanList.Add(tk);
            }
            return TaiKhoanList;
        }

        public TaiKhoanDTO LayTKTuMaCV(string tentk)
        {
            string Query = string.Format("SELECT * FROM TaiKhoan WHERE tentk = '{0}'", tentk);
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach(DataRow item in data.Rows)
            {
                return new TaiKhoanDTO(item);
            }
            return null;
        }

        public bool Login(string TenTK, string Pass)
        {
            string TaiKhoanQuery = "EXEC USP_DangNhap  @TenTK , @Pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(TaiKhoanQuery, new object[] { TenTK, Pass });
            return result.Rows.Count > 0;
        }

        public bool ThemTaiKhoan(string manv, string tentk ,string pass ,string macv)
        {
            string TaiKhoanQuery = string.Format("EXEC dbo.USP_ThemTaiKhoan '{0}','{1}','{2}','{3}'", manv, tentk, pass, macv);
            int result = DataProvider.Instance.ExecuteNonQuery(TaiKhoanQuery);
            return result > 0;
        }

        public bool XoaTaiKhoan(string matk)
        {
            string TaiKhoanQuery = string.Format("DELETE dbo.TaiKhoan WHERE MaTK = '{0}'", matk);
            int result = DataProvider.Instance.ExecuteNonQuery(TaiKhoanQuery);
            return result > 0;
        }

        public bool SuaTaiKhoa(string manv, string tentk, string pass, int idtrangthai, string loaind)
        {
            string TaiKhoanQuery = string.Format("EXEC dbo.USP_ThemTaiKhoan {0},{1},{2},N'{3}',{4}", manv, tentk, pass, idtrangthai, loaind);
            int result = DataProvider.Instance.ExecuteNonQuery(TaiKhoanQuery);
            return result > 0;
        }

    }
}
