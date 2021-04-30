using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTSTBKhachSan
{
    public partial class FBoPhan : Form
    {
        public FBoPhan()
        {
            InitializeComponent();
        }
    private void btnThemBoPhan_Click(object sender, EventArgs e)
        {
            
           
        }

        private void FBoPhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tSTBKhachSanDataSet.BoPhan' table. You can move, or remove it, as needed.
            this.boPhanTableAdapter.Fill(this.tSTBKhachSanDataSet.BoPhan);

        }
    }
}
