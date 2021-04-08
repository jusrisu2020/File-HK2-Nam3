using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        frm_dmChucVu fCV;
        frm_dmNhanVien fNV;
        private void i_dmChucVu_Click(object sender, EventArgs e)
        {
            if (fCV == null || fNV.IsDisposed)
            {
                fCV = new frm_dmChucVu();
                fCV.MdiParent = this;
                fCV.Show();
            }
        }

        private void i_dmNhanVien_Click(object sender, EventArgs e)
        {
            if (fNV == null || fNV.IsDisposed)
            {
                fNV = new frm_dmNhanVien();
                fNV.MdiParent = this;
                fNV.Show();
            }
        }

    }
}
