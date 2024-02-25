using Microsoft.AspNetCore.Mvc;

namespace HotelProjectNetWebUI.Default
{
    public class _ReservationPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}