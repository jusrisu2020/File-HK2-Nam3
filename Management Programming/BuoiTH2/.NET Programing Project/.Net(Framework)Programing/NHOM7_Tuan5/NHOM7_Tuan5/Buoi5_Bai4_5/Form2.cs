using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai4_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.n = int.Parse(txtNhapN.Text);
            f1.ShowDialog();
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
