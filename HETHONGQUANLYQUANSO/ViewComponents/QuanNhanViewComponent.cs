using Microsoft.AspNetCore.Mvc;

namespace HETHONGQUANLYQUANSO.ViewComponents
{
    public class QuanNhanViewComponent : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
