using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string str = "";
            if (rad1.Checked)
                str = str + "Nam";
            else
                str += "Nữ";

            var txt = "Họ tên: " + txtHonTen.Text + "\n"
                + "Giới tính: " + str + "\n"
                + "Ngày sinh: " + cmbNgaySinh.Text + "\n"
                + "Địa chỉ: " + txtDiaChi.Text + "\n"
                + "Điện thoại: " + txtDienThoai.Text + "\n"
                + "Email: " + txtEmail.Text;
            if(ckbDangHoc.Checked && ckbDangLam.Checked)
            {
                MessageBox.Show(txt + "\n" + "Thông tin: vừa học vừa làm");
            }    
            else if(ckbDangLam.Checked)
            {
                MessageBox.Show(txt + "\n" + "Thông tin: Đi làm");
            }    
            else if(ckbDangHoc.Checked)
            {
                MessageBox.Show(txt + "\n" + "Thông tin: Đi Học");
            }   
            else
            {
                MessageBox.Show(txt + "\n" + "Thông tin: không  thông tin");
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
