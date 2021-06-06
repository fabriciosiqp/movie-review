using AutoMapper;
using MovieReview.Application.Dtos;
using MovieReview.Application.Interfaces;
using MovieReview.Core.Data;
using MovieReview.Core.Helpers;
using MovieReview.Domain.Entities;
using MovieReview.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace MovieReview.Application.Services
{
    public class AccountAppService : IAccountAppService
    {

        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public AccountAppService(IAccountService AccountService, IMapper mapper, IUnitOfWork uow)
        {
            _accountService = AccountService;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<AccountResponse> AuthenticateAsync(string email, string password)
        {
            var passwordHash = new Password();

            var account = await _accountService.AuthenticateAsync(email, passwordHash.GenerateHash(password));

            return _mapper.Map<AccountResponse>(account);
        }

        public async Task<AccountResponse> Register(RegisterAccountRequest registerDto)
        {

            var passwordHash = new Password();

            registerDto.Password = passwordHash.GenerateHash(registerDto.Password);

            var user = _mapper.Map<User>(registerDto);

            var account = await _accountService.Register(user);

            await _uow.Commit();

            return _mapper.Map<AccountResponse>(account);

        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _accountService.EmailExistsAsync(email);
        }

        public void Dispose()
        {
            _accountService.Dispose();
        }

    }
}
