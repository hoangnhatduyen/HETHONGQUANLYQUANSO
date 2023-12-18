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
        public void AddQuanNhan(QuanNhan quanNhan)
        {
            // Kiểm tra xem quanNhan đã tồn tại trong cơ sở dữ liệu chưa
            var existingQuanNhan = HTQLQSContext.QuanNhans.SingleOrDefault(q => q.MaQuanNhan == quanNhan.MaQuanNhan);

            if (existingQuanNhan == null)
            {
                HTQLQSContext.QuanNhans.Add(quanNhan);
                HTQLQSContext.SaveChanges();
            }
            // Lưu thay đổi vào cơ sở dữ liệu

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
                    //QuanNhanController.UpdateQuanNhan(quanNhan);
                    break;

                case "xoa":
                    // Xử lý logic xóa quân nhân
                    //QuanNhanController.DeleteQuanNhan(quanNhan.MaQuanNhan);
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
