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
        private TaiKhoanDTO loginTaiKhoan;
        public TaiKhoanDTO LoginTaiKhoan
        {
            get => loginTaiKhoan;
            set
            {
                loginTaiKhoan = value;
                LoadFSua();
            }
        }

        public FSuaTaiKhoan(TaiKhoanDTO tk)
        {
            InitializeComponent();
            LoginTaiKhoan = tk;
        }

        void LoadFSua()
        {
            txtTenTK.Text = loginTaiKhoan.TenTK;
            txtTenHienThi.Text = loginTaiKhoan.TenHienThi;
        }
        void UpdateUser()
        {
            string TenTK = txtTenTK.Text;
            string TenHienThi = txtTenHienThi.Text;
            string Pass = txtPass.Text;
            string NewPass = txtNewPass.Text;
            string PassNhapLai = txtNhapLaiPass.Text;
            if (!NewPass.Equals(PassNhapLai))
            {
                MessageBox.Show("Vui lòng xem lại Pass mới và Pass Nhập lại");
            }
            else
            {
                if (TaiKhoanDAO.Instance.UpdateAccountByUser(TenTK, TenHienThi, Pass, NewPass))
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                }
                else
                {
                    MessageBox.Show("Vui lòng xem lại Pass");
                }
            }
        }
        private event EventHandler updateAccount;
        public event EventHandler UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        
        private void btnUpdateTaiKhoan_Click(object sender, EventArgs e)
        {
            UpdateUser();
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
