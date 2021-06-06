using MovieReview.Domain.Interfaces.Dto;
using System.ComponentModel.DataAnnotations;

namespace MovieReview.Application.Dtos
{
    public class CreateUserRequest : IRequest
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(32, MinimumLength = 8)]
        public string Password { get; set; }

        public bool IsAdmin { get; set; } = false;
    }
}
