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
using QLCF.DAO;
namespace QLCF
{
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
            //dtgvTaiKhoan.DataSource = DataProvider.Instance.ExecuteQuery("EXEC USPGetAccountByUserName @userName", new object[] { "'OR 1=1--" });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FMain fm = new FMain();
            this.Hide();
            fm.Show();
        }
    }
}
