﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class FrmBai4_3 : Form
    {
        public FrmBai4_3()
        {
            InitializeComponent();
        }

        private void btnTính_Click(object sender, EventArgs e)
        {
            float s = 0;
            int n;
            int i = 1;
            n = int.Parse(txtn.Text);

            while (i <= n)
            {
                s = s + (float)(1.0 / i);
                i++;

            }
            txts.Text = s.ToString();
        }
    }
}