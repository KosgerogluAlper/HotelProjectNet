using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace RapidApi.Consume.Controllers
{
    public class ImdbController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://movies-tv-shows-database.p.rapidapi.com/?movieid=tt1375666"),
                Headers =
    {
        { "Type", "get-movie-details" },
        { "X-RapidAPI-Key", "98086bef9dmshd3fcd9839994775p1f58e3jsn609defa5d6e4" },
        { "X-RapidAPI-Host", "movies-tv-shows-database.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
            }
            return View();
        }
    }
}
