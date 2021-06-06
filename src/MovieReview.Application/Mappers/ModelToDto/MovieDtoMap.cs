using AutoMapper;
using MovieReview.Application.Dtos;
using MovieReview.Domain.Entities;
using System.Linq;

namespace MovieReview.Application.Mappers
{
    public class MovieDtoMap : Profile
    {

        public MovieDtoMap()
        {
            CreateMovieDtoMap();
        }

        private void CreateMovieDtoMap()
        {
            CreateMap<Movie, MovieResponse>()
                .ForMember(m => m.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(m => m.Title, opt => opt.MapFrom(x => x.Title))
                .ForMember(m => m.Summary, opt => opt.MapFrom(x => x.Summary))
                .ForMember(m => m.AgeClassification, opt => opt.MapFrom(x => x.AgeClassification))
                .ForMember(m => m.DateRelease, opt => opt.MapFrom(x => x.DateRelease))
                .ForMember(m => m.AverageRating, opt => opt.MapFrom(x => x.AverageRating))
                .ForMember(m => m.Actors, opt => opt.MapFrom(x => x.Actors.Select(c => c.Actor)))
                .ForMember(m => m.Directors, opt => opt.MapFrom(x => x.Directors.Select(c => c.Director)))
                .ForMember(m => m.Genres, opt => opt.MapFrom(x => x.Genres.Select(c => c.Genre)));

        }
    }
}
