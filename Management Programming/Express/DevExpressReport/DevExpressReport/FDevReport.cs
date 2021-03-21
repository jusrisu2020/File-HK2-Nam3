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
using DevExpress.XtraReports.UI;

namespace DevExpressReport
{
    public partial class FDevReport : Form
    {
        public FDevReport()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=ReportDoanhSo;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public void HienThi()
        {
            BaoCaoDoanhSo bcds = new BaoCaoDoanhSo();
            bcds.DataSource = dt;
            bcds.ShowPreviewDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string HDQuery = @"SELECT * FROM DoanhSo WHERE MaHD = '" + txtBaoCao.Text.ToLower() + "'";
            con.Open();
            cmd = new SqlCommand(HDQuery, con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            HienThi();
        }

        private void btnHienThiHet_Click(object sender, EventArgs e)
        {
            string AllQuery = @"SELECT * FROM DoanhSo";
            con.Open();
            cmd = new SqlCommand(AllQuery, con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            HienThi();
        }
    }
}
