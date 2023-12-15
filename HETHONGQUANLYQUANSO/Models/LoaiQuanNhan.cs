namespace HETHONGQUANLYQUANSO.Models
{
    public partial class LoaiQuanNhan
    {
        public LoaiQuanNhan()
        {
            QuanNhans = new HashSet<QuanNhan>();
        }

        public string MaLoaiQuanNhan { get; set; } = null!;
        public string? TenLoaiQuanNhan { get; set; }

        public virtual ICollection<QuanNhan> QuanNhans { get; set; }
    }
}
