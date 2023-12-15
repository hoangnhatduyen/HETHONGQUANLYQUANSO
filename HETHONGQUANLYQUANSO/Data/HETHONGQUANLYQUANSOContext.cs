using HETHONGQUANLYQUANSO.Models;
using Microsoft.EntityFrameworkCore;

namespace HETHONGQUANLYQUANSO.Data
{
    public partial class HETHONGQUANLYQUANSOContext : DbContext
    {
        public HETHONGQUANLYQUANSOContext()
        {
        }

        public HETHONGQUANLYQUANSOContext(DbContextOptions<HETHONGQUANLYQUANSOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaoCaoQuanSo> BaoCaoQuanSos { get; set; } = null!;
        public virtual DbSet<ChiTietQuanSoVang> ChiTietQuanSoVangs { get; set; } = null!;
        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<DonVi> DonVis { get; set; } = null!;
        public virtual DbSet<LoaiQuanNhan> LoaiQuanNhans { get; set; } = null!;
        public virtual DbSet<LyDo> LyDos { get; set; } = null!;
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; } = null!;
        public virtual DbSet<NhomNguoiDung> NhomNguoiDungs { get; set; } = null!;
        public virtual DbSet<QuanNhan> QuanNhans { get; set; } = null!;
        public virtual DbSet<ThongBao> ThongBaos { get; set; } = null!;
        public virtual DbSet<TongHopVang> TongHopVangs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LTT;Initial Catalog=HETHONGQUANLYQUANSO;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoCaoQuanSo>(entity =>
            {
                entity.HasKey(e => e.MaBaoCao)
                    .HasName("PK__BAOCAOQU__25A9188CE8A21349");

                entity.ToTable("BaoCaoQuanSo");

                entity.Property(e => e.MaBaoCao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaDonVi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngay).HasColumnType("date");

                entity.Property(e => e.NguoiDuyet)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaDonViNavigation)
                    .WithMany(p => p.BaoCaoQuanSos)
                    .HasForeignKey(d => d.MaDonVi)
                    .HasConstraintName("fk4");

                entity.HasOne(d => d.NguoiDuyetNavigation)
                    .WithMany(p => p.BaoCaoQuanSos)
                    .HasForeignKey(d => d.NguoiDuyet)
                    .HasConstraintName("fk7");
            });

            modelBuilder.Entity<ChiTietQuanSoVang>(entity =>
            {
                entity.HasKey(e => e.MaChiTiet)
                    .HasName("PK__CHITIETQ__CDF0A11466B2358D");

                entity.ToTable("ChiTietQuanSoVang");

                entity.Property(e => e.MaChiTiet)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaBaoCao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaLyDo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaQuanNhan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaBaoCaoNavigation)
                    .WithMany(p => p.ChiTietQuanSoVangs)
                    .HasForeignKey(d => d.MaBaoCao)
                    .HasConstraintName("fk5");

                entity.HasOne(d => d.MaLyDoNavigation)
                    .WithMany(p => p.ChiTietQuanSoVangs)
                    .HasForeignKey(d => d.MaLyDo)
                    .HasConstraintName("fk9");

                entity.HasOne(d => d.MaQuanNhanNavigation)
                    .WithMany(p => p.ChiTietQuanSoVangs)
                    .HasForeignKey(d => d.MaQuanNhan)
                    .HasConstraintName("fk6");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.MaChucVu)
                    .HasName("PK__CHUCVU__D46395336FC4CF91");

                entity.ToTable("ChucVu");

                entity.Property(e => e.MaChucVu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenChucVu).HasMaxLength(50);
            });

            modelBuilder.Entity<DonVi>(entity =>
            {
                entity.HasKey(e => e.MaDonVi)
                    .HasName("PK__DONVI__DDA5A6CF2460BB4B");

                entity.ToTable("DonVi");

                entity.Property(e => e.MaDonVi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenDonVi).HasMaxLength(50);
            });

            modelBuilder.Entity<LoaiQuanNhan>(entity =>
            {
                entity.HasKey(e => e.MaLoaiQuanNhan)
                    .HasName("PK__LOAIQUAN__4CE0F74AA53F0F67");

                entity.ToTable("LoaiQuanNhan");

                entity.Property(e => e.MaLoaiQuanNhan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenLoaiQuanNhan).HasMaxLength(50);
            });

            modelBuilder.Entity<LyDo>(entity =>
            {
                entity.HasKey(e => e.MaLyDo)
                    .HasName("PK_LYDO");

                entity.ToTable("LyDo");

                entity.Property(e => e.MaLyDo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.HasKey(e => e.TenDangNhap)
                    .HasName("PK_TAIKHOAN_1");

                entity.ToTable("NguoiDung");

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaNhom)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaNhomNavigation)
                    .WithMany(p => p.NguoiDungs)
                    .HasForeignKey(d => d.MaNhom)
                    .HasConstraintName("fk8");
            });

            modelBuilder.Entity<NhomNguoiDung>(entity =>
            {
                entity.HasKey(e => e.MaNhom)
                    .HasName("PK_NHOMNGUOIDUNG");

                entity.ToTable("NhomNguoiDung");

                entity.Property(e => e.MaNhom)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenNhom).HasMaxLength(50);
            });

            modelBuilder.Entity<QuanNhan>(entity =>
            {
                entity.HasKey(e => e.MaQuanNhan)
                    .HasName("PK__QUANNHAN__95034100ACEFC4BC");

                entity.ToTable("QuanNhan");

                entity.Property(e => e.MaQuanNhan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CapBac).HasMaxLength(50);

                entity.Property(e => e.HoVaTen).HasMaxLength(50);

                entity.Property(e => e.MaChucVu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaDonVi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaLoaiQuanNhan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.QuanNhans)
                    .HasForeignKey(d => d.MaChucVu)
                    .HasConstraintName("fk1");

                entity.HasOne(d => d.MaDonViNavigation)
                    .WithMany(p => p.QuanNhans)
                    .HasForeignKey(d => d.MaDonVi)
                    .HasConstraintName("fk2");

                entity.HasOne(d => d.MaLoaiQuanNhanNavigation)
                    .WithMany(p => p.QuanNhans)
                    .HasForeignKey(d => d.MaLoaiQuanNhan)
                    .HasConstraintName("fk3");
            });

            modelBuilder.Entity<ThongBao>(entity =>
            {
                entity.HasKey(e => e.MaThongBao)
                    .HasName("PK__THONGBAO__04DEB54EBBC7D78C");

                entity.ToTable("ThongBao");

                entity.Property(e => e.MaThongBao)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaDonVi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngay).HasColumnType("date");

                entity.Property(e => e.NguoiViet)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaDonViNavigation)
                    .WithMany(p => p.ThongBaos)
                    .HasForeignKey(d => d.MaDonVi)
                    .HasConstraintName("fk11");

                entity.HasOne(d => d.NguoiVietNavigation)
                    .WithMany(p => p.ThongBaos)
                    .HasForeignKey(d => d.NguoiViet)
                    .HasConstraintName("fk10");
            });

            modelBuilder.Entity<TongHopVang>(entity =>
            {
                entity.HasKey(e => new { e.MaDonVi, e.MaLyDo })
                    .HasName("PK_TONGHOPVANG");

                entity.ToTable("TongHopVang");

                entity.Property(e => e.MaDonVi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaLyDo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngay).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
