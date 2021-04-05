using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTQL_BuoiTH04.UI
{
    public partial class FrmDSCV : Form
    {
        public FrmDSCV()
        {
            InitializeComponent();
        }

        private void FrmDSCV_Load(object sender, EventArgs e)
        {

            this.rpvDSCV.RefreshReport();
        }
    }
}
