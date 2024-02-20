using HotelProject.WebUI.Dtos.ServiceDto;
using AutoMapper;
using HotelProjectNet.EntityLayer.Concrete;
using HotelManager.EntityLayer.Concrete;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile

    {
        public AutoMapperConfig()
        {

            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, AppUser>().ReverseMap();
        }
    }
}
