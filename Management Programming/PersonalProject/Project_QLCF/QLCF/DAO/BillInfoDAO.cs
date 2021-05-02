using QLCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoDAO();
                    return instance;
            }
            private set => instance = value; 
        }
        private BillInfoDAO() { }

        public List<BillInfoDTO> GetListBillInfo(int id)
        {
            List<BillInfoDTO> bifList = new List<BillInfoDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillInfo WHERE idBill = "+id+"");

            foreach (DataRow item in data.Rows)
            {
                BillInfoDTO info = new BillInfoDTO(item);
                bifList.Add(info);
            }
            return bifList;
        }
    }
}
