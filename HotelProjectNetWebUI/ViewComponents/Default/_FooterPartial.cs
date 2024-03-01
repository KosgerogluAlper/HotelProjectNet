using Microsoft.AspNetCore.Mvc;

namespace HotelProjectNetWebUI.ViewComponents.Default
{
    public class _FooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
