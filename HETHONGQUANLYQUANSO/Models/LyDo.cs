namespace HETHONGQUANLYQUANSO.Models
{
    public partial class LyDo
    {
        public LyDo()
        {
            ChiTietQuanSoVangs = new HashSet<ChiTietQuanSoVang>();
        }

        public string MaLyDo { get; set; } = null!;
        public string? TenLyDo { get; set; }

        public virtual ICollection<ChiTietQuanSoVang> ChiTietQuanSoVangs { get; set; }
    }
}
