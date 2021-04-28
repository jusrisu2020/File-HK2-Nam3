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
            LoadNguoiDung();
            cbTrangThai.DataSource = TaiKhoanDAO.Instance.LoadTaiKhoan();
            cbTrangThai.DisplayMember = "TrangThai";
            cbLoaiND.DataSource = TaiKhoanDAO.Instance.LoadTaiKhoan();
            cbLoaiND.DisplayMember = "LoaiND";

        }
        #region Method
        void LoadNguoiDung()
        {
            List<TaiKhoanDTO> tk = TaiKhoanDAO.Instance.LoadTaiKhoan();
            dtgvQLND.DataSource = tk;
            dtgvQLND.Columns["id"].Visible = false;
            dtgvQLND.Columns["Pass"].Visible = false;
        }
            
        #endregion

        #region Event
        private void btnCapNhatND_Click(object sender, EventArgs e)
            {
                FThemSuaND TSND = new FThemSuaND();
                TSND.Show();
            }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string TimKiem = txtTimKiem.Text;
            if (txtTimKiem.Text == "")
            {
                LoadNguoiDung();
            }
            else
            {
                string SQuery = "SELECT * FROM TaiKhoan WHERE MaTK like '%" + TimKiem + "%' OR MaNV like '%" + TimKiem + "%' OR TenTK like '%" + TimKiem+"%'";
                dtgvQLND.DataSource = DataProvider.Instance.ExecuteQuery(SQuery);
                txtTimKiem.Clear();
                txtTimKiem.Focus();
            }
        }


        #endregion

        private void btnThemNv_Click(object sender, EventArgs e)
        {
            string Manv = txtManv.Text;
            string Tentk = txtTenTK.Text;
            string pass = txtPass.Text;
            string trangthai = cbTrangThai.Text;
            string loaind = cbLoaiND.Text;

            if (TaiKhoanDAO.Instance.ThemTaiKhoan(Manv, Tentk, pass, trangthai,loaind))
            {
                MessageBox.Show("Thành công");
                LoadNguoiDung();
            }
            else
            {
                MessageBox.Show("Không thành công");
            }

        }
    }

    
}
