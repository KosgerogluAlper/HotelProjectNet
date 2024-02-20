using HotelProjectNet.BusinessLayer.Abstract;
using HotelProjectNet.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomroom;

        public RoomController(IRoomService roomroom)
        {
            _roomroom = roomroom;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomroom.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Addroom(Room room)
        {
            _roomroom.TInsert(room);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Deleteroom(int id)
        {
            var values = _roomroom.TGetByID(id);
            _roomroom.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult Updateroom(Room room)
        {
            _roomroom.TUpdate(room);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Getroom(int id)
        {
            var values = _roomroom.TGetByID(id);
            return Ok(values);
        }

    }
}
