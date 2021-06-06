using MovieReview.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace MovieReview.Domain.Interfaces.Services
{
    public interface IAccountService : IDisposable
    {
        Task<User> AuthenticateAsync(string email, string senha);
        Task<User> Register(User user);
        Task<bool> EmailExistsAsync(string email);
    }
}
