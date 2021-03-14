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
            Button bt = new Button();
            bt.DialogResult = DialogResult.OK;
            bt.Location = new System.Drawing.Point(13,81);
            bt.Name = "button3";
            bt.Text = "New Button";
            Controls.Add(bt);


        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnTaoButton_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
