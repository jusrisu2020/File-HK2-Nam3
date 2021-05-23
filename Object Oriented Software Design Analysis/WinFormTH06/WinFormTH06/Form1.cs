using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormTH06.DAO;
using WinFormTH06.DTO;

namespace WinFormTH06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Cửa hàng tự chọn TUTI\nĐiện thoại: 076-3841190\nĐịa Chỉ: 710, Hà Hoàng Hổ";
            dtgvMyPham.DataSource = LoadMyPham();
        }

        List<MatHangDTO> LoadMyPham()
        {
            string Query = "SELECT * FROM MAT_HANG;";
            List<MatHangDTO> MatHangList = new List<MatHangDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(Query);
            foreach (DataRow item in data.Rows)
            {
                MatHangDTO table = new MatHangDTO(item);
                MatHangList.Add(table);
            }
            return MatHangList;    
        }
    }
}
