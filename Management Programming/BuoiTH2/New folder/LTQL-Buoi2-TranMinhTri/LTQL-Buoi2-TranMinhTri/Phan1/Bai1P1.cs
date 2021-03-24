using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LTQL_Buoi2_TranMinhTri
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        OleDbConnection ocon = new OleDbConnection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
       
        private void Bai1_Load(object sender, EventArgs e)
        {
            ocon.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\qlnv.accdb";
            ocon.Open();
                LoadChucVu();
            ocon.Close();
        }

        void LoadChucVu()
        {
            string queryChucVu = "SELECT * FROM CHUCVU";
            da = new OleDbDataAdapter(queryChucVu, ocon);
            da.Fill(ds, "tblChucVu");
            cbChucVu.DataSource = ds.Tables["tblChucVu"];
            cbChucVu.DisplayMember = "tencv";
            cbChucVu.ValueMember = "macv";
            dtgvNhanVien.DataSource = ds.Tables["tblChucVu"];

            dtgvNhanVien.Columns["macv"].HeaderText = "Mã Chức Vụ";
            dtgvNhanVien.Columns["tencv"].HeaderText = "Tên Chức Vụ";
            dtgvNhanVien.Columns["hsphucap"].HeaderText = "Hệ Số Phụ Cấp";
            dtgvNhanVien.Columns["hsphucap"].Width = 130;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit?","Notification",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
