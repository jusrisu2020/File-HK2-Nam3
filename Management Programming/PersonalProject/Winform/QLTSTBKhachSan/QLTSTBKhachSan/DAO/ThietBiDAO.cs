using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class ThietBiDAO
    {
        private static ThietBiDAO instance;
        public static ThietBiDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new ThietBiDAO();
                    return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private ThietBiDAO() { }

        
    }
}
