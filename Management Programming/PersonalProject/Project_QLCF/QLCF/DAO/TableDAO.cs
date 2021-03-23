using QLCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance 
        {
            get
            {
                if (instance == null) instance = new TableDAO();
                return instance;
            }
            private set => instance = value; 
        }
        private TableDAO() { }

        public static int TableWidth = 100;
        public static int TableHeight = 100;

        public List<TableDTO> LoadTableList()
        {
            List<TableDTO> tableList = new List<TableDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USPTableFood");
           
            foreach(DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }

    }
}
