using LTQL_BuoiTH04.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTQL_BuoiTH04
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void tmtNhanVien_Click(object sender, EventArgs e)
        {
            FrmDSCV dscv = new FrmDSCV();
            dscv.Show();
            this.Hide();
        }
    }
}
