using AutoMapper;
using TinySocial.DataAccess.Entities;
using TinySocial.Services.DTOs;

namespace TinySocial.Services.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<RegisterDTO, AppUser>();
        }        
    }
}
