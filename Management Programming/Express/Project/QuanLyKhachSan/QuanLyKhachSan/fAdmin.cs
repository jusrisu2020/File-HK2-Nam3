using QuanLyKhachSan.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            GetListAccount();
        }
        void GetListAccount()
        {
            string query = "select * from dbo.Account";
            dtgvAccount.DataSource = Dataprovider.Instance.Excutequery(query);

        }
        
    }
}
