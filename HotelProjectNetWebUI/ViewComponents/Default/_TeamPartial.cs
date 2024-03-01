using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProjectNetWebUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProjectNetWebUI.ViewComponents.Default
{
    public class _TeamPartial : ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        private string link = " http://localhost:5062/api/Staff";

        public _TeamPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync(link);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultStaffDto>>(jsonData);
                return View(values);
            }

            return View();
        }

    }


}
