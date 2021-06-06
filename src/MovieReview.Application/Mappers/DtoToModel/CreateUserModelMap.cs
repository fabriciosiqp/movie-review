using AutoMapper;
using MovieReview.Application.Dtos;
using MovieReview.Domain.Entities;

namespace MovieReview.Application.Mappers
{
    public class CreateUserModelMap : Profile
    {

        public CreateUserModelMap()
        {
            UserDtoMap();
        }

        private void UserDtoMap()
        {
            CreateMap<CreateUserRequest, User>()
                .ForMember(m => m.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(m => m.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(m => m.IsAdmin, opt => opt.MapFrom(x => x.IsAdmin))
                .ForMember(m => m.Password, opt => opt.MapFrom(x => x.Password));
        }
    }
}
