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
namespace Bai6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
//BUTTON EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Exit ?", "Notifition", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK) Application.Exit();
        }
//BUTTON ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtCode.Text == ""|| txtName.Text == "" || txtAddress.Text == "" || cbbClass.Text == "")
            {
                MessageBox.Show("Plese enter you full infomation", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListViewItem item = new ListViewItem(txtCode.Text);
                item.SubItems.Add(txtName.Text);
                item.SubItems.Add(txtAddress.Text);
                item.SubItems.Add(dateTimePicker1.Value.ToString("dd-MM-yyyy"));
                item.SubItems.Add(cbbClass.Text);
                lvShow.Items.Add(item);
                txtName.Clear();
                txtCode.Clear();
                txtAddress.Clear();
                
            }            
        }
//BUTTON REMOVE TỪNG ITEM
        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.lvShow.Items.RemoveAt(lvShow.SelectedIndices[0]);
        }
//BUTTON REMOVE ALL VÀ HỎI
        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("You really want to delete ? ", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(tl == DialogResult.OK)
            {
                this.lvShow.Items.Clear();
            }        
        }
//BUTTON SAVE INFOMATION OF STUDENTS
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All File|*.*";                     
            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;
                for(int i = 0;i<lvShow.Items.Count;i++)
                {
                    File.AppendAllText(path,
                    lvShow.Items[i].SubItems[0].Text +"\n"
                    + lvShow.Items[i].SubItems[1].Text + "\n"
                    + lvShow.Items[i].SubItems[2].Text + "\n"
                    + lvShow.Items[i].SubItems[3].Text + "\n"
                    + lvShow.Items[i].SubItems[4].Text + "\n\n");
                }
            }             
        }
        
    }
}
