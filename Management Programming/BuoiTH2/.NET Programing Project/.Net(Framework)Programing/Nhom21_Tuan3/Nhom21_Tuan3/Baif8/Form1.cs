using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baif8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chào" + " " + cbHoTen.Text + "." + "Chúc một ngày vui vẻ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbHoTen.Items.Add("Nguyễn Minh Toàn");
            cbHoTen.Items.Add("Trần Minh Trí");
            cbHoTen.Items.Add("Nguyễn Quang Linh");
        }
    }
}
