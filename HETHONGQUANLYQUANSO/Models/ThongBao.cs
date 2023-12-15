namespace HETHONGQUANLYQUANSO.Models
{
    public partial class ThongBao
    {
        public string MaThongBao { get; set; } = null!;
        public string? TenThongBao { get; set; }
        public string? NoiDung { get; set; }
        public string? MaDonVi { get; set; }
        public string? NguoiViet { get; set; }
        public DateTime? Ngay { get; set; }

        public virtual DonVi? MaDonViNavigation { get; set; }
        public virtual QuanNhan? NguoiVietNavigation { get; set; }
    }
}
