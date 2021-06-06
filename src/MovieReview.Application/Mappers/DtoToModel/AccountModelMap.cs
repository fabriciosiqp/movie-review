using AutoMapper;
using MovieReview.Application.Dtos;
using MovieReview.Domain.Entities;

namespace MovieReview.Application.Mappers
{
    public class AccountModelMap : Profile
    {

        public AccountModelMap()
        {
            AccountDtoMap();
        }

        private void AccountDtoMap()
        {
            CreateMap<RegisterAccountRequest, User>()
                .ForMember(m => m.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(m => m.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(m => m.IsAdmin, opt => opt.MapFrom(x => false))
                .ForMember(m => m.Password, opt => opt.MapFrom(x => x.Password));
        }
    }
}
