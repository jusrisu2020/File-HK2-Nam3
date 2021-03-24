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

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Exit?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK) Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txtAdd.Text == "")
            {
                MessageBox.Show("Error", "Loaloa");
            }
            
            if(this.radB.Checked == true)
            {
                lbB.Items.Add(this.txtAdd.Text); 
            }

            if(this.radA.Checked == true)
            {
                lbA.Items.Add(this.txtAdd.Text);
            }
            txtAdd.Clear();
        }

        private void btnAB_Click(object sender, EventArgs e)
        {
            if (lbA.SelectedIndex !=-1)
            {
                lbB.Items.Add(lbA.SelectedItem.ToString());
                lbA.Items.RemoveAt(lbA.SelectedIndex);
            }
        }

        private void btnBA_Click(object sender, EventArgs e)
        {
            if (lbB.SelectedIndex != -1)
            {
                lbA.Items.Add(lbB.SelectedItem.ToString());
                lbB.Items.RemoveAt(lbB.SelectedIndex);
            }
        }

        private void btnAllAB_Click(object sender, EventArgs e)
        {
                while(lbA.Items.Count > 0)
            {
                lbA.SetSelected(0, true);
                lbB.Items.Add(lbA.SelectedItem.ToString());
                lbA.Items.Remove(lbA.SelectedItem);
            }        
        }

        private void btnAllBA_Click(object sender, EventArgs e)
        {
            while (lbB.Items.Count > 0)
            {
                lbB.SetSelected(0,true);
                lbA.Items.Add(lbA.SelectedItems.ToString());
                lbB.Items.Remove(lbB.SelectedItem);
            }
        }

        
    }
}
