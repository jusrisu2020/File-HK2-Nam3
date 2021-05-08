using QLTSTBKhachSan.DAO;
using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTSTBKhachSan.UI
{
    public partial class UCQuanLyNguoiDung : UserControl
    {
        public UCQuanLyNguoiDung()
        {
            InitializeComponent();
            LoadData();
        }



        #region Method
        void LoadData()
        {
            LoadListAccount();
            AddBinding();
            LoadCBChucVu();
            pnShowChucVu.Visible = false;
        }

        void LoadListAccount()
        {
            List<TaiKhoanDTO> tk = TaiKhoanDAO.Instance.LoadListAccount();
            dtgvQLND.DataSource = tk;
            dtgvQLND.Columns["id"].Visible = false;
            dtgvQLND.Columns["Pass"].Visible = false;
            dtgvQLND.Columns["MaTK"].HeaderText = "Mã Tài Khoản";
            dtgvQLND.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dtgvQLND.Columns["TenTK"].HeaderText = "Tên Tài Khoản";
            dtgvQLND.Columns["Macv"].HeaderText = "Chức Vụ";
        }

        void LoadCBChucVu()
        {
            List<ChucVuDTO> ChucVuList = ChucVuDAO.Instance.LoadChucVu();
            cbMaCV.DataSource = ChucVuList;
            cbMaCV.DisplayMember = "TenCV";
            dtgvChucVu.DataSource = ChucVuList;
            dtgvChucVu.Columns[0].Visible = false;
        }

        void AddBinding()
        {
            txtManv.DataBindings.Add(new Binding("Text", dtgvQLND.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            txtTenTK.DataBindings.Add(new Binding("Text", dtgvQLND.DataSource, "TenTK", true, DataSourceUpdateMode.Never));
            txtPass.DataBindings.Add(new Binding("Text", dtgvQLND.DataSource, "Pass", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Event
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            FTaoTaiKhoan ttk = new FTaoTaiKhoan();
            ttk.Show();
        }
        private void btnShowChucVu_Click(object sender, EventArgs e)
        {
            if (pnShowChucVu.Visible == true)
            {
                pnShowChucVu.Visible = false;
            }
            else
            {
                pnShowChucVu.Visible = true;
            }
        }

        /*private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string TimKiem = txtTimKiem.Text;
            if (txtTimKiem.Text == "")
            {
                LoadListAccount();
            }
            else
            {
                string SQuery = "SELECT * FROM TaiKhoan WHERE MaTK like '%" + TimKiem + "%' OR MaNV like '%" + TimKiem + "%' OR TenTK like '%" + TimKiem+"%'";
                dtgvQLND.DataSource = DataProvider.Instance.ExecuteQuery(SQuery);
                txtTimKiem.Clear();
                txtTimKiem.Focus();
            }
        }*/
        #endregion
    }
}
