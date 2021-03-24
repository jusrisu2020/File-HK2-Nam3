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
using System.Drawing;
namespace Tuan6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Exit?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK) Application.Exit();     
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File|*.txt";
            DialogResult hienthi = save.ShowDialog();
            if (hienthi == DialogResult.OK)
            {
                Stream myStream = save.OpenFile();
                StreamWriter writer = new StreamWriter(myStream);
                writer.Write(txtNhap.Text);
                writer.Close();
                myStream.Close();
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true;
            font.Color = txtNhap.ForeColor;
            font.Font = txtNhap.Font;
            if (font.ShowDialog() == DialogResult.OK)
            {
                txtNhap.Font = font.Font;
                txtNhap.ForeColor = font.Color;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            txtNhap.ForeColor = color.Color;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "dang text|*txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader a = new StreamReader(open.FileName);
                txtNhap.Text = a.ReadToEnd();
                a.Close();
            }
        }
    }
}
