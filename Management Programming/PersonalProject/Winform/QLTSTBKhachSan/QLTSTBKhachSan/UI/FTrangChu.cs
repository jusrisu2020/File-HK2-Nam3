using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLTSTBKhachSan.UI
{
    public partial class FTrangChu : Form
    {
       
        public FTrangChu()
        {
            InitializeComponent();
        }
        
        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }
        private void FTrangChu_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            ucQuanLyNguoiDung1.Hide();
        }

        
        private void pbLogo_Click(object sender, EventArgs e)
        {
            ucQuanLyNguoiDung1.Hide();
            /*ucQuanLyNhanVien1.Hide();
            ucQuanLiBoPhan1.Hide();
            ucQuanLyThietBi1.Hide();
            ucQuanLyBaoCao1.Hide();*/
        }

       
        private void btnUserM_Click(object sender, EventArgs e)
        {
            ucQuanLyNguoiDung1.Show();
            //ucQuanLyNhanVien1.Hide();
            ucQuanLiBoPhan1.Hide();
           /* ucQuanLyThietBi1.Hide();
            ucQuanLyBaoCao1.Hide();*/
        }

        
        private void btnEmployeeM_Click(object sender, EventArgs e)
        {
            ucQuanLyNguoiDung1.Hide();
            /*ucQuanLyNhanVien1.Show();
            ucQuanLiBoPhan1.Hide();
            ucQuanLyThietBi1.Hide();
            ucQuanLyBaoCao1.Hide();*/
        }

        private void btnDepartmentM_Click(object sender, EventArgs e)
        {
            ucQuanLyNguoiDung1.Hide();
            //ucQuanLyNhanVien1.Hide();
            ucQuanLiBoPhan1.Show();
            /*ucQuanLyThietBi1.Hide();
            ucQuanLyBaoCao1.Hide();*/
        }

        private void btnEquipmentM_Click(object sender, EventArgs e)
        {
            ucQuanLyNguoiDung1.Hide();
            /*ucQuanLyNhanVien1.Hide();
            ucQuanLiBoPhan1.Hide();
            ucQuanLyThietBi1.Show();
            ucQuanLyBaoCao1.Hide();*/
        }

        private void btnReportM_Click(object sender, EventArgs e)
        {
            ucQuanLyNguoiDung1.Hide();
           /* ucQuanLyNhanVien1.Hide();
            ucQuanLiBoPhan1.Hide();
            ucQuanLyThietBi1.Hide();
            ucQuanLyBaoCao1.Show();*/
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FDangNhap fdn = new FDangNhap();
            fdn.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit?","Notification",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnUserM_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
