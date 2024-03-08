﻿
using HotelProjectNet.BusinessLayer.Abstract;
using HotelProjectNet.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult subscribeList()
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }


        [HttpPost]
        public IActionResult Addsubscribe(Subscribe subscribe)
        {
            _subscribeService.TInsert(subscribe);
            return Ok();
        }


        [HttpDelete]
        public IActionResult Deletesubscribe(int id)
        {
            var values = _subscribeService.TGetByID(id);
            _subscribeService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult Updatesubscribe(Subscribe subscribe)
        {
            _subscribeService.TUpdate(subscribe);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Getsubscribe(int id)
        {
            var values = _subscribeService.TGetByID(id);
            return Ok(values);
        }


    }
}
