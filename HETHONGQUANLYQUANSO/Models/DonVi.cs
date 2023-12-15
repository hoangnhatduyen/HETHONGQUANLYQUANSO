namespace HETHONGQUANLYQUANSO.Models
{
    public partial class DonVi
    {
        public DonVi()
        {
            BaoCaoQuanSos = new HashSet<BaoCaoQuanSo>();
            QuanNhans = new HashSet<QuanNhan>();
            ThongBaos = new HashSet<ThongBao>();
        }

        public string MaDonVi { get; set; } = null!;
        public string? TenDonVi { get; set; }
        public string? GhiChu { get; set; }

        public virtual ICollection<BaoCaoQuanSo> BaoCaoQuanSos { get; set; }
        public virtual ICollection<QuanNhan> QuanNhans { get; set; }
        public virtual ICollection<ThongBao> ThongBaos { get; set; }
    }
}
