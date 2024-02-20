using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProjectNet.BusinessLayer.Abstract;
using HotelProjectNet.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(RoomAddDto roomAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(roomAddDto);
            _roomService.TInsert(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto _updateRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(_updateRoomDto);
            _roomService.TUpdate(values);
            return Ok("Başarıyla Güncellendi");
        }
    }
}
