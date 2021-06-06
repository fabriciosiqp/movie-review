using MovieReview.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieReview.Application.Interfaces
{
    public interface IUserAppService : IDisposable
    {
        IEnumerable<UserResponse> GetAllCommon(int pageIndex, int pageSize = 20);
        Task<UserResponse> RegisterAsync(CreateUserRequest createUserRequest);
        Task UpdateAsync(UpdateUserRequest updateUserRequest);
        Task DeleteAsync(Guid id);
        int CountCommon();
    }
}
