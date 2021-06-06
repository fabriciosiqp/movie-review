using MovieReview.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieReview.Domain.Interfaces.Services
{
    public interface IUserService : IDisposable
    {
        IEnumerable<User> GetAllCommon(int pageIndex, int pageSize = 20);
        Task<User> RegisterAsync(User Movie);
        void Update(User Movie);
        void Delete(User Movie);
        int CountCommon();
    }
}
