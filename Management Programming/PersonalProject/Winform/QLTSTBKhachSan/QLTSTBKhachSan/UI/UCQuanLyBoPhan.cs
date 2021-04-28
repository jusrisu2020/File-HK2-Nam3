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
    public partial class UCQuanLiBoPhan : UserControl
    {
        public UCQuanLiBoPhan()
        {
            InitializeComponent();
            LoadBoPhan();
        }
        void LoadBoPhan()
        {
            List<BoPhanDTO> BoPhanList = BoPhanDAO.Instance.LoadBoPhan();
            dtgvQLBP.DataSource = BoPhanList;
            dtgvQLBP.Columns["id"].Visible = false;
        }

        private void btnThemBoPhan_Click(object sender, EventArgs e)
        {
            FBoPhan fbp = new FBoPhan();
            fbp.Show();
        }

        private void btnThemBP_Click(object sender, EventArgs e)
        {
            string tenbp = txtThemBoPhan.Text;

            if (BoPhanDAO.Instance.ThemBoPhan(tenbp))
            {
                MessageBox.Show("Saved!");
                LoadBoPhan();
                txtThemBoPhan.Clear();
                txtThemBoPhan.Focus();
            }
            else
            {
                MessageBox.Show("Không thành công");
            }
        }
    }
}
