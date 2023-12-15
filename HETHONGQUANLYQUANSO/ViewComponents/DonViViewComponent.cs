using Microsoft.AspNetCore.Mvc;

namespace HETHONGQUANLYQUANSO.ViewComponents
{
    public class DonViViewComponent : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}