namespace HETHONGQUANLYQUANSO.Models
{
    public partial class BaoCaoQuanSo
    {
        public BaoCaoQuanSo()
        {
            ChiTietQuanSoVangs = new HashSet<ChiTietQuanSoVang>();
        }

        public string MaBaoCao { get; set; } = null!;
        public string? MaDonVi { get; set; }
        public DateTime? Ngay { get; set; }
        public int? TongQuanSo { get; set; }
        public int? CoMat { get; set; }
        public int? Vang { get; set; }
        public string? NguoiDuyet { get; set; }

        public virtual DonVi? MaDonViNavigation { get; set; }
        public virtual QuanNhan? NguoiDuyetNavigation { get; set; }
        public virtual ICollection<ChiTietQuanSoVang> ChiTietQuanSoVangs { get; set; }
    }
}
