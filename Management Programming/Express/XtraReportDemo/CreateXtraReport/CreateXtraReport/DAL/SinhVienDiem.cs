namespace CreateXtraReport.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVienDiem")]
    public partial class SinhVienDiem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int MaSV { get; set; }

        public int MaMH { get; set; }

        public double Diem { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
