using AutoMapper;
using MovieReview.Application.Dtos;

namespace MovieReview.Application.Mappers
{
    public class CreateMovieGenreModelMap : Profile
    {
        public CreateMovieGenreModelMap()
        {
            MovieGenreDtoMap();
        }

        private void MovieGenreDtoMap()
        {
            CreateMap<MovieGenreRequest, Domain.Entities.MovieGenre>()
                .ForMember(m => m.GenreId, opt => opt.MapFrom(x => x.Id));
        }
    }
}
