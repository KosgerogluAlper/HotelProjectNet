using Microsoft.AspNetCore.Mvc;

namespace HotelProjectNetWebUI.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
