using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class BillDAL
    {
        private static BillDAL instance;
        public static BillDAL Instance
        {
            get { if (instance == null) instance = new BillDAL(); return BillDAL.instance; }
            private set { BillDAL.instance = value; }
        }
        private BillDAL() { }
        //thành công bill ID
        //thất bại: -1
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data =Dataprovider.Instance.Excutequery("select * from Bill where idTable=" + id +" and status = 0");
            if(data.Rows.Count>0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void CheckOut(int id)
        {
            string query = "update dbo.Bill set status = 1 where id = " + id;
            Dataprovider.Instance.ExcuteNonquery(query);// khi check out thi phong se chuyen sang trong
        }
        public  void InsertBill (int id)
        {
            Dataprovider.Instance.ExcuteNonquery("EXEC USP_InsertBill @idTable", new object[]{ id });
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)Dataprovider.Instance.ExcuteScalar("select MAX(id) from Bill");
            }
            catch
            {
                return 1;
            }
        }
    }
}
