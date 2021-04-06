using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class NhanVien_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả nhân viên
        public static List<NhanVien_DTO>  LayDSNhanVien() {
            string sTruyVan = "select * from nhanvien";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<DTO.NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv=new NhanVien_DTO();
                nv.SMaNV  = dt.Rows[i]["manv"].ToString();
                nv.SHoLot  = dt.Rows[i]["holot"].ToString();
                nv.STen = dt.Rows[i]["tennv"].ToString();
                nv.SPhai = dt.Rows[i]["phai"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SMaCV = dt.Rows[i]["macv"].ToString();
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }

      }
}
