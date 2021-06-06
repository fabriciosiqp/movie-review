using AutoMapper;
using MovieReview.Application.Dtos;
using MovieReview.Domain.Entities;

namespace MovieReview.Application.Mappers
{
    public class CreateMovieModelMap : Profile
    {
        public CreateMovieModelMap()
        {
            MovieMap();
        }

        private void MovieMap()
        {
            CreateMap<MovieRequest, Movie>()
                .ForMember(m => m.Title, opt => opt.MapFrom(x => x.Title))
                .ForMember(m => m.Summary, opt => opt.MapFrom(x => x.Summary))
                .ForMember(m => m.AgeClassification, opt => opt.MapFrom(x => x.AgeClassification))
                .ForMember(m => m.DateRelease, opt => opt.MapFrom(x => x.DateRelease))
                .ForMember(m => m.AverageRating, opt => opt.Ignore())
                .ForMember(m => m.Actors, opt => opt.MapFrom(x => x.Actors))
                .ForMember(m => m.Directors, opt => opt.MapFrom(x => x.Directors))
                .ForMember(m => m.Genres, opt => opt.MapFrom(x => x.Genres))
                .ForMember(m => m.CreatedAt, opt => opt.Ignore())
                .ForMember(m => m.UpdatedAt, opt => opt.Ignore())
                .ForMember(m => m.DeletedAt, opt => opt.Ignore());

        }
    }
}
