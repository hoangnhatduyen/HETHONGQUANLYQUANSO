using HETHONGQUANLYQUANSO.Data;
using Microsoft.AspNetCore.Mvc;
using HETHONGQUANLYQUANSO.Models;
using Microsoft.EntityFrameworkCore;

namespace HETHONGQUANLYQUANSO.Controllers
{
    public class BaoCaoQuanSoController : Controller
    {
        HETHONGQUANLYQUANSOContext HTQLQSContext = new HETHONGQUANLYQUANSOContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BaoCaoQuanSoNgay()
        {
            var baoCaoQuanSoNgayList = HTQLQSContext.BaoCaoQuanSos.ToList();
            return View(baoCaoQuanSoNgayList);
        }

        [HttpPost]
        public IActionResult ThemBaoCao(BaoCaoQuanSo baoCaoQuanSo)
        {
            try
            {
                // Kiểm tra xem baoCaoQuanSo đã tồn tại trong cơ sở dữ liệu chưa
                var existingBaoCao = HTQLQSContext.BaoCaoQuanSos.SingleOrDefault(b => b.MaBaoCao == baoCaoQuanSo.MaBaoCao);

                if (existingBaoCao == null)
                {
                    HTQLQSContext.BaoCaoQuanSos.Add(baoCaoQuanSo);
                    HTQLQSContext.SaveChanges();
                    return Json(new { success = true, message = "Thêm thành công" });
                }
                else
                    return Json(new { success = false, message = "Báo cáo đã tồn tại" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Lỗi: " + ex.Message });
            }
        }

        [HttpPost]
        public IActionResult SuaBaoCao(BaoCaoQuanSo baoCaoQuanSo)
        {
            try
            {
                var existingBaoCao = HTQLQSContext.BaoCaoQuanSos.SingleOrDefault(b => b.MaBaoCao == baoCaoQuanSo.MaBaoCao);

                if (existingBaoCao != null)
                {
                    existingBaoCao.MaDonVi = baoCaoQuanSo.MaDonVi;
                    existingBaoCao.TongQuanSo = baoCaoQuanSo.TongQuanSo;
                    existingBaoCao.CoMat = baoCaoQuanSo.CoMat;
                    existingBaoCao.Vang = baoCaoQuanSo.Vang;
                    existingBaoCao.NguoiDuyet = baoCaoQuanSo.NguoiDuyet;
                    existingBaoCao.Ngay = baoCaoQuanSo.Ngay;

                    HTQLQSContext.SaveChanges();

                    return Json(new { success = true, message = "Sửa thành công" });
                }
                else
                    return Json(new { success = false, message = "Báo cáo không tồn tại" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Lỗi: " + ex.Message });
            }
        }

        [HttpPost]
        public IActionResult XoaBaoCao(string maBaoCao)
        {
            try
            {
                var existingBaoCao = HTQLQSContext.BaoCaoQuanSos.SingleOrDefault(b => b.MaBaoCao == maBaoCao);

                if (existingBaoCao != null)
                {
                    HTQLQSContext.BaoCaoQuanSos.Remove(existingBaoCao);
                    HTQLQSContext.SaveChanges();

                    return Json(new { success = true, message = "Xóa thành công" });
                }
                else
                    return Json(new { success = false, message = "Báo cáo không tồn tại" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Lỗi: " + ex.Message });
            }
        }

        [HttpPost]
        public IActionResult ProcessData(BaoCaoQuanSo baoCaoQuanSo, string action)
        {
            switch (action)
            {
                case "them":

                    ThemBaoCao(baoCaoQuanSo);
                    break;

                case "sua":

                    SuaBaoCao(baoCaoQuanSo);
                    break;

                case "xoa":

                    XoaBaoCao(baoCaoQuanSo.MaBaoCao);
                    break;
            }

            return RedirectToAction("BaoCaoQuanSoNgay");
        }

        public IActionResult ChiTietQuanSoVang()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Statistics()
        {
            return View();
        }
    }
}
