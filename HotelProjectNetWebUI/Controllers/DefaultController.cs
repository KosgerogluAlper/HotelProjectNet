using Microsoft.AspNetCore.Mvc;

namespace HotelProjectNetWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {


            return View();


        }
    }
}
