using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void SumMang(int[] b)
        {
            int sum = 0;
            for (int i = 0; i < b.Length; i++)
            {
                sum = sum + b[i];
            }
            label1.Text = "Tổng mảng: " + sum.ToString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
