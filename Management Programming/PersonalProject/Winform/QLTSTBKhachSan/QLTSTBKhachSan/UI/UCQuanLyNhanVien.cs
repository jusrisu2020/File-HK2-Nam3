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
    public partial class UCQuanLyNhanVien : UserControl
    {
        public UCQuanLyNhanVien()
        {
            InitializeComponent();
            LoadData();
        }
        
       void LoadData()
        {
            LoadNhanVien();
            LoadChucVu();
        }
        void LoadNhanVien()
        {
            List<NhanVienDTO> Table = NhanVienDAO.Instance.LoadNhanVien();
            dgvQLNV.DataSource = Table;
            dgvQLNV.Columns["id"].Visible = false;
            dgvQLNV.Columns["Manv"].HeaderText = "Mã Nhân Viên";
            dgvQLNV.Columns["Hoten"].HeaderText = "Họ tên";
            dgvQLNV.Columns["Gioitinh"].HeaderText = "Giới tính";
            dgvQLNV.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvQLNV.Columns["Diachi"].HeaderText = "Địa chỉ";
            dgvQLNV.Columns["sdt"].HeaderText = "SDT";
            dgvQLNV.Columns["Email"].HeaderText = "Email";
            dgvQLNV.Columns["TonGiao"].HeaderText = "Tôn giáo";
            dgvQLNV.Columns["CMND"].HeaderText = "CMND";
            dgvQLNV.Columns["Mabp"].HeaderText = "Mã bộ phận";
            dgvQLNV.Columns["Macv"].HeaderText = "Mã chức vụ";
        }

        void LoadChucVu()
        {
            List<ChucVuDTO> ChucVuList = ChucVuDAO.Instance.LoadChucVu();
            dtgvChucVu.DataSource = ChucVuList;
            dtgvChucVu.Columns["id"].Visible = false;
            dtgvChucVu.Columns["MaCV"].HeaderText = "Mã chức vụ";
            dtgvChucVu.Columns["TenCV"].HeaderText = "Tên chức vụ";
        }
        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            
        }
    }
}
