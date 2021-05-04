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

        void LoadData()
        {
            LoadNguoiDung();
            LoadCBChucVu();
            LoadCBTrangThai();
            AddBinding();
        }
        
        void LoadCBChucVu()
        {
            cbChucVu.DataSource = TaiKhoanDAO.Instance.LoadTaiKhoan(); 
            cbChucVu.DisplayMember = "MaCV";
        }
        void LoadCBTrangThai()
        {
            cbTrangThai.DataSource = TaiKhoanDAO.Instance.LoadTaiKhoan();
            cbTrangThai.ValueMember = "TenTT";
            cbTrangThai.DisplayMember = "TenTT";
        }
        void AddBinding()
        {
            txtMaTK.DataBindings.Add(new Binding("Text", dtgvQLND.DataSource, "MaTK", true, DataSourceUpdateMode.Never));
            txtManv.DataBindings.Add(new Binding("Text", dtgvQLND.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            txtTenTK.DataBindings.Add(new Binding("Text", dtgvQLND.DataSource, "TenTK", true, DataSourceUpdateMode.Never));
            txtPass.DataBindings.Add(new Binding("Text", dtgvQLND.DataSource, "Pass", true, DataSourceUpdateMode.Never));
            cbTrangThai.DataBindings.Add(new Binding("Text", dtgvQLND.DataSource, "TenTT", true, DataSourceUpdateMode.Never));
            cbChucVu.DataBindings.Add(new Binding("Text", dtgvQLND.DataSource, "MaCV", true, DataSourceUpdateMode.Never));
        }
        void EditColumns()
        {
            dtgvQLND.Columns["id"].Visible = false;
            dtgvQLND.Columns["Pass"].Visible = false;
            dtgvQLND.Columns["idTrangThai"].Visible = false;
            dtgvQLND.Columns["MaTK"].HeaderText = "Mã Tài Khoản";
            dtgvQLND.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dtgvQLND.Columns["TenTK"].HeaderText = "Tên Tài Khoản";
            dtgvQLND.Columns["TenTT"].HeaderText = "Trạng Thái";
            dtgvQLND.Columns["Macv"].HeaderText = "Chức Vụ";
        }

        #region Method
        void LoadNguoiDung()
        {
            List<TaiKhoanDTO> tk = TaiKhoanDAO.Instance.LoadTaiKhoan();
            dtgvQLND.DataSource = tk;
            EditColumns();
        }
        #endregion

        #region Event
        private void btnCapNhatND_Click(object sender, EventArgs e)
        {
              
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
            int idtrangthai = int.Parse(cbTrangThai.Text);
            string loaind = cbChucVu.Text;

            if (TaiKhoanDAO.Instance.ThemTaiKhoan(Manv, Tentk, pass, idtrangthai, loaind))
            {
                MessageBox.Show("Thành công");
                LoadNguoiDung();
            }
            else
            {
                MessageBox.Show("Không thành công");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }

    
}
