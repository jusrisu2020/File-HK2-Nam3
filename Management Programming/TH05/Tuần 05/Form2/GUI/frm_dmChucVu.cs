﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frm_dmChucVu : Form
    {
        public frm_dmChucVu()
        {
            InitializeComponent();
        }
               
        private void frm_dmChucVu_Load(object sender, EventArgs e)
        {
            HienThiChucVuLenDataGrid();
        }
        private void HienThiChucVuLenDataGrid()
        {
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            dgDSChucVu.DataSource = lstChucVu;
        }

    }
}
