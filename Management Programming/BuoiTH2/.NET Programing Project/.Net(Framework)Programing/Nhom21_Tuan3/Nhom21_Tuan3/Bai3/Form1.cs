﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            this.txtKQ.Clear();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.txtKQ.Text = "Bạn đã chọn website ";
            this.txtKQ.Text += this.lstweb.SelectedItem.ToString();
        }
    }
}
