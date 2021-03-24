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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Exit ?", "Notifition", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK) Application.Exit();
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            
        }
        public double canh;
        public double TINHCHUVI()
        {
            double chuvi = this.canh * this.canh;
            return chuvi;
        }
        public double TINHDIENTICH()
        {
            double dientich = this.canh * 4;
            return dientich;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.txtArea.Text = TINHCHUVI().ToString();
            this.txtPerimeter.Text = TINHDIENTICH().ToString();

        }
    }
}
