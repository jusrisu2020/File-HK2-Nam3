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

namespace BuoiTH2
{
    public partial class FrmBai2 : Form
    {
        public FrmBai2()
        {
            InitializeComponent();
        }

        private void FrmBai2_Load(object sender, EventArgs e)
        {
            Ketnoi();
        }

        private void Ketnoi()
        {
             SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VG1T5FL\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True");


            if (olecon.State != ConnectionState.Open)
                olecon.Open();

            DataSet ds = new DataSet();

            OleDbDataAdapter oleada = new OleDbDataAdapter("select * from CHUCVU", olecon);

            oleada.Fill(ds, "TableChucVu");
            cbChucVu.DataSource = ds.Tables["TableChucVu"];
            cbChucVu.DisplayMember = "tencv";
            olecon.Close();
        }
    }
}
