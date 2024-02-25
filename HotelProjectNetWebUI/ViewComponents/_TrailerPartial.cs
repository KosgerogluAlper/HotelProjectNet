using Microsoft.AspNetCore.Mvc;

namespace HotelProjectNetWebUI.Default
{
    public class _TrailerPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
