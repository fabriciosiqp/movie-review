using AutoMapper;
using MovieReview.Application.Dtos;
using MovieReview.Domain.Entities;

namespace MovieReview.Application.Mappers
{
    public class ActorDtoMap : Profile
    {

        public ActorDtoMap()
        {
            CreateActorDtoMap();
        }

        private void CreateActorDtoMap()
        {
            CreateMap<Actor, ActorResponse>()
                .ForMember(m => m.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(m => m.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(m => m.Biography, opt => opt.MapFrom(x => x.Biography));
        }
    }
}
