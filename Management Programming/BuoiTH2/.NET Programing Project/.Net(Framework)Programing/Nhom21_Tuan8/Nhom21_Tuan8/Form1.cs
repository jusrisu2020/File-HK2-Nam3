using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom21_Tuan8
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
            tl = MessageBox.Show("Exit ?", "Notifition", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK) Application.Exit();
        }
        
        private void btnPerform_Click(object sender, EventArgs e)
        {
            if(radSquare.Checked == true)
            {
                if(txtEdge.Text == "")
                {
                    this.lbNot.Text = "Hollow Edge";
                }
                else
                {                 
                    Form2 f2 = new Form2();
                    f2.canh = double.Parse(txtEdge.Text);
                    this.Hide();
                    f2.ShowDialog();
                }             
            }
            if(radRectangle.Checked == true)
            {
                if (txtLong.Text == "" || txtWide.Text == "")
                {
                    this.lbNot.Text = "Hollow Long or Wide";
                }
                else
                {
                    Form3 f3 = new Form3();
                    f3.dai = double.Parse(txtLong.Text);
                    f3.rong = double.Parse(txtWide.Text);
                    this.Hide();
                    f3.ShowDialog();
                }
            }
            if(radCircle.Checked == true)
            {
                if(txtRadius.Text == "")
                {
                    this.lbNot.Text = "Hollow Circle";
                }
                else
                {
                    Form4 f4 = new Form4();
                    f4.radius = double.Parse(txtRadius.Text);
                    this.Hide();
                    f4.ShowDialog();
                }
            }
            //calculate of the Square
            

        }

        private void radSquare_CheckedChanged(object sender, EventArgs e)
        {
           
            this.txtEdge.Clear();           
            this.txtLong.Clear();
            this.txtWide.Clear();
            this.txtRadius.Clear();
            
            txtEdge.Enabled = true;
            txtLong.Enabled = false;
            txtWide.Enabled = false;
            txtRadius.Enabled = false;
        }

        private void radRectangle_CheckedChanged(object sender, EventArgs e)
        {
            this.txtEdge.Clear();
            this.txtLong.Clear();
            this.txtWide.Clear();
            this.txtRadius.Clear();

            txtEdge.Enabled = false;
            txtLong.Enabled = true;
            txtWide.Enabled = true;
            txtRadius.Enabled = false;
        }

        private void radCircle_CheckedChanged(object sender, EventArgs e)
        {
            this.txtEdge.Clear();
            this.txtLong.Clear();
            this.txtWide.Clear();
            this.txtRadius.Clear();

            txtEdge.Enabled = false;
            txtLong.Enabled = false;
            txtWide.Enabled = false;
            txtRadius.Enabled = true;
        }
    }
}
