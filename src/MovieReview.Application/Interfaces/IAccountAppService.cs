using MovieReview.Application.Dtos;
using System;
using System.Threading.Tasks;

namespace MovieReview.Application.Interfaces
{
    public interface IAccountAppService : IDisposable
    {
        Task<AccountResponse> AuthenticateAsync(string email, string senha);
        Task<AccountResponse> Register(RegisterAccountRequest accountDto);
        Task<bool> EmailExistsAsync(string email);
    }
}
