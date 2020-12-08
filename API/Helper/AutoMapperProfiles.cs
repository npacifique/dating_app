using System.Linq;
using API.DTO;
using API.Entities;
using AutoMapper;

namespace API.Helper
{
    public class AutoMapperProfiles : Profile
    {
        //create AutoMapper Profiles
        public AutoMapperProfiles()
        {
            //add profiles for AutoMapper
            CreateMap<AppUser , MemberDto>()
                .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => 
                    src.Photos.FirstOrDefault(X => X.IsMain).Url));
            CreateMap<Photo, PhotoDto>();
        }
    }
}