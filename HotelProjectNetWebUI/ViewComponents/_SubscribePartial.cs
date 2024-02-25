using Microsoft.AspNetCore.Mvc;

namespace HotelProjectNetWebUI.Default
{
    public class _SubscribePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
