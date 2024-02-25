using Microsoft.AspNetCore.Mvc;

namespace HotelProjectNetWebUI.Default
{
    public class _ScriptsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
