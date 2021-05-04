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
    public partial class FLoading : Form
    {
        public FLoading()
        {
            InitializeComponent();
            PgbLoading.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PgbLoading.Value += 4;
            lbPercent.Text = "Loading... " + PgbLoading.Value.ToString() + "%";
            if (PgbLoading.Value == 100)
            {
                tmLoading.Enabled = false;
                FDangNhap dn = new FDangNhap();
                dn.Show();
                this.Hide();
            }
        }
    }
}
