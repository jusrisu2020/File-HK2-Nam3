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
    public partial class UCQuanLiBoPhan : UserControl
    {
        public UCQuanLiBoPhan()
        {
            InitializeComponent();
        }

        private void UCQuanLiBoPhan_Load(object sender, EventArgs e)
        {
            string SQuery = "SELECT * FROM dbo.BoPhan";
            dtgvQLBP.DataSource = DataProvider.Instance.ExecuteQuery(SQuery);
            dtgvQLBP.Columns["id"].Visible = false;
        }
    }
}
