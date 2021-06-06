using AutoMapper;
using MovieReview.Application.Dtos;
using MovieReview.Application.Interfaces;
using MovieReview.Core.Data;
using MovieReview.Core.Helpers;
using MovieReview.Domain.Entities;
using MovieReview.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieReview.Application.Services
{
    public class UserAppService : IUserAppService
    {

        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UserAppService(IUserService UserService, IMapper mapper, IUnitOfWork uow)
        {
            _userService = UserService;
            _mapper = mapper;
            _uow = uow;
        }

        public IEnumerable<UserResponse> GetAllCommon(int pageIndex, int pageSize = 20)
        {

            var users = _userService.GetAllCommon(pageIndex, pageSize);

            return _mapper.Map<IEnumerable<UserResponse>>(users);
        }

        public async Task<UserResponse> RegisterAsync(CreateUserRequest createUserRequest)
        {
            var passwordHash = new Password();

            createUserRequest.Password = passwordHash.GenerateHash(createUserRequest.Password);

            var user = _mapper.Map<User>(createUserRequest);

            await _userService.RegisterAsync(user);

            await _uow.Commit();

            return _mapper.Map<UserResponse>(user);
        }

        public async Task UpdateAsync(UpdateUserRequest updateUserRequest)
        {
            var user = _mapper.Map<User>(updateUserRequest);

            _userService.Update(user);

            await _uow.Commit();
        }

        public async Task DeleteAsync(Guid id)
        {
            var user = _mapper.Map<User>(id);

            _userService.Delete(user);

            await _uow.Commit();
        }

        public int CountCommon()
        {
            return _userService.CountCommon();
        }

        public void Dispose()
        {
            _userService.Dispose();
        }

    }
}
