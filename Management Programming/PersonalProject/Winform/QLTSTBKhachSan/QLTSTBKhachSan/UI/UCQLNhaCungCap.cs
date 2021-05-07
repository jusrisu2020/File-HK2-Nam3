using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTSTBKhachSan.DAO;
using QLTSTBKhachSan.DTO;

namespace QLTSTBKhachSan.UI
{
    public partial class UCQLNhaCungCap : UserControl
    {
        public UCQLNhaCungCap()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            EditColumns();
            LoadNCCUC();
        }
        void LoadNCCUC()
        {
            List<NhaCungCapDTO> NhaCungCapList = NhaCungCapDAO.Instance.LoadNCC();
            dtgvNCC.DataSource = NhaCungCapList;
        }

        void EditColumns()
        {
            dtgvNCC.Columns["ID"].Visible = false;
            dtgvNCC.Columns[1].HeaderText = "Mã Nhà Cung Cấp";
            dtgvNCC.Columns[2].HeaderText = "Tên Nhà Cung Cấp";
        }
    }
}
