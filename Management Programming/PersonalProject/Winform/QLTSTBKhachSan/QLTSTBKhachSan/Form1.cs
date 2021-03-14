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
namespace QLTSTBKhachSan
{
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=LinkBoPhanS;Integrated Security=True");
            con.Open();
            string query = @"Select * from TaiKhoan";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable data = new DataTable();

            da.Fill(data);

            dataGridView1.DataSource = data;
            cbTK.DataSource = data;
            cbTK.DisplayMember = "BoPhan";
            cbTK.ValueMember = "MaBP";

            con.Close();
        }
    }
}
