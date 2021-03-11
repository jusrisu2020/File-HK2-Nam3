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
            LoadAccountList();
        }

       void LoadAccountList()
        {
            string AccountQuery = "exec USPGetAccountByUserName @userName = N'Admin0'";
            DataProvider provider =  new DataProvider();
            dtgvTaiKhoan.DataSource = provider.ExecuteQuery(AccountQuery);
        }

    }
}
