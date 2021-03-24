using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6._3
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
           if (txtCode.Text == "" || txtName.Text == "" || txtPhone.Text == "" || cbbHome.Text == ""||radM.Checked == false && radFM.Checked == false )
            {
                lbNot.Text = "Plese enter your full infomation";
            }
                  
           else
            {
                ListViewItem item = new ListViewItem(txtCode.Text);

                item.SubItems.Add(txtName.Text);
                item.SubItems.Add(dateTimePicker1.Value.ToString("dd-MM-yyyy"));
                if (radM.Checked = true)
                {
                    item.SubItems.Add("Male");
                }
                else if (radM.Checked = true)
                {
                    item.SubItems.Add("FMale");
                }
                item.SubItems.Add(txtPhone.Text);
                item.SubItems.Add(cbbHome.Text);
                lvShow.Items.Add(item);
                //clear
                txtCode.Clear();
                txtName.Clear();
                radM.Checked = false;
                radFM.Checked = false;
                txtPhone.Clear();
                cbbHome.Items.Remove(cbbHome.Text);
            }
            //create
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {          
            this.lvShow.Items.RemoveAt(lvShow.SelectedIndices[0]);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lvShow.SelectedItems[0].Text = txtCode.Text;
            lvShow.SelectedItems[0].SubItems[1].Text = txtName.Text;
            lvShow.SelectedItems[0].SubItems[2].Text = dateTimePicker1.CustomFormat;
            lvShow.SelectedItems[0].SubItems[3].Text = radM.Text;
            lvShow.SelectedItems[0].SubItems[3].Text = radFM.Text;
            lvShow.SelectedItems[0].SubItems[4].Text = txtPhone.Text;
            lvShow.SelectedItems[0].SubItems[5].Text = cbbHome.Text;
        }

        private void lvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtCode.Text = lvShow.SelectedItems[0].Text;
                txtName.Text = lvShow.SelectedItems[0].SubItems[1].Text;
                dateTimePicker1.CustomFormat = lvShow.SelectedItems[0].SubItems[2].Text;

                radM.Text = lvShow.SelectedItems[0].SubItems[3].Text;
                radFM.Text = lvShow.SelectedItems[0].SubItems[3].Text;
                txtPhone.Text = lvShow.SelectedItems[0].SubItems[4].Text;
                cbbHome.Text = lvShow.SelectedItems[0].SubItems[5].Text;
            }
            catch { }
            
        }
    }
}
