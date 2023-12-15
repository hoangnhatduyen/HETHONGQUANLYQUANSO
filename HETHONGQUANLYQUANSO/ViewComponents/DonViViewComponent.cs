using Microsoft.AspNetCore.Mvc;
namespace HETHONGQUANLYQUANSO.ViewComponents
{
    public class DonViViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Logic của bạn ở đây
            return View();
        }
    }
}
