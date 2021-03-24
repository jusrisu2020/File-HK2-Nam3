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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void MaxMang(int[] c)
        {
            int max = c[0];
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] > max)
                {
                    max = c[i];
                }
                lblKQ.Text = "Số lớn nhất: " + max.ToString();
            }          
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
