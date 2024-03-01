using Microsoft.AspNetCore.Mvc;

namespace HotelProjectNetWebUI.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
