namespace AppPhim.DataAccessLayer.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AppPhimModel : DbContext
    {
        public AppPhimModel()
            : base("name=AppPhimModel")
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHoaDon)
                .WithOptional(e => e.HoaDon)
                .HasForeignKey(e => e.MaHoaDon);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDon)
                .WithRequired(e => e.KhachHang)
                .HasForeignKey(e => e.IdKhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.PassWord)
                .IsUnicode(false);
        }
    }
}
