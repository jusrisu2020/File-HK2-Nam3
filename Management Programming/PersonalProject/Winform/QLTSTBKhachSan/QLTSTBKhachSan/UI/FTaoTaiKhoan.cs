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
            LoadData();
        }

        void LoadData()
        {
            LoadCBMaNV();
            LoadCBChucVu();
        }
        void LoadCBMaNV()
        {
            List<NhanVienDTO> NhanVienList = NhanVienDAO.Instance.LoadNhanVien();
            cbMaNV.DataSource = NhanVienList;
            cbMaNV.DisplayMember = "MaNV";
        }

        void LoadCBChucVu()
        {
            pnShowChucVu.Visible = false;
            List<ChucVuDTO> ChucVuList = ChucVuDAO.Instance.LoadChucVu();
            cbMaCV.DataSource = ChucVuList;
            cbMaCV.DisplayMember = "MaCV";
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

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            string manv = cbMaNV.Text;
            string macv = cbMaCV.Text;
            string tentk = txtTenTK.Text;
            string pass = txtPass.Text;
            if (TaiKhoanDAO.Instance.InsertAccount(manv,tentk,pass, macv))
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("không Thành công");
            }
        }

       
    }
}
