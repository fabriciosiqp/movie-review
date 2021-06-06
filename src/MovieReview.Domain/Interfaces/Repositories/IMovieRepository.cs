using MovieReview.Core.Data;
using MovieReview.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReview.Domain.Interfaces.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<Movie> GetByIdAsync(Guid id);
        IQueryable<Movie> GetAll(int pageIndex = 1, int pageSize = 20);
        Task<Movie> AddAsync(Movie movie);
        Task AddVoteAsync(MovieVote vote);
    }
}
