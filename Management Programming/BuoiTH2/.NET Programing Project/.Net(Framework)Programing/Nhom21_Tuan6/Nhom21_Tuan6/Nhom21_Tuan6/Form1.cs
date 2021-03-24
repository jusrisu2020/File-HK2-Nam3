using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Nhom21_Tuan6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();                    
            font.Font = txtNhap.Font;
            if(font.ShowDialog() == DialogResult.OK)
            {
                txtNhap.Font = font.Font;
                txtNhap.ForeColor = font.Color;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.Color = txtNhap.BackColor;
            if (color.ShowDialog() == DialogResult.OK)
            {              
                txtNhap.ForeColor = color.Color;
            }
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.txt)|*.txt";
            DialogResult show = save.ShowDialog();
            if(show == DialogResult.OK)
            {   
                Stream myStream = save.OpenFile();
                StreamWriter writer = new StreamWriter(myStream);
                writer.Write(txtNhap.Text);
                writer.Close();
                myStream.Close();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Exit?","Notification",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (tl == DialogResult.OK) Application.Exit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "(*.txt)|*.txt";                     
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader r = new StreamReader(open.FileName);
                txtNhap.Text = r.ReadToEnd();
                r.Close();                                                   
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
