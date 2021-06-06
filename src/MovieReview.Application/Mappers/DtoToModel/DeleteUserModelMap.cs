using AutoMapper;
using MovieReview.Domain.Entities;
using System;

namespace MovieReview.Application.Mappers
{
    public class DeleteUserModelMap : Profile
    {

        public DeleteUserModelMap()
        {
            UserDtoMap();
        }

        private void UserDtoMap()
        {
            CreateMap<Guid, User>()
                .ForMember(m => m.Id, opt => opt.MapFrom(x => x));
        }
    }
}
