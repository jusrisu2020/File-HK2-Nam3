namespace CreateXtraReport.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLySinhVienDBContext : DbContext
    {
        public QuanLySinhVienDBContext()
            : base("name=QuanLySinhVienDBContext1")
        {
        }

        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<SinhVienDiem> SinhVienDiems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.SinhVienDiems)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.SinhVienDiems)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);
        }
    }
}
