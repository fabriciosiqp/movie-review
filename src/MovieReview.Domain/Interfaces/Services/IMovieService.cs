using MovieReview.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieReview.Domain.Interfaces.Services
{
    public interface IMovieService : IDisposable
    {
        Task<Movie> GetByIdAsync(Guid id);
        IEnumerable<Movie> GetAll(int pageIndex, int pageSize = 20, Dictionary<string, object> filters = null);
        Task<Movie> RegisterAsync(Movie movie);
        Task VoteAsync(MovieVote vote);
        int Count(Dictionary<string, object> filters = null);
    }
}
