using Microsoft.AspNetCore.Mvc;

namespace HETHONGQUANLYQUANSO.Controllers
{
    public class BaoCaoQuanSoController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
