using MovieReview.Core.Data;
using MovieReview.Domain.Entities;
using System.Threading.Tasks;

namespace MovieReview.Domain.Interfaces.Repositories
{
    public interface IAccountRepository : IRepository<User>
    {
        Task<User> AuthenticateAsync(string email, string password);
        Task<User> Register(User user);
        Task<bool> EmailExistsAsync(string email);
    }
}
