using QLTSTBKhachSan.DAO;
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
        }

        private void UCQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            string SQuery = "SELECT * FROM dbo.TaiKhoan";
            dtgvQLND.DataSource = DataProvider.Instance.ExecuteQuery(SQuery);
            dtgvQLND.Columns["id"].Visible = false;
        }

        private void btnCapNhatND_Click(object sender, EventArgs e)
        {
            FThemSuaND TSND = new FThemSuaND();
            TSND.Show();
        }
    }

    internal class dtgvQLND
    {
        
    }
}
