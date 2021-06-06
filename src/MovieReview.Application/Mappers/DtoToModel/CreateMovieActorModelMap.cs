using AutoMapper;
using MovieReview.Application.Dtos;
using MovieReview.Domain.Entities;

namespace MovieReview.Application.Mappers
{
    public class CreateMovieActorModelMap : Profile
    {
        public CreateMovieActorModelMap()
        {
            MovieActorDtoMap();
        }

        private void MovieActorDtoMap()
        {
            CreateMap<MovieActorRequest, MovieActor>()
                .ForMember(m => m.ActorId, opt => opt.MapFrom(x => x.Id));
        }
    }
}
