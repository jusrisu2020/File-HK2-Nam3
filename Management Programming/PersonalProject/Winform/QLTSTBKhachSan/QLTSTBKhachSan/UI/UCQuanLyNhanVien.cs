﻿using QLTSTBKhachSan.DAO;
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
            LoadNhanVien();
            LoadChucVu();
        }
        FThemSuaNV fnv = new FThemSuaNV();
       
        void LoadNhanVien()
        {
            List<NhanVienDTO> Table = NhanVienDAO.Instance.LoadNhanVien();
            dgvQLNV.DataSource = Table;
            dgvQLNV.Columns["id"].Visible = false;
        }
        

        void LoadChucVu()
        {
            List<ChucVuDTO> ChucVuList = ChucVuDAO.Instance.LoadChucVu();
            dtgvChucVu.DataSource = ChucVuList;
            dtgvChucVu.Columns["id"].Visible = false;
        }
        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            fnv.Show();
        }
    }
}
