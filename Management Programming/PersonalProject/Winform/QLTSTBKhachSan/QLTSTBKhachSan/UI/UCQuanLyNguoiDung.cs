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
            pnShowChucVu.Visible = false;
        }

        void LoadData()
        {
            LoadNguoiDung();
            AddBinding();
            LoadCBChucVu();
        }

        
        void LoadCBChucVu()
        {
            List<ChucVuDTO> ChucVuList = ChucVuDAO.Instance.LoadChucVu();
            cbMaCV.DataSource = ChucVuList;
            cbMaCV.DisplayMember = "TenCV";

            dtgvChucVu.DataSource = ChucVuList;
            dtgvChucVu.Columns[0].Visible = false;
        }
       
        List<ChucVuDTO> ChucVuList = ChucVuDAO.Instance.LoadChucVu();
        void AddBinding()
        {
            txtManv.DataBindings.Add(new Binding("Text", dtgvQLND.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            txtTenTK.DataBindings.Add(new Binding("Text", dtgvQLND.DataSource, "TenTK", true, DataSourceUpdateMode.Never));
            txtPass.DataBindings.Add(new Binding("Text", dtgvQLND.DataSource, "Pass", true, DataSourceUpdateMode.Never));
        }
        void EditColumns()
        {
            dtgvQLND.Columns["id"].Visible = false;
            dtgvQLND.Columns["Pass"].Visible = false;
            dtgvQLND.Columns["MaTK"].HeaderText = "Mã Tài Khoản";
            dtgvQLND.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dtgvQLND.Columns["TenTK"].HeaderText = "Tên Tài Khoản";
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
            string macv = cbMaCV.Text;

            if (TaiKhoanDAO.Instance.ThemTaiKhoan(Manv, Tentk, pass, macv))
            {
                MessageBox.Show("Thành công");
                LoadNguoiDung();
            }
            else
            {
                MessageBox.Show("Không thành công");
            }

        }

       
        private void btnShowChucVu_Click(object sender, EventArgs e)
        {
            if(pnShowChucVu.Visible == true)
            {
                pnShowChucVu.Visible = false;
            }
            else
            {
                pnShowChucVu.Visible = true;
            }
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            FTaoTaiKhoan ttk = new FTaoTaiKhoan();
            ttk.Show();
        }
    }

    
}
