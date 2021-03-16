using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class TableDAL
    {
        private static TableDAL instance;

        public static TableDAL Instance {

            get { if (instance == null) instance = new TableDAL(); return TableDAL.instance; }
            private set { TableDAL.instance = value;  }
                    
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;
        private TableDAL() { }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            // lấy cái table lên
            DataTable data = Dataprovider.Instance.Excutequery("USP_GetTableList");
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
                
            }
            return tableList;
        }
        
    }

        
    
}
