using Microsoft.EntityFrameworkCore;
using MovieReview.Domain.Entities;
using MovieReview.Domain.Interfaces.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReview.Infra.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _context;

        public AccountRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<User> AuthenticateAsync(string email, string password)
        {
            return await _context.Users.Where(x => x.Email == email && x.Password == password && x.DeletedAt == null).FirstOrDefaultAsync();
        }

        public async Task<User> Register(User user)
        {
            await _context.Users.AddAsync(user);

            return user;
        }
        public Task<bool> EmailExistsAsync(string email)
        {
            return _context.Users.Where(x => x.Email == email).AnyAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
