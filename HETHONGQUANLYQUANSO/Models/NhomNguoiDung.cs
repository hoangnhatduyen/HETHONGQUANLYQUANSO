namespace HETHONGQUANLYQUANSO.Models
{
    public partial class NhomNguoiDung
    {
        public NhomNguoiDung()
        {
            NguoiDungs = new HashSet<NguoiDung>();
        }

        public string MaNhom { get; set; } = null!;
        public string? TenNhom { get; set; }

        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
