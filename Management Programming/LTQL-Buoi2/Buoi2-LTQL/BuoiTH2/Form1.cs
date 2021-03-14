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
namespace BuoiTH2
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
       
       
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            AccessConnection();
        }

        private void AccessConnection()
        {
            string kn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\qlnv.accdb";
            OleDbConnection olecon = new OleDbConnection(kn);


            if(olecon.State != ConnectionState.Open)
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
