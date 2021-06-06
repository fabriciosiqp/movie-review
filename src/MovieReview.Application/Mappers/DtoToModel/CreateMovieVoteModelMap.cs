using AutoMapper;
using MovieReview.Application.Dtos;
using MovieReview.Domain.Entities;

namespace MovieReview.Application.Mappers
{
    public class CreateMovieVoteModelMap : Profile
    {
        public CreateMovieVoteModelMap()
        {
            MovieVoteDtoMap();
        }

        private void MovieVoteDtoMap()
        {
            CreateMap<VoteRequest, MovieVote>()
                .ForMember(m => m.MovieId, opt => opt.MapFrom(x => x.MovieId))
                .ForMember(m => m.UserId, opt => opt.MapFrom(x => x.UserId))
                .ForMember(m => m.Rating, opt => opt.MapFrom(x => x.Rating));
        }
    }
}
