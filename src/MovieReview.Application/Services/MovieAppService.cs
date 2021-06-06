using AutoMapper;
using MovieReview.Application.Dtos;
using MovieReview.Application.Interfaces;
using MovieReview.Core.Data;
using MovieReview.Domain.Entities;
using MovieReview.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieReview.Application.Services
{
    public class MovieAppService : IMovieAppService
    {

        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public MovieAppService(IMovieService movieService, IMapper mapper, IUnitOfWork uow)
        {
            _movieService = movieService;
            _mapper = mapper;
            _uow = uow;
        }

        public IEnumerable<MovieResponse> GetAll(int pageIndex, int pageSize = 20, Dictionary<string, object> filters = null)
        {
            var movies = _movieService.GetAll(pageIndex, pageSize, filters);

            return _mapper.Map<IEnumerable<MovieResponse>>(movies);
        }

        public async Task<MovieResponse> GetByIdAsync(Guid id)
        {
            var movie = await _movieService.GetByIdAsync(id);

            return _mapper.Map<MovieResponse>(movie);
        }

        public async Task<MovieResponse> RegisterAsync(MovieRequest createMovieRequest)
        {
            var movie = _mapper.Map<Movie>(createMovieRequest);

            await _movieService.RegisterAsync(movie);

            await _uow.Commit();

            return _mapper.Map<MovieResponse>(movie);
        }

        public async Task VoteAsync(VoteRequest voteDto)
        {
            var vote = _mapper.Map<MovieVote>(voteDto);

            await _movieService.VoteAsync(vote);

            await _uow.Commit();
        }

        public int Count(Dictionary<string, object> filters = null)
        {
            return _movieService.Count(filters);
        }

        public void Dispose()
        {
            _movieService.Dispose();
        }
    }
}
