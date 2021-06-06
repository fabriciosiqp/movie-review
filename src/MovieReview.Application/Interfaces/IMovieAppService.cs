using MovieReview.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieReview.Application.Interfaces
{
    public interface IMovieAppService : IDisposable
    {
        Task<MovieResponse> GetByIdAsync(Guid id);
        IEnumerable<MovieResponse> GetAll(int pageIndex, int pageSize = 20, Dictionary<string, object> filters = null);
        Task<MovieResponse> RegisterAsync(MovieRequest createMovieRequest);
        Task VoteAsync(VoteRequest voteDto);
        int Count(Dictionary<string, object> filters = null);
    }
}
