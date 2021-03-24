using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//add Full Name student
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAB_Click(object sender, EventArgs e)
        {
            if(this.lbA.SelectedIndex != -1)
            {
                lbB.Items.Add(lbA.SelectedItem);
                lbA.Items.RemoveAt(lbA.SelectedIndex);
            }
            
        }

        private void btnBA_Click(object sender, EventArgs e)
        {
            if (this.lbB.SelectedIndex != -1)
            {
                lbA.Items.Add(lbB.SelectedItem);
                lbB.Items.RemoveAt(lbB.SelectedIndex);
            }
        }

        private void btnallAB_Click(object sender, EventArgs e)
        {
            while(lbA.Items.Count > 0)
            {
                lbA.SetSelected(0, true);
                lbB.Items.Add(lbA.SelectedItem.ToString());
                lbA.Items.Remove(lbA.SelectedItem);
            }
        }

        private void btnallBA_Click(object sender, EventArgs e)
        {
            while(lbB.Items.Count > 0)
            {
                lbB.SetSelected(0, true);
                lbA.Items.Add(lbB.SelectedItem.ToString());
                lbB.Items.Remove(lbB.SelectedItem);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Exit?", "Notification",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (tl == DialogResult.OK) Application.Exit();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int s = 0;
            int lbt = lbA.Items.Count + lbB.Items.Count;
            for(int i=0;i<lbt;i++)
            {
                s += Convert.ToInt32(lbt);
            }
            MessageBox.Show("Total student of 2 class: "+lbt,"Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
//chỉnh màu button
        private void btnAB_MouseEnter_1(object sender, EventArgs e)
        {
            btnAB.BackColor = Color.Red;
        }

        private void btnAB_MouseLeave_1(object sender, EventArgs e)
        {
            btnAB.BackColor = Color.White;
        }
//BA
        private void btnBA_MouseEnter(object sender, EventArgs e)
        {
            btnBA.BackColor = Color.Red;
        }

        private void btnBA_MouseLeave(object sender, EventArgs e)
        {
            btnBA.BackColor = Color.White;
        }
//allAB
        private void btnallAB_MouseEnter(object sender, EventArgs e)
        {
            btnallAB.BackColor = Color.Red;
        }

        private void btnallAB_MouseLeave(object sender, EventArgs e)
        {
            btnallAB.BackColor = Color.White;
        }
//allBA
        private void btnallBA_MouseEnter(object sender, EventArgs e)
        {
            btnallBA.BackColor = Color.Red;
        }

        private void btnallBA_MouseLeave(object sender, EventArgs e)
        {
            btnallBA.BackColor = Color.White;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                labNot.Text = "You didn't enter content";
            }

            if (radA.Checked == true)
            {
                lbA.Items.Add(txtNhap.Text);
                txtNhap.Clear();
            }
            if (radB.Checked == true)
            {
                lbB.Items.Add(txtNhap.Text);
                txtNhap.Clear();
            }
            if (radA.Checked == false && radB.Checked == false)
            {
                labNot1.Text = "You didn't choose class";
            }
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.DarkRed;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.White;
        }

        private void btnTotal_MouseEnter(object sender, EventArgs e)
        {
            btnTotal.BackColor = Color.DarkRed;
        }

        private void btnTotal_MouseLeave(object sender, EventArgs e)
        {
            btnTotal.BackColor = Color.White;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.AliceBlue;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.White;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
