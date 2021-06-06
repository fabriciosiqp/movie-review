using MovieReview.Core.Data;
using MovieReview.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReview.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByIdAsync(Guid id);
        IQueryable<User> GetAllCommon(int pageIndex = 1, int pageSize = 20);
        Task AddAsync(User user);
        void Update(User user);
        void Delete(User user);
    }
}
