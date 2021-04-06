using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVien_BUS
    {
        //Lấy DS nhân viên
        public static List<NhanVien_DTO> LayDSNhanVien() {
            return NhanVien_DAO.LayDSNhanVien();
        }

       
    }    
}
