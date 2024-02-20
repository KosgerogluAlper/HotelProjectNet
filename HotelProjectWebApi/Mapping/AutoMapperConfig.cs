using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProjectNet.EntityLayer.Concrete;
namespace HotelProject.Webapi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
