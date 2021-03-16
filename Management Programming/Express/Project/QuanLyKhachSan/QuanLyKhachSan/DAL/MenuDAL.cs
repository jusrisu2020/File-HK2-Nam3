using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace QuanLyKhachSan.DAL
{
    public class MenuDAL
    {
        private static MenuDAL instance;

        public static MenuDAL Instance
        {
            get { if (instance == null)instance = new MenuDAL(); return MenuDAL.instance; }
            private set { MenuDAL.instance = value; }
        }

        private MenuDAL() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            
            DataTable data =Dataprovider.Instance.Excutequery("select r.names, bi.count,r.price,r.price*bi.count as totalPrice from BillInfo as bi,Bill as b, Room as r where bi.idBill = b.id and bi.idRoom = r.id and b.status=0 and b.idTable =" + id);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }    

            return listMenu;
        }

    }
}
