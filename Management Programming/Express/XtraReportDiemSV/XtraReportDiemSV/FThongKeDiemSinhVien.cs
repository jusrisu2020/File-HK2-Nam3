using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XtraReportDiemSV.DAL;
using XtraReportDiemSV.Reportings;

namespace XtraReportDiemSV
{
    public partial class FThongKeDiemSinhVien : Form
    {
        public FThongKeDiemSinhVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
            this.rpvThongKeDiemSV.RefreshReport();
        }

        private void HienThiThongTin()
        {
            using (var dbContext = new QuanLySinhVienDBContext())
            {
                string truyvan = "select sv.MaSV, TenSV, TenMH, Diem " +
                                 "from MonHoc as m, SinhVien as sv, SinhVienDiem as svd " +
                                 "where m.MaMH = svd.MaMH and sv.MaSV= svd.MaSV";

                List<ThongKeDiem> danhsach = dbContext.Database.SqlQuery<ThongKeDiem>(truyvan).ToList();

                if (txtHoten.Text != "")
                {
                    danhsach = danhsach.Where(sv => sv.TenSV.ToLower() == txtHoten.Text.ToLower()).ToList();
                }

                this.rpvThongKeDiemSV.LocalReport.ReportPath = "ReportKetQuaSinhVien.rdlc";
                var reportDataSource = new ReportDataSource("ThongKeDiemDataSet", danhsach);
                this.rpvThongKeDiemSV.LocalReport.DataSources.Clear();
                this.rpvThongKeDiemSV.LocalReport.DataSources.Add(reportDataSource);
                this.rpvThongKeDiemSV.RefreshReport();
            }
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            HienThiThongTin();
        }
    }
}
