using MovieReview.Domain.Entities;
using MovieReview.Domain.Interfaces.Repositories;
using MovieReview.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReview.Domain.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IEnumerable<Movie> GetAll(int pageIndex, int pageSize = 20, Dictionary<string, object> filters = null)
        {

            IQueryable<Movie> movies = _movieRepository.GetAll(pageIndex, pageSize);

            if (filters != null)
            {
                if (filters.ContainsKey("Title"))
                {
                    movies = movies.Where(x => x.Title.Contains(filters["Title"].ToString()));
                }

                if (filters.ContainsKey("Director"))
                {
                    movies = movies.Where(x => x.Directors.Any(d => d.Director.Name.Contains(filters["Director"].ToString())));
                }

                if (filters.ContainsKey("Genre"))
                {
                    movies = movies.Where(x => x.Genres.Any(d => d.Genre.Name.Contains(filters["Genre"].ToString())));
                }

                if (filters.ContainsKey("Actor"))
                {
                    movies = movies.Where(x => x.Actors.Any(d => d.Actor.Name.Contains(filters["Actor"].ToString())));
                }
            }

            return movies.OrderByDescending(x => x.Votes.Select(v => v.Rating).Average()).ThenBy(x => x.Title).ToList();
        }

        public async Task<Movie> GetByIdAsync(Guid id)
        {
            return await _movieRepository.GetByIdAsync(id);
        }

        public async Task<Movie> RegisterAsync(Movie movie)
        {
            await _movieRepository.AddAsync(movie);

            return movie;
        }

        public async Task VoteAsync(MovieVote vote)
        {
            await _movieRepository.AddVoteAsync(vote);
        }

        public int Count(Dictionary<string, object> filters = null)
        {

            IQueryable<Movie> movies = _movieRepository.GetAll();

            if (filters != null)
            {
                if (filters.ContainsKey("Title"))
                {
                    movies = movies.Where(x => x.Title.Contains(filters["Title"].ToString()));
                }

                if (filters.ContainsKey("Director"))
                {
                    movies = movies.Where(x => x.Directors.Any(d => d.Director.Name.Contains(filters["Director"].ToString())));
                }

                if (filters.ContainsKey("Genre"))
                {
                    movies = movies.Where(x => x.Genres.Any(d => d.Genre.Name.Contains(filters["Genre"].ToString())));
                }

                if (filters.ContainsKey("Actor"))
                {
                    movies = movies.Where(x => x.Actors.Any(d => d.Actor.Name.Contains(filters["Actor"].ToString())));
                }
            }
            return movies.Count();
        }

        public void Dispose()
        {
            _movieRepository?.Dispose();
        }

    }
}
