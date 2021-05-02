using QLCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                    return instance;
            }
               
            private set => instance = value; 
        }
        private BillDAO() { }

        public int GetUncheckBillIdByTableId(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE idTable = " + id + " AND status = 0");
            if(data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.ID;
            }
            return -1; 
        }
    }
}
