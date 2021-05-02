using QLTSTBKhachSan.DAO;
using QLTSTBKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTSTBKhachSan.UI
{
    public partial class UCQuanLyThietBi : UserControl
    {
        public UCQuanLyThietBi()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            LoadBtnBoPhan();
        }
        void ShowThietBiTrongBoPhan(string mabp)
        {
            List<ThietBiDTO> tb = ThietBiDAO.Instance.LoadThietBiTrongBoPhan(mabp);
            dtgvThietBi.DataSource = tb;
            dtgvThietBi.Columns["id"].Visible = false;
        }

        void LoadBtnBoPhan()
        {
            List<BoPhanDTO> BoPhanList = BoPhanDAO.Instance.LoadBoPhan();
            foreach (BoPhanDTO item in BoPhanList)
            {
                Button btn = new Button() { Width = 120, Height = 80 };
                flpBtnBoPhan.Controls.Add(btn);
                btn.Click += btnClick;
                btn.Tag = item;
                btn.Text = item.MaBP +"\n"+ item.TenBP;
                btn.Image = Image.FromFile(@"D:\File-HK2-Nam3\Management Programming\PersonalProject\Winform\QLTSTBKhachSan\QLTSTBKhachSan\Resources\department_50px.png");
                btn.ImageAlign = ContentAlignment.BottomCenter;
                btn.TextAlign = ContentAlignment.TopCenter;
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            string mabp = ((sender as Button).Tag as BoPhanDTO).MaBP;
            ShowThietBiTrongBoPhan(mabp);
        }

        
    }
}
