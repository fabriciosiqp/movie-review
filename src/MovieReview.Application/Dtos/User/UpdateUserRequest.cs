using MovieReview.Domain.Interfaces.Dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieReview.Application.Dtos
{
    public class UpdateUserRequest : IRequest
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public bool IsAdmin { get; set; } = false;
    }
}
