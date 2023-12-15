namespace HETHONGQUANLYQUANSO.Models
{
    public partial class NguoiDung
    {
        public string TenDangNhap { get; set; } = null!;
        public string? MatKhau { get; set; }
        public string? MaNhom { get; set; }

        public virtual NhomNguoiDung? MaNhomNavigation { get; set; }
    }
}
