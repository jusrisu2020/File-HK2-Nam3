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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void gnBtnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit?","Notification",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void gnBtnDangNhap_Click(object sender, EventArgs e)
        {
            FTrangChu fTrangChu = new FTrangChu();
            this.Hide();
            fTrangChu.Show();
        }
    }
}
