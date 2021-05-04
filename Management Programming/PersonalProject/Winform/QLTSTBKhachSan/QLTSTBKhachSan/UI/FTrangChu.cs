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
            AddLoadToolTip();
            pnMuiti.Visible = false;
        }
        #region Method
        void AddLoadToolTip()
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(btnSetting, "Setting\n(Ctrl + S)");
            tt.SetToolTip(btnNotification, "Setting\n(Ctrl + N)");
            tt.SetToolTip(btnHelp, "Help\n(Ctrl + H)");
        }
        #endregion
        #region Envent_Main
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
            pnContainer.Controls.Clear();
            UCQuanLyNhanVien nv = new UCQuanLyNhanVien();
            pnContainer.Controls.Add(nv);
        }

        private void btnDepartmentM_Click(object sender, EventArgs e)
        {
            pnContainer.Controls.Clear();
            UCQuanLiBoPhan bp = new UCQuanLiBoPhan();
            pnContainer.Controls.Add(bp);
        }

        private void btnEquipmentM_Click(object sender, EventArgs e)
        {
            if (pnMuiti.Visible == true)
            {
                pnMuiti.Visible = false;
            }
            else
            {
                pnMuiti.Visible = true;
            }
        }
            private void gunaButton1_Click(object sender, EventArgs e)
            {
                pnContainer.Controls.Clear();
                UCQuanLyThietBi tb = new UCQuanLyThietBi();
                pnContainer.Controls.Add(tb);
            }
        private void btnReportM_Click(object sender, EventArgs e)
        {
            pnContainer.Controls.Clear();
            UCQuanLyBaoCao bc = new UCQuanLyBaoCao();
            pnContainer.Controls.Add(bc);
        }
            
        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            pnContainer.Controls.Clear();
            UCQLNhaCungCap ncc = new UCQLNhaCungCap();
            pnContainer.Controls.Add(ncc);
        }
        private void btnHeThong_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Event_Dif
        private void btnNotification_Click(object sender, EventArgs e)
        {
            FThongBao tb = new FThongBao();
            tb.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            FHelp h = new FHelp();
            h.Show();
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            FSetting st = new FSetting();
            st.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit?", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FDangNhap fdn = new FDangNhap();
            fdn.Show();
            this.Hide();
        }



        #endregion

        private void pnLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
