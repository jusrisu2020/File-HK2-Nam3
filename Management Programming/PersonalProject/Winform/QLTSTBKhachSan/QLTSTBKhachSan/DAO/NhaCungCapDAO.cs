using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTSTBKhachSan.DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;
        public static NhaCungCapDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new NhaCungCapDAO();
                    return instance;
            }
            private set
            {
                instance = value;
            }
        }
    }
}
