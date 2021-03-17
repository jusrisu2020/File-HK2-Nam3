using CreateReporting.DatabaseAccessLayer;
using CreateReporting.Reportings;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CreateReporting
{
    public partial class FThongKeDiemSinhVien : Form
    {
        public FThongKeDiemSinhVien()
        {
            InitializeComponent();
        }

        private void FThongKeDiemSinhVien_Load(object sender, EventArgs e)
        {
            HienThiDiemSinhVien();
        }

        private void HienThiDiemSinhVien()
        {
            using (var dbContext = new Model1())
            {
                string SqlTruyVan = "select sv.MaSV, TenSV, TenMH, Diem " +
                                    "from MonHoc as m, SinhVien as sv, SinhVienDiem as svd " +
                                    "where m.MaMH = svd.MaMH and sv.MaSV= svd.MaSV";
                List<ThongKeDiem> danhsach = dbContext.Database.SqlQuery<ThongKeDiem>(SqlTruyVan).ToList();

                if (txtHoTen.Text != "")
                {
                    danhsach = danhsach.Where(sv => sv.TenSV.ToString() == txtHoTen.Text.ToLower()).ToList();
                }

                this.rpvThongKeDiem.LocalReport.ReportPath = "ReportKetQuaSinhVien.rdlc";
                var rpds = new ReportDataSource("ThongKeDiemDataset", danhsach);
                this.rpvThongKeDiem.LocalReport.DataSources.Clear();
                this.rpvThongKeDiem.LocalReport.DataSources.Add(rpds);
                this.rpvThongKeDiem.RefreshReport();
            }
        }


    }
}
