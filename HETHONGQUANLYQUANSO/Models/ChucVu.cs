namespace HETHONGQUANLYQUANSO.Models
{
    public partial class ChucVu
    {
        public ChucVu()
        {
            QuanNhans = new HashSet<QuanNhan>();
        }

        public string MaChucVu { get; set; } = null!;
        public string? TenChucVu { get; set; }

        public virtual ICollection<QuanNhan> QuanNhans { get; set; }
    }
}
