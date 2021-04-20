﻿using QLTSTBKhachSan.DAO;
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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            string PassWord = txtPassword.Text;
            if (Login(UserName, PassWord))
            {
                FTrangChu Ftc = new FTrangChu();
                Ftc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản");
            }

        }

        bool Login(string TenTKs, string Passs)
        {
            return TaiKhoanDAO.Instance.Login(TenTKs, Passs);
        }
    }
}
