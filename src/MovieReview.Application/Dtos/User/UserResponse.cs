using MovieReview.Domain.Interfaces.Dto;
using System;

namespace MovieReview.Application.Dtos
{
    public class UserResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
    }
}
