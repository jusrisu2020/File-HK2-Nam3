using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            LoadTable();
        }

        #region Method
        void LoadTable()
        {

        }
        #endregion
        #region Event
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAdmin fa = new FAdmin();
            this.Hide();
            fa.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDangNhap fdn = new FDangNhap();
            this.Hide();
            fdn.ShowDialog();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FUserInfo fa = new FUserInfo();
            this.Hide();
            fa.ShowDialog();
        }
        #endregion
    }
}
