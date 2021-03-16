using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class BillInfoDAL
    {
        private static BillInfoDAL instance;

        public static BillInfoDAL Instance
        {
            get { if (instance == null) instance = new BillInfoDAL(); return BillInfoDAL.instance; }
            private set { BillInfoDAL.instance = value; }
        }
        public BillInfoDAL() { }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = Dataprovider.Instance.Excutequery("select * from BillInfo where idBill=" + id);
            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;        
        }
        public void InsertBillInfo (int idBill, int idRoom, int count)
        {
            Dataprovider.Instance.ExcuteNonquery("USP_InsertBillInfo @idBill , @idRoom , @count", new object[] {idBill, idRoom, count });
        }


        //TH1: lấy ra 1 bill mà nếu bill đó không tồn tại, tạo một bill mới dựa vào cái bàn sao đó insert billinfo vào.
        //TH2 bàn đó đã có bill rồi thì ta isert billinfo vào,với trường hợp billinfo chưa tồn tại
        //TH3 Nếu thức ăn đã tồn tại thì cập nhật lại cơ sở dữ liệu

    }
}
