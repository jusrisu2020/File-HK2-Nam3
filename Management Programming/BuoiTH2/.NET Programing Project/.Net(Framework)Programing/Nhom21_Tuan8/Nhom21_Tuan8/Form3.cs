using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom21_Tuan8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Exit ?", "Notifition", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK) Application.Exit();
        }
        public double dai,rong;
// dien tich hcn = dai * rong 
        public double TINHDIENTICH()
        {
            double dientich = dai * rong;
            return dientich;
        }
//chu vi = 2*(dai+rong)
        public double TINHCHUVI()
        {
            double chuvi = 2 * (dai + rong);
            return chuvi;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.txtArea.Text = TINHDIENTICH().ToString();
            this.txtPerimeter.Text = TINHCHUVI().ToString();
        }
    }
}
