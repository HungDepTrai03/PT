using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PRL.DomainClass;

namespace PRL.Context
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DatLich1> DatLiches { get; set; } = null!;
        public virtual DbSet<DatLichChiTiet> DatLichChiTiets { get; set; } = null!;
        public virtual DbSet<DichVu> DichVus { get; set; } = null!;
        public virtual DbSet<GiamGium> GiamGia { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<HopDong> HopDongs { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<LichLamViec> LichLamViecs { get; set; } = null!;
        public virtual DbSet<LoaiThietBi> LoaiThietBis { get; set; } = null!;
        public virtual DbSet<NhanVien11> NhanViens { get; set; } = null!;
        public virtual DbSet<PhieuThongKe> PhieuThongKes { get; set; } = null!;
        public virtual DbSet<PhuongThucThanhToan> PhuongThucThanhToans { get; set; } = null!;
        public virtual DbSet<Pt> Pts { get; set; } = null!;
        public virtual DbSet<ThanhToan> ThanhToans { get; set; } = null!;
        public virtual DbSet<ThietBi> ThietBis { get; set; } = null!;
        public virtual DbSet<ThongKeThietBi> ThongKeThietBis { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=HHUNGDZ\\SQLEXPRESS;Initial Catalog=GYMDB1;Integrated Security=True;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatLich1>(entity =>
            {
                entity.HasKey(e => e.MaPhieuDatLich)
                    .HasName("PK__DatLich__B0D4EED28BDFA92C");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.DatLiches)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DatLich__NgayDat__628FA481");
            });

            modelBuilder.Entity<DatLichChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaDatLichCt)
                    .HasName("PK__DatLichC__32FD8C054A5ADC4B");

                entity.HasOne(d => d.MaPhieuDatLichNavigation)
                    .WithMany(p => p.DatLichChiTiets)
                    .HasForeignKey(d => d.MaPhieuDatLich)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DatLichCh__GhiCh__656C112C");
            });

            modelBuilder.Entity<DichVu>(entity =>
            {
                entity.HasKey(e => e.MaDichVu)
                    .HasName("PK__DichVu__C0E6DE8FEBA391B8");

                entity.HasOne(d => d.MaHopDongNavigation)
                    .WithMany(p => p.DichVus)
                    .HasForeignKey(d => d.MaHopDong)
                    .HasConstraintName("FK__DichVu__GhiChu__4E88ABD4");
            });

            modelBuilder.Entity<GiamGium>(entity =>
            {
                entity.HasKey(e => e.MaGiamGia)
                    .HasName("PK__GiamGia__EF9458E434FB5020");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HoaDon__835ED13BAEEC41D9");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__MaKhachH__571DF1D5");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__TrangTha__5629CD9C");

                entity.HasOne(d => d.MaThanhToanNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaThanhToan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__MaThanhT__5812160E");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaHoaDonCt)
                    .HasName("PK__HoaDonCH__38C56E64804BA29C");

                entity.HasOne(d => d.MaDichVuNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaDichVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonCHi__MaDic__5BE2A6F2");

                entity.HasOne(d => d.MaGiamGiaNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaGiamGia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonCHi__MaGia__5CD6CB2B");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonCHi__MaDic__5AEE82B9");
            });

            modelBuilder.Entity<HopDong>(entity =>
            {
                entity.HasKey(e => e.MaHopDong)
                    .HasName("PK__HopDong__36DD434263E76899");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.HopDongs)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HopDong__NgayKet__4AB81AF0");

                entity.HasOne(d => d.MaPtNavigation)
                    .WithMany(p => p.HopDongs)
                    .HasForeignKey(d => d.MaPt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HopDong__MaPT__4BAC3F29");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK__KhachHan__88D2F0E50713072D");
            });

            modelBuilder.Entity<LichLamViec>(entity =>
            {
                entity.HasKey(e => e.MaLich)
                    .HasName("PK__LichLamV__728A9AE948C3EBDD");

                entity.HasOne(d => d.MaPtNavigation)
                    .WithMany(p => p.LichLamViecs)
                    .HasForeignKey(d => d.MaPt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichLamVie__MaPT__5FB337D6");
            });

            modelBuilder.Entity<LoaiThietBi>(entity =>
            {
                entity.HasKey(e => e.MaLoaiThietBi)
                    .HasName("PK__LoaiThie__3C8A37283B09DBBC");
            });

            modelBuilder.Entity<NhanVien11>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__77B2CA47A4C65C06");
            });

            modelBuilder.Entity<PhieuThongKe>(entity =>
            {
                entity.HasKey(e => e.MaPhieu)
                    .HasName("PK__PhieuTho__2660BFE015C40261");
            });

            modelBuilder.Entity<PhuongThucThanhToan>(entity =>
            {
                entity.HasKey(e => e.MaPhuongThuc)
                    .HasName("PK__PhuongTh__35F7404E7E7B9E4F");
            });

            modelBuilder.Entity<Pt>(entity =>
            {
                entity.HasKey(e => e.MaPt)
                    .HasName("PK__PT__2725E7F6EBE06C8B");
            });

            modelBuilder.Entity<ThanhToan>(entity =>
            {
                entity.HasKey(e => e.MaThanhToan)
                    .HasName("PK__ThanhToa__D4B258443354E6A0");

                entity.HasOne(d => d.MaPhuongThucNavigation)
                    .WithMany(p => p.ThanhToans)
                    .HasForeignKey(d => d.MaPhuongThuc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThanhToan__Trang__534D60F1");
            });

            modelBuilder.Entity<ThietBi>(entity =>
            {
                entity.HasKey(e => e.MaThietBi)
                    .HasName("PK__ThietBi__8AEC71F7A9FCE9AE");

                entity.HasOne(d => d.MaLoaiThietBiNavigation)
                    .WithMany(p => p.ThietBis)
                    .HasForeignKey(d => d.MaLoaiThietBi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThietBi__MaLoaiT__3A81B327");
            });

            modelBuilder.Entity<ThongKeThietBi>(entity =>
            {
                entity.HasKey(e => e.MaPhieuChiTiet)
                    .HasName("PK__ThongKeT__210272B74A1FBAA8");

                entity.HasOne(d => d.MaPhieuNavigation)
                    .WithMany(p => p.ThongKeThietBis)
                    .HasForeignKey(d => d.MaPhieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThongKeTh__NhaCu__3F466844");

                entity.HasOne(d => d.MaThietBiNavigation)
                    .WithMany(p => p.ThongKeThietBis)
                    .HasForeignKey(d => d.MaThietBi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThongKeTh__MaThi__403A8C7D");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdDangNhap)
                    .HasName("PK__Users__A9CE73E7FA1DB328");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
