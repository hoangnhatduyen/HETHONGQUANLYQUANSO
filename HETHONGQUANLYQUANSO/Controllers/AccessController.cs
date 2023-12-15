using HETHONGQUANLYQUANSO.Data;
using HETHONGQUANLYQUANSO.Models;
using Microsoft.AspNetCore.Mvc;

namespace HETHONGQUANLYQUANSO.Controllers
{
    public class AccessController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(NguoiDung nguoiDung)
        {
            HETHONGQUANLYQUANSOContext HTQLQSContext = new HETHONGQUANLYQUANSOContext();
            var userFromDb = HTQLQSContext.NguoiDungs
                .FirstOrDefault(u => u.TenDangNhap == nguoiDung.TenDangNhap && u.MatKhau == nguoiDung.MatKhau);

            if (userFromDb != null)
            {
                // Đăng nhập thành công
                return RedirectToAction("Index", "Admin");
            }
            else
            // Đăng nhập không thành công
            {
                ViewBag.ErrorMessage = "Tên đăng nhập hoặc mật khẩu không đúng";
                return View();
            }
        }
    }
}
