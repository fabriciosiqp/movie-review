using AutoMapper;
using MovieReview.Application.Dtos;
using MovieReview.Domain.Entities;

namespace MovieReview.Application.Mappers
{
    public class UpdateUserModelMap : Profile
    {

        public UpdateUserModelMap()
        {
            UserDtoMap();
        }

        private void UserDtoMap()
        {
            CreateMap<UpdateUserRequest, User>()
                .ForMember(m => m.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(m => m.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(m => m.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(m => m.IsAdmin, opt => opt.MapFrom(x => x.IsAdmin))
                .ForMember(m => m.Password, opt => opt.Ignore());
        }
    }
}
