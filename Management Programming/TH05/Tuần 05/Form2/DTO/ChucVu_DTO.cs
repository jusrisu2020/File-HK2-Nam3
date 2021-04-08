using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVu_DTO
    {
        private string sMaCV;

        public string SMaCV
        {
            get { return sMaCV; }
            set { sMaCV = value; }
        }

        private string sTenCV;

        public string STenCV
        {
            get { return sTenCV; }
            set { sTenCV = value; }
        }

        private float fHSPhuCap;

        public float FHSPhuCap
        {
            get { return fHSPhuCap; }
            set { fHSPhuCap = value; }
        }

        
    }
}
