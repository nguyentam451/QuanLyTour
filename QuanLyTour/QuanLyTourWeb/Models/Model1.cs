using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyTourWeb.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=QuanLyTourDataContext")
        {
        }

        public virtual DbSet<CHIPHI> CHIPHI { get; set; }
        public virtual DbSet<DIADIEM> DIADIEM { get; set; }
        public virtual DbSet<DOANDULICH> DOANDULICH { get; set; }
        public virtual DbSet<GIATOUR> GIATOUR { get; set; }
        public virtual DbSet<KHACH> KHACH { get; set; }
        public virtual DbSet<LOAICHIPHI> LOAICHIPHI { get; set; }
        public virtual DbSet<LOAIHINHDULICH> LOAIHINHDULICH { get; set; }
        public virtual DbSet<NOIDUNGTOUR> NOIDUNGTOUR { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<PHANBONHANVIEN_DOAN> PHANBONHANVIEN_DOAN { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TOURDULICH> TOURDULICH { get; set; }
        public virtual DbSet<THAMQUAN> THAMQUAN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHIPHI>()
                .Property(e => e.MaChiPhi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHIPHI>()
                .Property(e => e.MaDoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHIPHI>()
                .Property(e => e.MaLoaiChiPhi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DIADIEM>()
                .Property(e => e.MaDiaDiem)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DIADIEM>()
                .HasMany(e => e.THAMQUAN)
                .WithRequired(e => e.DIADIEM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOANDULICH>()
                .Property(e => e.MaDoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DOANDULICH>()
                .Property(e => e.MaTour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DOANDULICH>()
                .HasOptional(e => e.NOIDUNGTOUR)
                .WithRequired(e => e.DOANDULICH);

            modelBuilder.Entity<DOANDULICH>()
                .HasMany(e => e.PHANBONHANVIEN_DOAN)
                .WithRequired(e => e.DOANDULICH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOANDULICH>()
                .HasMany(e => e.KHACH)
                .WithMany(e => e.DOANDULICH)
                .Map(m => m.ToTable("CHITIETDOAN").MapLeftKey("MaDoan").MapRightKey("MaKhachHang"));

            modelBuilder.Entity<GIATOUR>()
                .Property(e => e.MaGia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIATOUR>()
                .Property(e => e.MaTour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACH>()
                .Property(e => e.MaKhachHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACH>()
                .Property(e => e.SoCMND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACH>()
                .Property(e => e.GioiTinh)
                .IsFixedLength();

            modelBuilder.Entity<KHACH>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAICHIPHI>()
                .Property(e => e.MaLoaiChiPhi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAIHINHDULICH>()
                .Property(e => e.MaLoaiHinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NOIDUNGTOUR>()
                .Property(e => e.MaDoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHANBONHANVIEN_DOAN)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHANBONHANVIEN_DOAN>()
                .Property(e => e.MaNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHANBONHANVIEN_DOAN>()
                .Property(e => e.MaDoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TOURDULICH>()
                .Property(e => e.MaTour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TOURDULICH>()
                .Property(e => e.MaLoaiHinh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TOURDULICH>()
                .HasMany(e => e.THAMQUAN)
                .WithRequired(e => e.TOURDULICH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THAMQUAN>()
                .Property(e => e.MaTour)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THAMQUAN>()
                .Property(e => e.MaDiaDiem)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
