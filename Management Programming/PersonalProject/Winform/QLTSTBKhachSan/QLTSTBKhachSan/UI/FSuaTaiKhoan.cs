using QLTSTBKhachSan.DAO;
using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTSTBKhachSan.UI
{
    public partial class FSuaTaiKhoan : Form
    {
        public FSuaTaiKhoan()
        {
            InitializeComponent();
        }
        

        private void btnUpdateTaiKhoan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát","Notification",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Hide();
            }
        }
    }
}
