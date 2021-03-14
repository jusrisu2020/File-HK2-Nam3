using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Image image = Image.FromFile(@"C:\Users\PC GAMING\Pictures\Saved Pictures\1.jpg");
            //pictureBox2.Image = image;
            //pictureBox2.Height = image.Height;
            //pictureBox2.Width = image.Width;
            //pictureBox2.ImageLocation = @"C:\Users\PC GAMING\Pictures\Saved Pictures\1.jpg";
            //pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog fopen = new OpenFileDialog();
            fopen.Filter = "|*.jpg";
            if (fopen.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(fopen.FileName);

                pictureBox2.Image = image;
            }
        }
    }
}
