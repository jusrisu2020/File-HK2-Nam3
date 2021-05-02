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
        void ShowThietBiTrongBoPhan(int id)
        {
            
        }

        void LoadBtnBoPhan()
        {
            List<BoPhanDTO> BoPhanList = BoPhanDAO.Instance.LoadBoPhan();
            foreach (BoPhanDTO item in BoPhanList)
            {
                Button btn = new Button() { Width = 150, Height = 100 };
                flpBtnBoPhan.Controls.Add(btn);
                btn.Click += btnClick;
                btn.Tag = item;
                btn.Text = item.MaBP +"\n"+ item.TenBP;
                btn.Image = Image.FromFile(@"D:\File-HK2-Nam3\Management Programming\PersonalProject\Winform\QLTSTBKhachSan\QLTSTBKhachSan\Resources\department_50px.png");
                btn.ImageAlign = ContentAlignment.MiddleCenter;
                btn.TextAlign = ContentAlignment.TopCenter;
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            int BoPhanID = ((sender as Button).Tag as BoPhanDTO).ID;
            ShowThietBiTrongBoPhan(BoPhanID);
        }
    }
}
