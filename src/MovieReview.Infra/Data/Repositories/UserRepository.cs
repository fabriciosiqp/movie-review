using Microsoft.EntityFrameworkCore;
using MovieReview.Domain.Entities;
using MovieReview.Domain.Interfaces.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReview.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await _context.Users.Where(x => x.Id == id).FirstOrDefaultAsync();

        }

        public IQueryable<User> GetAllCommon(int pageIndex, int pageSize = 20)
        {
            return _context.Users
                         .AsNoTracking()
                         .Where(x => !x.IsAdmin && x.DeletedAt == null)
                         .Skip((pageIndex - 1) * pageSize)
                         .Take(pageSize);
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
        }

        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.Entry(user).Property(x => x.CreatedAt).IsModified = false;
            _context.Entry(user).Property(x => x.Password).IsModified = false;
        }

        public void Delete(User user)
        {
            user.Disable();

            _context.Users.Attach(user);
            _context.Entry(user).Property(x => x.DeletedAt).IsModified = true;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
