using Microsoft.AspNetCore.Mvc;
namespace HETHONGQUANLYQUANSO.ViewComponents
{
    public class ThongBaoViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Logic của bạn ở đây
            return View();
        }

    }
}
