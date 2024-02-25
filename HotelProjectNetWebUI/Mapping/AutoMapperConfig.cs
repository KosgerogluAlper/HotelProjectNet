using HotelProject.WebUI.Dtos.ServiceDto;
using AutoMapper;
using HotelProjectNet.EntityLayer.Concrete;
using HotelManager.EntityLayer.Concrete;
using HotelProjectNetWebUI.Dtos.RegisterDto;
using HotelProjectNetWebUI.Dtos.LoginDto;
using HotelProjectNetWebUI.Dtos.AboutDto;

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
            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();


        }
    }
}
