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
        
        public void pbLogo_Click(object sender, EventArgs e)
        {
            pnContainer.Controls.Clear();
        }
        private void btnUserM_Click(object sender, EventArgs e)
        {
            pnContainer.Controls.Clear();
            UCQuanLyNguoiDung nd = new UCQuanLyNguoiDung();
            pnContainer.Controls.Add(nd);
        }

        
        private void btnEmployeeM_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDepartmentM_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEquipmentM_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReportM_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FDangNhap fdn = new FDangNhap();
            fdn.Show();
            this.Hide();
        }

        

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            pnContainer.Controls.Clear();
            UCQLNhaCungCap ncc = new UCQLNhaCungCap();
            pnContainer.Controls.Add(ncc);
        }
        #region Event_Setting
            private void FTrangChu_Load(object sender, EventArgs e)
            {
                pnSetting.Visible = false;
            }
            private void btnSetting_Click(object sender, EventArgs e)
            {
                if (pnSetting.Visible == false)
                {
                    pnSetting.Visible = true;
                }
                else
                {
                    pnSetting.Visible = false;
                }
            }
            private void btnExit_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Exit?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        #endregion
    }
}
