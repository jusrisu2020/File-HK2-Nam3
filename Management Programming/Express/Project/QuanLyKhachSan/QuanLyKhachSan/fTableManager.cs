using QuanLyKhachSan.DAL;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fTableManager : Form
    {
       

        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }


        #region Method

        void LoadCategory()
        {
            //load catergory lên 
            List<Category> listCategory = CategoryDAL.Instance.GetListCategory();
            cboCategory.DataSource = listCategory;// load dữ liệu lên combo box;
            cboCategory.DisplayMember = "Name";
        }

        void LoadRoomListByCategoryID(int id)
        {
            List<Room> listRoom = RoomDAL.Instance.GetRoomByCategiryID(id);
            cboRoom.DataSource = listRoom;
            cboRoom.DisplayMember = "Name";
        }

        void LoadTable()        
        {
            List<Table> tableList = TableDAL.Instance.LoadTableList();//lấy ra table list
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAL.TableWidth, Height = TableDAL.TableHeight };

                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLyKhachSan.DTO.Menu> listBillInfo = MenuDAL.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (QuanLyKhachSan.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.ServiceName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;// cộng tất cả tiền trong cột thành tiền lại và lưu  tổng tiền trong textbox

                lsvBill.Items.Add(lsvItem);

                
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;

            txtTotalPrice.Text = totalPrice.ToString("c",culture);
        }
        #endregion

        //#region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;//lưu vào table
            ShowBill(tableID); // showbill dựa  vào tableID mà tableID dựa vào sender
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void nmDisCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;// nếu khoong6 có data source thì nó không chạy nữa 
            Category selected = cb.SelectedItem as Category; // selected là category '
            id = selected.ID;

            LoadRoomListByCategoryID(id);
            

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            // như vậy làm sao biết bàn nào đang được chọn , chúng ta có thể sử dụng tag của thằng listview
            // mõi khi click vào cái litsview sẽ có cái thêm DAL them billinfo

            Table table = lsvBill.Tag as Table; // chúng ta lấy ra cái table hiện tại

            int idBill = BillDAL.Instance.GetUncheckBillIDByTableID(table.ID);// lấy ra cái idBill hiện tại
                                                                              // chúng ta kiểm tra xem coi có bill không
            int roomID = (cboRoom.SelectedItem as Room).ID;
            int count = (int)nmRoomCount.Value;
             if(idBill == -1){
                BillDAL.Instance.InsertBill(table.ID); // them bill moi 
                BillInfoDAL.Instance.InsertBillInfo(BillDAL.Instance.GetMaxIDBill() ,roomID,count); // them billinfo. nhung neu minh them cac gia tri cho billinfo vao aln luot la 1,1,1 thi dau biet
                // them cho bill nao dau
                // nhưng có một lưu ý là cái bill mà mình mới thêm vào thì nó có idbill là lớn nhất so với các phân tử trong bill
                // nên ta tạo thêm một cái hàm ten la GetMax
            }
            else
            {
                // nguoc lai bill da ton tai
                BillInfoDAL.Instance.InsertBillInfo(idBill, roomID, count);//bill da ton tai
                ShowBill(table.ID);//load menu lên
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // giả sử th1 không có bill th2 bill đã thanh toán rồi , ta sẽ không làm gì hết
            // 1 ta phải lấy đc table hiện tại
            Table table = lsvBill.Tag as Table;
            // lấy id bill ra
            int idBill = BillDAL.Instance.GetUncheckBillIDByTableID(table.ID);
            // ktra idbill

            if(idBill != -1)
            {
                if (MessageBox.Show("Bạn có chắc muốn thanh toán hóa đơn cho bàn " + table.Name, "Thông Báo",MessageBoxButtons.OKCancel) 
                    == DialogResult.OK );
                {
                    BillDAL.Instance.CheckOut(idBill);
                    ShowBill(table.ID);
                }
            }
        }
    }
}