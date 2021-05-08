using QLTSTBKhachSan.DAO;
using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace QLTSTBKhachSan.UI
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }
        
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            string PassWord = txtPassword.Text;
            if (TaiKhoanDAO.Instance.Login(UserName, PassWord))
            {
                TaiKhoanDTO LoginTaiKhoan = TaiKhoanDAO.Instance.GetAccountByUserName(UserName);
                FTrangChu Ftc = new FTrangChu(LoginTaiKhoan);
                Ftc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản");
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
