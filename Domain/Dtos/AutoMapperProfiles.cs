using AutoMapper;
using Domain.Models;

namespace Domain.Dtos
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserForRegisterDto, User>();
            // .ForMember(woak => woak.CityId, opt => {
            //     opt.MapFrom(put => repo.Cities.FirstOrDefault(x => x.CityName == put.CityName));
            // });
            CreateMap<User, UserForDetailedDto>().ForMember(des => des.CityName, opt => {
                opt.MapFrom(woak => woak.City.CityName);
            });
        }
    }
}