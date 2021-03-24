using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class FrmBai4_1 : Form
    {
        public FrmBai4_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0;
            int n ;
            int i = 1;
            n = int.Parse(txtn.Text);
            
            while(i<=n)
            {
                 s=s+i;
                   i++;
                
            }
            txts.Text =s.ToString();
        }

        private void txtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txts_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
