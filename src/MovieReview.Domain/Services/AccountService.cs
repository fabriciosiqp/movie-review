using MovieReview.Domain.Entities;
using MovieReview.Domain.Interfaces.Repositories;
using MovieReview.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace MovieReview.Domain.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository AccountRepository)
        {
            _accountRepository = AccountRepository;
        }

        public async Task<User> AuthenticateAsync(string email, string senha)
        {
            return await _accountRepository.AuthenticateAsync(email, senha);
        }

        public async Task<User> Register(User user)
        {
            return await _accountRepository.Register(user);
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _accountRepository.EmailExistsAsync(email);
        }

        public void Dispose()
        {
            _accountRepository?.Dispose();
        }

    }
}
