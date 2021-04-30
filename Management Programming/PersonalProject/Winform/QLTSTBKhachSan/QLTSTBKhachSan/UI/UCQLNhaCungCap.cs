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

namespace QLTSTBKhachSan.UI
{
    public partial class UCQLNhaCungCap : UserControl
    {
        public UCQLNhaCungCap()
        {
            InitializeComponent();
            LoadNCCUC();
        }

        void LoadNCCUC()
        {
            dtgvNCC.DataSource = NhaCungCapDAO.Instance.LoadNCC();
        }
    }
}
