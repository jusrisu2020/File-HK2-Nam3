﻿using QLCF.DAO;
using QLCF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            LoadTable();
        }

        #region Method
        void LoadTable()
        {
            List<TableDTO> tableList = TableDAO.Instance.LoadTableList();
            foreach (TableDTO item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                flpTable.Controls.Add(btn);
                btn.Text = item.NameText + "\n" + item.StaTus;
                switch (item.StaTus)
                {
                    case "Trống": btn.BackColor = Color.Blue;
                        break;
                    case "Có Khách": btn.BackColor = Color.Red;
                        break;
                }
            }
        }
        #endregion
        #region Event
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAdmin fa = new FAdmin();
            this.Hide();
            fa.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDangNhap fdn = new FDangNhap();
            this.Hide();
            fdn.ShowDialog();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FUserInfo fa = new FUserInfo();
            this.Hide();
            fa.ShowDialog();
        }
        #endregion
    }
}
