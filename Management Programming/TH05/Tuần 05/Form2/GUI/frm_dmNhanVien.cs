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
using DTO;
using BUS;

namespace GUI
{
    public partial class frm_dmNhanVien : Form
    {
        public frm_dmNhanVien()
        {
            InitializeComponent();
        }

        private void frm_dmNhanVien_Load(object sender, EventArgs e)
        {
            // Combobox chức vụ
            HienThiChucVuLenCombobox();

            // Datagrid nhân viên
            HienThiDSNhanVienLenDatagrid();
        }

        private void HienThiChucVuLenCombobox() {
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            cboChucVu.DataSource = lstChucVu;
            cboChucVu.DisplayMember = "STenCV";
            cboChucVu.ValueMember = "SMaCV";
        }

        private void HienThiDSNhanVienLenDatagrid() {
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayDSNhanVien();
            dgDSNhanVien.DataSource = lstNhanVien;
            dgDSNhanVien.Columns["SMaNV"].HeaderText = "Mã số";
            dgDSNhanVien.Columns["SHoLot"].HeaderText = "Họ và lót";
            dgDSNhanVien.Columns["STen"].HeaderText = "Tên";
            dgDSNhanVien.Columns["SPhai"].HeaderText = "Phái";
            dgDSNhanVien.Columns["DtNgaySinh"].HeaderText = "Ngày sinh";
            dgDSNhanVien.Columns["SMaCV"].HeaderText = "Chức vụ";
            dgDSNhanVien.Columns["SMaNV"].Width = 60;
            dgDSNhanVien.Columns["SHoLot"].Width = 120;
            dgDSNhanVien.Columns["STen"].Width = 50;
            dgDSNhanVien.Columns["SPhai"].Width = 50;
            dgDSNhanVien.Columns["DtNgaySinh"].Width = 80;
            
        }

        
        private void dgDSNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgDSNhanVien.SelectedRows[0];
            txtMaNV.Text = r.Cells["SMaNV"].Value.ToString();
            txtHoLot.Text = r.Cells["SHoLot"].Value.ToString();
            txtTen.Text = r.Cells["STen"].Value.ToString();
            if (r.Cells["SPhai"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else {
                radNu.Checked = true;
            }
            dtpNgaySinh.Text = r.Cells["DtNgaySinh"].Value.ToString();
            cboChucVu.SelectedValue = r.Cells["SMaCV"].Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaNV.Text == "" || txtHoLot.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMaNV.Text.Length > 5)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (NhanVien_BUS.TimNhanVienTheoMa(txtMaNV.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.SHoLot = txtHoLot.Text;
            nv.STen = txtTen.Text;
            if (radNam.Checked == true)
            {
                nv.SPhai = "Nam";
            }
            else
            {
          nv.SPhai = "Nữ";
            }
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            nv.SMaCV = cboChucVu.SelectedValue.ToString();
            if (NhanVien_BUS.ThemNhanVien(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm nhân viên.");
        }

    }
}

