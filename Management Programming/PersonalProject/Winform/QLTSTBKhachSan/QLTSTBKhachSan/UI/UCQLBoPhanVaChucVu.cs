﻿using System;
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
        BindingSource BoPhanListBD = new BindingSource();
        public UCQuanLiBoPhan()
        {
            InitializeComponent();
            Load();
        }

        #region Method
            void Load()
            {
                dtgvQLBP.DataSource = BoPhanListBD;
                LoadBoPhan();
                LoadBinding();
            }
            void LoadBoPhan()
            {
                List<BoPhanDTO> BoPhanList = BoPhanDAO.Instance.LoadBoPhan();
                BoPhanListBD.DataSource = BoPhanList;
                dtgvQLBP.Columns["id"].Visible = false;
            }

            void LoadBinding()
            {
                txtThemBoPhan.DataBindings.Add(new Binding("Text", dtgvQLBP.DataSource, "Tenbp", true, DataSourceUpdateMode.Never));
                txtMaBP.DataBindings.Add(new Binding("Text", dtgvQLBP.DataSource, "Mabp", true, DataSourceUpdateMode.Never));
                txtMaBP.Enabled = false;
            }
        #endregion

        #region Event
            private void btnThemBoPhan_Click(object sender, EventArgs e)
            {
                FBoPhan fbp = new FBoPhan();
                fbp.Show();
            }

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

            private void btnRefesh_Click(object sender, EventArgs e)
            {
                LoadBoPhan();
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Bạn thật sự muốn xoá", "Notification", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string mabp = txtMaBP.Text;
                    if (BoPhanDAO.Instance.XoaBoPhan(mabp))
                    {
                        MessageBox.Show("Đã xoá!");
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
        }
        #endregion
}
