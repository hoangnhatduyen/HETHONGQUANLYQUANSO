using HETHONGQUANLYQUANSO.Data;
using HETHONGQUANLYQUANSO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace HETHONGQUANLYQUANSO.Controllers
{
    public class QuanNhanController : Controller
    {
        HETHONGQUANLYQUANSOContext HTQLQSContext = new HETHONGQUANLYQUANSOContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Update()
        {

            var quanNhanList = HTQLQSContext.QuanNhans.ToList();
            return View(quanNhanList);

        }
        [HttpPost]
        public IActionResult AddQuanNhan(QuanNhan quanNhan)
        {
            try
            {
                // Kiểm tra xem quanNhan đã tồn tại trong cơ sở dữ liệu chưa
                var existingQuanNhan = HTQLQSContext.QuanNhans.SingleOrDefault(q => q.MaQuanNhan == quanNhan.MaQuanNhan);

                if (existingQuanNhan == null)
                {
                    HTQLQSContext.QuanNhans.Add(quanNhan);
                    HTQLQSContext.SaveChanges();
                    return Json(new { success = true, message = "Thêm quân nhân thành công!" });
                }
                else
                {
                    return Json(new { success = false, message = "Mã quân nhân đã tồn tại trong cơ sở dữ liệu!" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Lỗi khi thêm quân nhân: " + ex.Message });
            }
        }


        [HttpPost]
        public IActionResult UpdateQuanNhan(QuanNhan quanNhan)
        {
            try
            {
                // Kiểm tra xem quanNhan có tồn tại trong cơ sở dữ liệu không
                var existingQuanNhan = HTQLQSContext.QuanNhans.SingleOrDefault(q => q.MaQuanNhan == quanNhan.MaQuanNhan);

                if (existingQuanNhan != null)
                {
                    // Cập nhật thông tin quân nhân
                    existingQuanNhan.HoVaTen = quanNhan.HoVaTen;
                    existingQuanNhan.CapBac = quanNhan.CapBac;
                    existingQuanNhan.MaChucVu = quanNhan.MaChucVu;
                    existingQuanNhan.MaDonVi = quanNhan.MaDonVi;
                    existingQuanNhan.GhiChu = quanNhan.GhiChu;

                    HTQLQSContext.SaveChanges();
                    return Json(new { success = true, message = "Cập nhật thông tin quân nhân thành công!" });
                }
                else
                {
                    return Json(new { success = false, message = "Không tìm thấy quân nhân có mã " + quanNhan.MaQuanNhan });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Lỗi khi cập nhật quân nhân: " + ex.Message });
            }
        }

        [HttpPost]
        public IActionResult DeleteQuanNhan(string maQuanNhan)
        {
            try
            {
                // Kiểm tra xem quanNhan có tồn tại trong cơ sở dữ liệu không
                var existingQuanNhan = HTQLQSContext.QuanNhans.SingleOrDefault(q => q.MaQuanNhan == maQuanNhan);

                if (existingQuanNhan != null)
                {
                    // Xóa quân nhân
                    HTQLQSContext.QuanNhans.Remove(existingQuanNhan);
                    HTQLQSContext.SaveChanges();
                    return Json(new { success = true, message = "Xóa quân nhân thành công!" });
                }
                else
                {
                    return Json(new { success = false, message = "Không tìm thấy quân nhân có mã " + maQuanNhan });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Lỗi khi xóa quân nhân: " + ex.Message });
            }
        }


        [HttpPost]
        public IActionResult ProcessData(QuanNhan quanNhan, string action)
        {
            switch (action)
            {
                case "them":
                    // Xử lý logic thêm quân nhân
                    AddQuanNhan(quanNhan);
                    break;

                case "sua":
                    // Xử lý logic sửa quân nhân
                    UpdateQuanNhan(quanNhan);
                    break;

                case "xoa":
                    DeleteQuanNhan(quanNhan.MaQuanNhan);
                    break;

                    // Các trường hợp khác nếu cần
            }

            return RedirectToAction("Update");
        }


        public IActionResult Search()
        {
            HETHONGQUANLYQUANSOContext HTQLQSContext = new HETHONGQUANLYQUANSOContext();
            var quanNhanList = HTQLQSContext.QuanNhans.ToList();
            return View(quanNhanList);
        }

        public IActionResult Statistics()
        {
            HETHONGQUANLYQUANSOContext HTQLQSContext = new HETHONGQUANLYQUANSOContext();
            var quanNhanList = HTQLQSContext.QuanNhans.ToList();
            return View(quanNhanList);
        }
    }
}
