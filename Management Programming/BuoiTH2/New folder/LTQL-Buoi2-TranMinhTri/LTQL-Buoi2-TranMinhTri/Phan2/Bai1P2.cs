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

namespace LTQL_Buoi2_TranMinhTri.Phan2
{
    public partial class Bai1P2 : Form
    {
        public Bai1P2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void Cau1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";
            LoadChucVu();
           

            //Add Parameter in SqlCommand
            string ThemCV = "insert into chucvu values (@MaCV , @TenCV , @Hsphucap)";
            SqlCommand Themcmd = new SqlCommand(ThemCV,con);
            //Themcmd.Parameters.Clear();
            Themcmd.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");
            Themcmd.Parameters.Add("@TenCV", SqlDbType.NVarChar, 50, "tencv");
            Themcmd.Parameters.Add("@Hsphucap", SqlDbType.Float, 50 ,"hsphucap");
            da.InsertCommand = Themcmd;
        }

        void LoadChucVu()
        {
            string QueryChucVu = "SELECT * FROM chucvu";
            cmd = new SqlCommand(QueryChucVu, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tblChucVu");
            dtgvDSCV.DataSource = ds.Tables["tblChucVu"];
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["tblChucVu"].NewRow();
            row["macv"] = txtMaCV.Text;
            row["tencv"] = txtTenCV.Text;
            row["hsphucap"] = float.Parse(txtHSPC.Text);
            ds.Tables["tblChucVu"].Rows.Add(row);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

       
    }
}
