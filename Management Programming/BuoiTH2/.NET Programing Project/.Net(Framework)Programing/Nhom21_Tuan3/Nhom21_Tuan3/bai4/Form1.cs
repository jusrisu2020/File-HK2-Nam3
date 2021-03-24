using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            if (this.txtHoten.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtHoten.Focus();
            }
            else
            {
                string hoten = this.txtHoten.Text;
                if (this.rad1.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToLower();
                }
                if (this.rad2.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToUpper();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoten.Clear();
            this.txtKQ.Clear();
            if (this.rad1.Checked ==true)
              this.rad1.Checked = false;
           else
            this.rad2.Checked = false;
            this.txtHoten.Focus();
            
          
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txtHoten.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtHoten.Focus();
            }
            else
            {
                string hoten = this.txtHoten.Text;
                if (this.rad1.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToLower();
                }
                if (this.rad2.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToUpper();
                }
            }
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txtHoten.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtHoten.Focus();
            }
            else
            {
                string hoten = this.txtHoten.Text;
                if (this.rad1.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToLower();
                }
                if (this.rad2.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToUpper();
                }
            }
        }
    }
}
