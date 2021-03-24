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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Exit ?", "Notifition", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK) Application.Exit();
        }
        public double radius;
//DIEN TICH = r^2 * PI
        public double TINHDIENTICH()
        {
            double dientich = (radius*radius) * Math.PI;
            return dientich;
        }
//chu vi = 2r * PI
        public double TINHCHUVI()
        {
            double chuvi = (2*radius) * Math.PI;
            return chuvi;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            this.txtArea.Text = TINHDIENTICH().ToString();
            this.txtPerimeter.Text = TINHCHUVI().ToString();
        }
    }
}
