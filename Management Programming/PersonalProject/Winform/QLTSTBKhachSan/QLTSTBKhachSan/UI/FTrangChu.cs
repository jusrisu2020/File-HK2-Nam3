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
    public partial class FTrangChu : Form
    {
        public FTrangChu()
        {
            InitializeComponent();
        }


        private void pbLogo_Click(object sender, EventArgs e)
        {
            ucTrangChu.Show();
            ucTrangChu.BringToFront();
            ucQLND.Hide();
            ucQLNV.Hide();
        }

        private void gnBtnQLND_Click(object sender, EventArgs e)
        {
            ucQLND.Show();
            ucQLND.BringToFront();
            ucQLNV.Hide();
        }

        private void gnBtnQLNV_Click(object sender, EventArgs e)
        {
            ucQLNV.Show();
            ucQLNV.BringToFront();
            ucQLND.Hide();
        }
        private void FTrangChu_Load(object sender, EventArgs e)
        {
            ucTrangChu.Show();
        }
    }
}
