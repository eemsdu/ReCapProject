using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace WebAPI.Mapper
{
    public class MapProfile:Profile
       
    {
        public MapProfile()
        {
            CreateMap<Car, CarDto>();
            CreateMap<CarDto, Car>();
            CreateMap<Brand, BrandDto>().ReverseMap();


        }
    }
}
