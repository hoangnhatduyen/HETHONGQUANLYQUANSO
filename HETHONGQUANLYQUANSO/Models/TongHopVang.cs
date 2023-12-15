namespace HETHONGQUANLYQUANSO.Models
{
    public partial class TongHopVang
    {
        public string MaDonVi { get; set; } = null!;
        public int? SoLuong { get; set; }
        public string MaLyDo { get; set; } = null!;
        public string? GhiChu { get; set; }
        public DateTime? Ngay { get; set; }
    }
}
