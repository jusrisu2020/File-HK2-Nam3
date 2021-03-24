using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.lstweb.Items.Add("Tuổi trẻ");
            this.lstweb.Items.Add("Thanh niên");
            this.lstweb.Items.Add("VNExpress"); this.lstweb.Items.Add("Dân trí");
            this.lstweb.Items.Add("Công an");
            this.lstweb.SelectedItem = "Tuổi trẻ";
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.txtKQ.Text = "Bạn đã chọn website ";
            this.txtKQ.Text += this.lstweb.SelectedItem.ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            this.txtKQ.Clear();
        }
    }
}
