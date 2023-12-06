using AutoMapper;

namespace LMS.Services.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.UserRequestModel,Data.Entities.User>().ReverseMap();
        }
    }
}
