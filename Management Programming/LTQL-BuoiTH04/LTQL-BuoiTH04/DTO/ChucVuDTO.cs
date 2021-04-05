using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTQL_BuoiTH04.DTO
{
    public class ChucVuDTO
    {
        private string sManv;
        public string SManv 
        { 
            get => sManv; 
            set => sManv = value;
        }

        private string sTencv;
        public string STencv 
        { 
            get => sTencv; 
            set => sTencv = value; 
        }

        private float fHSPC;
        public float FHSPC 
        { 
            get => fHSPC; 
            set => fHSPC = value; 
        }
    }
}
