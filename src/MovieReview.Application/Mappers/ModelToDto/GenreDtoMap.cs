using AutoMapper;
using MovieReview.Application.Dtos;
using MovieReview.Domain.Entities;

namespace MovieReview.Application.Mappers
{
    public class GenreDtoMap : Profile
    {

        public GenreDtoMap()
        {
            CreateGenreDtoMap();
        }

        private void CreateGenreDtoMap()
        {
            CreateMap<Genre, GenreResponse>()
                .ForMember(m => m.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(m => m.Name, opt => opt.MapFrom(x => x.Name));
        }
    }
}
