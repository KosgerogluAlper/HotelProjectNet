using Microsoft.AspNetCore.Mvc;

namespace HotelProjectNetWebUI.ViewComponents.Default
{
    public class _ReservationPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}