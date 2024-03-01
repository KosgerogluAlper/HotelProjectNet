using Microsoft.AspNetCore.Mvc;

namespace HotelProjectNetWebUI.ViewComponents.Default
{
    public class _TrailerPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
