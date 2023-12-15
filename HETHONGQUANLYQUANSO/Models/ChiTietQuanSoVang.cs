namespace HETHONGQUANLYQUANSO.Models
{
    public partial class ChiTietQuanSoVang
    {
        public string MaChiTiet { get; set; } = null!;
        public string? MaBaoCao { get; set; }
        public string? MaQuanNhan { get; set; }
        public string? MaLyDo { get; set; }
        public string? GhiChu { get; set; }

        public virtual BaoCaoQuanSo? MaBaoCaoNavigation { get; set; }
        public virtual LyDo? MaLyDoNavigation { get; set; }
        public virtual QuanNhan? MaQuanNhanNavigation { get; set; }
    }
}
