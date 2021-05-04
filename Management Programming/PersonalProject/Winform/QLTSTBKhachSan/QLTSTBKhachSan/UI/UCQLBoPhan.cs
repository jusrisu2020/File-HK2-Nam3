using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTSTBKhachSan.DAO;
using QLTSTBKhachSan.DTO;

namespace QLTSTBKhachSan.UI
{
    public partial class UCQuanLiBoPhan : UserControl
    {
        public UCQuanLiBoPhan()
        {
            InitializeComponent();
            LoadData();
            EditColumn();
        }

        #region Method
            void LoadData()
            {
                LoadBoPhan();
                LoadBinding();
            }
            
            List<BoPhanDTO> SearchTenBoPhan(string name)
            {
                List<BoPhanDTO> BoPhanList = BoPhanDAO.Instance.SearchTenBoPhan(name);
                return BoPhanList;
            }
            void LoadBoPhan()
            {
                List<BoPhanDTO> BoPhanList = BoPhanDAO.Instance.LoadBoPhan();
                dtgvQLBP.DataSource = BoPhanList;
            }
            void EditColumn()
            {
                dtgvQLBP.Columns[0].Visible = false;
                dtgvQLBP.Columns[1].HeaderText = "Mã Bộ Phận";
                dtgvQLBP.Columns[2].HeaderText = "Tên Bộ Phận";
            }
            void LoadBinding()
            {
                txtThemBoPhan.DataBindings.Add(new Binding("Text", dtgvQLBP.DataSource, "Tenbp", true, DataSourceUpdateMode.Never));
                txtMaBP.DataBindings.Add(new Binding("Text", dtgvQLBP.DataSource, "Mabp", true, DataSourceUpdateMode.Never));
                txtMaBP.Enabled = false;
            }
        #endregion

        #region Event
            private void btnThemBP_Click(object sender, EventArgs e)
            {
                string tenbp = txtThemBoPhan.Text;
                if (tenbp == "")
                {
                    MessageBox.Show("Tên phòng không được bỏ trống!");
                }
                else
                {
                    if (BoPhanDAO.Instance.ThemBoPhan(tenbp))
                    {
                        MessageBox.Show("Saved!");
                        LoadBoPhan();
                        txtThemBoPhan.Clear();
                        txtThemBoPhan.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
            }
            private void btnSuaBoPhan_Click(object sender, EventArgs e)
            {
                string tenbp = txtThemBoPhan.Text;
                string mabp = txtMaBP.Text;
                if (tenbp == "")
                {
                    MessageBox.Show("Tên phòng không được bỏ trống!");
                }
                else
                {
                    if (BoPhanDAO.Instance.SuaBoPhan(mabp, tenbp))
                    {
                        MessageBox.Show("Đã thay đổi!");
                        LoadBoPhan();
                        txtThemBoPhan.Clear();
                        txtThemBoPhan.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
            }
            private void btnDelete_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Bạn thật sự muốn xoá", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string mabp = txtMaBP.Text;
                    if (BoPhanDAO.Instance.XoaBoPhan(mabp))
                    {
                        LoadBoPhan();
                        txtThemBoPhan.Clear();
                        txtThemBoPhan.Focus();
                        MessageBox.Show("Đã xoá!","Notification",MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
            }
            private void btnRefesh_Click(object sender, EventArgs e)
            {
                txtThemBoPhan.Clear();
                txtThemBoPhan.Focus();
                LoadBoPhan();
            }

        private void btnTKBoPhan_Click(object sender, EventArgs e)
        {
            dtgvQLBP.DataSource = SearchTenBoPhan(txtTKBoPhan.Text);
        }

        
    }
        #endregion
}
