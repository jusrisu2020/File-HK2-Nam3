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

namespace LTQL_Buoi2_TranMinhTri.Phan1
{
    public partial class Bai2P1 : Form
    {
        public Bai2P1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();

        private void Bai2_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";
            con.Open();
                LoadNhanVien();
            con.Close();
        }

        void LoadNhanVien() 
        {
            string QuerySNV = "SELECT * FROM nhanvien";
            cmd = new SqlCommand(QuerySNV, con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblNhanVien");
            dtgvDSNV.DataSource = ds.Tables["tblNhanVien"];
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string QueryTimNV = "SELECT * FROM nhanvien WHERE manv = N'" + txtTimKiem.Text.ToLower() + "'";
            cmd = new SqlCommand(QueryTimNV, con);
            DataSet dsTim = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(dsTim, "tblTimNV");
            dtgvDSNV.DataSource = dsTim.Tables["tblTimNV"].DefaultView;
        }
    }
}
