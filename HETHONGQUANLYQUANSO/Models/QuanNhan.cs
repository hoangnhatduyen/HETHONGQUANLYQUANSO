namespace HETHONGQUANLYQUANSO.Models
{
    public partial class QuanNhan
    {
        public QuanNhan()
        {
            BaoCaoQuanSos = new HashSet<BaoCaoQuanSo>();
            ChiTietQuanSoVangs = new HashSet<ChiTietQuanSoVang>();
            ThongBaos = new HashSet<ThongBao>();
        }

        public string MaQuanNhan { get; set; } = null!;
        public string? MaChucVu { get; set; }
        public string? MaDonVi { get; set; }
        public string? HoVaTen { get; set; }
        public string? CapBac { get; set; }
        public string? GhiChu { get; set; }
        public string? MaLoaiQuanNhan { get; set; }

        public virtual ChucVu? MaChucVuNavigation { get; set; }
        public virtual DonVi? MaDonViNavigation { get; set; }
        public virtual LoaiQuanNhan? MaLoaiQuanNhanNavigation { get; set; }
        public virtual ICollection<BaoCaoQuanSo> BaoCaoQuanSos { get; set; }
        public virtual ICollection<ChiTietQuanSoVang> ChiTietQuanSoVangs { get; set; }
        public virtual ICollection<ThongBao> ThongBaos { get; set; }
    }
}
