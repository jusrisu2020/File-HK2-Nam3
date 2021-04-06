using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string sMaNV;

        public string SMaNV
        {
            get { return sMaNV; }
            set { sMaNV = value; }
        }

        private string sHoLot;

        public string SHoLot
        {
            get { return sHoLot; }
            set { sHoLot = value; }
        }

        private string sTen;

        public string STen
        {
            get { return sTen; }
            set { sTen = value; }
        }

        private string sPhai;

        public string SPhai
        {
            get { return sPhai; }
            set { sPhai = value; }
        }

        private DateTime dtNgaySinh;

        public DateTime DtNgaySinh
        {
            get { return dtNgaySinh; }
            set { dtNgaySinh = value; }
        }

        private string sMaCV;

        public string SMaCV
        {
            get { return sMaCV; }
            set { sMaCV = value; }
        }
    }
}
