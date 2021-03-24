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
using System.Security.AccessControl;

namespace QLTV
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlCommand cmdSelect;
        SqlCommand cmdInsert;
        SqlCommand cmdXoa;
        int i = 0;

        private void Moketnoi()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
            cn.Open();
        }

        private void LoadListview()
        {
            Moketnoi();
            cmdSelect = new SqlCommand("select * from NhanVien", cn);
            SqlDataReader r = cmdSelect.ExecuteReader();
            listView1.Items.Clear();
            while (r.Read())
            {
                string[] st = new string[5];
                st[0] = r[0].ToString();
                st[1] = r[1].ToString();
                st[2] = r[2].ToString();
                st[3] = r[3].ToString();
                st[4] = r[4].ToString();
                st[4] = r[5].ToString();
                ListViewItem lv = new ListViewItem(st);
                listView1.Items.Add(lv);
            }
            cmdSelect.Dispose();
        }

        private void LoadItem(int i)
        {
            //txtmanhanvien.Text = listView1.Items[i].Text;
            txthoten.Text = listView1.Items[i].SubItems[1].Text;
            txtdiachi.Text = listView1.Items[i].SubItems[2].Text;
            txttendangnhap.Text = listView1.Items[i].SubItems[3].Text;
            cbbquyenhan.Text = listView1.Items[i].SubItems[4].Text;
        }

        private void LoadCombox()
        {
            cbbquyenhan.Items.Add("Admin");
            cbbquyenhan.Items.Add("Sinhvien");
            cbbquyenhan.Items.Add("Thuthu");
            cbbquyenhan.Text = "Admin";
        }

        private void XoaTextBox()
        {
            txtmanhanvien.Clear();
            txthoten.Clear();
            txtdiachi.Clear();
            txttendangnhap.Clear();
            txtmanhanvien.Focus();
        }

        private int KiemTraMa(string ma)
        {
            Moketnoi();
            cmdSelect = new SqlCommand("select count(*)from NhanVien where manhanvien='"+ma.Trim()+"'");
            cmdSelect.Connection = cn;
            return (int)cmdSelect.ExecuteScalar();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {try
            {
                cn = new SqlConnection(@"Data Source=DESKTOP-J6DGHEU\SQLEXPRESS;Initial Catalog=QuanLiThuVien;Integrated Security=True");
                cn.Open();
            }
            catch(Exception loi)
            { MessageBox.Show("Khong the ket noi" + loi); }
            LoadListview();
            i = 0;
            LoadItem(i);
            LoadCombox();
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            i = 0;
            LoadItem(i);
        }

        private void btnTien_Click(object sender, EventArgs e)
        {
            i++;
            if (i == listView1.Items.Count)
                i = listView1.Items.Count - 1;
            LoadItem(i);
        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = 0;
            LoadItem(i);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            i = listView1.Items.Count - 1;
            LoadItem(i);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (btnTaoMoi.Text.Equals("Tao moi"))
            {
                XoaTextBox();
                btnTaoMoi.Text = "Luu";
            }
            else
                if (KiemTraMa(txtmanhanvien.Text) == 1)
                     {
                         MessageBox.Show("ma nay da co");
                         txtmanhanvien.Clear();
                         txtmanhanvien.Focus();
                     }    
                else
                    {
                string ma = txtmanhanvien.Text;
                string hoten = txthoten.Text;
                string diachi = txtdiachi.Text;
                string tendangnhap = txttendangnhap.Text;
                string matkhau = "";
                string quyenhan = cbbquyenhan.Text;
                Moketnoi();
                string sql = "insert into NhanVien values("+"'"+ma+"','"+hoten+"','"+diachi+"','"+tendangnhap+"','"+matkhau+"','"+quyenhan+"')";
                cmdInsert = new SqlCommand(sql, cn);
                cmdInsert.ExecuteNonQuery();
                MessageBox.Show("Da luu thanh cong");
                LoadListview();
                btnTaoMoi.Text = "tao moi";
                cmdInsert.Dispose();
                    }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Moketnoi();
            string sql = "select * from NhanVien where manhanvien='" + txtmanhanvien.Text + "'";
            cmdSelect = new SqlCommand(sql, cn);
            SqlDataReader dr = cmdSelect.ExecuteReader();
            if (dr.Read())
            {
                txtmanhanvien.Text = dr[0].ToString();
                txthoten.Text = dr[1].ToString();
                txtdiachi.Text = dr[2].ToString();
                txttendangnhap.Text = dr[4].ToString();
                cbbquyenhan.Text = dr[5].ToString();
            }
            else
                MessageBox.Show("khong tim thay");
        }

        private void btnXoaBo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Chac chan xoa hay khong?", "Thong bao", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                Moketnoi();
                string Sql = "delete from NhanVien where manhanvien='"+txtmanhanvien.Text+"'";
                cmdXoa = new SqlCommand(Sql, cn);
                if (cmdXoa.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Xoa thanh cong");
                    LoadListview();
                    LoadItem(0);
                }
                else
                    MessageBox.Show("Khong ton tai ma nhan vien" + txtmanhanvien.Text);
                     cmdXoa.Dispose();
            }         
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
