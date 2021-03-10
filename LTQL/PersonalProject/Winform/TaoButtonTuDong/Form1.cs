using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaoButtonTuDong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnTaoButton_Click(object sender, EventArgs e)
        {
            int n=10;

            Button bt = new Button();
            for(int i = 0; i < n; i++)
            {
                bt.DialogResult.ToString();
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button bt = new Button();
            
        }
    }
}
