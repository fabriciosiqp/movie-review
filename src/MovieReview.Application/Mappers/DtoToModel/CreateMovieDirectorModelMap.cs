using AutoMapper;
using MovieReview.Application.Dtos;
using MovieReview.Domain.Entities;

namespace MovieReview.Application.Mappers
{
    public class CreateMovieDirectorModelMap : Profile
    {
        public CreateMovieDirectorModelMap()
        {
            MovieDirectorDtoMap();
        }

        private void MovieDirectorDtoMap()
        {
            CreateMap<MovieDirectorRequest, MovieDirector>()
                .ForMember(m => m.DirectorId, opt => opt.MapFrom(x => x.Id));
        }
    }
}
