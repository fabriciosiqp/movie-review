using MovieReview.Domain.Entities;
using MovieReview.Domain.Interfaces.Repositories;
using MovieReview.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReview.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAllCommon(int pageIndex, int pageSize = 20)
        {
            IQueryable<User> users = _userRepository.GetAllCommon(pageIndex, pageSize);

            return users.OrderBy(x => x.Name).ToList();
        }

        public async Task<User> RegisterAsync(User user)
        {
            await _userRepository.AddAsync(user);

            return user;
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }

        public void Delete(User user)
        {
            _userRepository.Delete(user);
        }

        public int CountCommon()
        {
            IQueryable<User> users = _userRepository.GetAllCommon();

            return users.Count();
        }

        public void Dispose()
        {
            _userRepository?.Dispose();
        }

    }
}
