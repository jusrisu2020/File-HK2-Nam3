using CreateXtraReport.DAL;
using CreateXtraReport.Reportings;
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

namespace CreateXtraReport
{
    public partial class FThongKeKetQuaSinhVien : Form
    {
        public FThongKeKetQuaSinhVien()
        {
            InitializeComponent();
        }

        private void FThongKeKetQuaSinhVien_Load(object sender, EventArgs e)
        {
            HienThiThongKeDiemSinhVien();
            this.rpvThongKeDiem.RefreshReport();
        }

        private void HienThiThongKeDiemSinhVien()
        {
            using(var dbContext = new QuanLySinhVienDBContext())
            {
                string truyvan = "select sv.MaSV, TenSV, TenMH, Diem " +
                                 "from MonHoc as m, SinhVien as sv, SinhVienDiem as svd " +
                                 "where m.MaMH = svd.MaMH and sv.MaSV= svd.MaSV";

                List<ThongKeDiem> danhsach = dbContext.Database.SqlQuery<ThongKeDiem>(truyvan).ToList();

                if(txtHoten.Text != "")
                {
                    danhsach = danhsach.Where(sv => sv.TenSV.ToLower() == txtHoten.Text.ToLower()).ToList();
                }

                this.rpvThongKeDiem.LocalReport.ReportPath = "ReportKetQuaSinhVien.rdlc";
                var reportDataSource = new ReportDataSource("ThongKeDiemDataSet", danhsach);
                this.rpvThongKeDiem.LocalReport.DataSources.Clear();
                this.rpvThongKeDiem.LocalReport.DataSources.Add(reportDataSource);
                this.rpvThongKeDiem.RefreshReport();
            }
        }
        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            HienThiThongKeDiemSinhVien();
        }
    }
}
