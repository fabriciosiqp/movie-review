using AutoMapper;
using MovieReview.Application.Dtos;
using MovieReview.Domain.Entities;

namespace MovieReview.Application.Mappers
{
    public class DirectorDtoMap : Profile
    {

        public DirectorDtoMap()
        {
            CreateDirectorDtoMap();
        }

        private void CreateDirectorDtoMap()
        {
            CreateMap<Director, DirectorResponse>()
                .ForMember(m => m.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(m => m.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(m => m.Biography, opt => opt.MapFrom(x => x.Biography));
        }
    }
}
