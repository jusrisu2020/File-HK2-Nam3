using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baif7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        

      

       
        private void tínhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tổngToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            int tong;
            tong = int.Parse(txta.Text) + int.Parse(txtb.Text);
            txtkq.Text = "Tổng là: " + tong.ToString();
        }

        private void hiệuToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            int hieu;
            hieu = int.Parse(txta.Text) - int.Parse(txtb.Text);
            txtkq.Text = "Hiệu là: " + hieu.ToString();
        }

        private void tíchToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            int tich;
            tich = int.Parse(txta.Text) * int.Parse(txtb.Text);
            txtkq.Text = "Tích là: " + tich.ToString();
        }

        private void thươngToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            int thuong;
            thuong = int.Parse(txta.Text) / int.Parse(txtb.Text);
            txtkq.Text = "Thương là: " + thuong.ToString();
        }
    }
}
