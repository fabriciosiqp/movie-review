using Microsoft.EntityFrameworkCore;
using MovieReview.Domain.Entities;
using MovieReview.Domain.Interfaces.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReview.Infra.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;

        public MovieRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Movie> GetByIdAsync(Guid id)
        {
            return await _context.Movies
                              .Where(x => x.Id == id)
                              .Include(x => x.Actors).ThenInclude(x => x.Actor)
                              .Include(x => x.Directors).ThenInclude(x => x.Director)
                              .Include(x => x.Genres).ThenInclude(x => x.Genre)
                              .Include(x => x.Votes)
                              .FirstOrDefaultAsync();
        }

        public IQueryable<Movie> GetAll(int pageIndex = 1, int pageSize = 20)
        {
            return _context.Movies
                        .AsNoTracking()
                        .Where(x => x.DeletedAt == null)
                        .Include(x => x.Votes)
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize);
        }

        public async Task<Movie> AddAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);

            return movie;
        }

        public async Task AddVoteAsync(MovieVote vote)
        {
            var voteExists = await _context.MovieVotes
                                        .Where(x => x.MovieId == vote.MovieId && x.UserId == vote.UserId)
                                        .AnyAsync();

            if (voteExists)
            {
                _context.MovieVotes.Attach(vote);
                _context.Entry(vote).Property(x => x.Rating).IsModified = true;
            }
            else
            {
                await _context.MovieVotes.AddAsync(vote);
            }
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
