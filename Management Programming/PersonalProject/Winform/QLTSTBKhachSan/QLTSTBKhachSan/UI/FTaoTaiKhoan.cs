using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLTSTBKhachSan.DTO;
using QLTSTBKhachSan.DAO;

namespace QLTSTBKhachSan
{
    public partial class FTaoTaiKhoan : Form
    {
        public FTaoTaiKhoan()
        {
            InitializeComponent();
            LoadMaNV();
            LoadChucVu();
        }

        void LoadMaNV()
        {
            List<NhanVienDTO> NhanVienList = NhanVienDAO.Instance.LoadNhanVien();
            cbMaNV.DataSource = NhanVienList;
            cbMaNV.DisplayMember = "MaNV";
        }

        void LoadChucVu()
        {
            pnShowChucVu.Visible = false;
            List<ChucVuDTO> ChucVuList = ChucVuDAO.Instance.LoadChucVu();
            cbChucVu.DataSource = ChucVuList;
            cbChucVu.DisplayMember = "MaCV";
            dtgvChucVu.DataSource = ChucVuList;
            dtgvChucVu.Columns[0].Visible = false;
            dtgvChucVu.Columns[1].HeaderText = "Mã chức vụ";
            dtgvChucVu.Columns[2].HeaderText = "Tên chức vụ";
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
    }
}
