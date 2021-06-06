using MovieReview.Domain.Interfaces.Dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieReview.Application.Dtos
{
    public class VoteRequest : IRequest
    {
        [JsonIgnore]
        public Guid UserId { get; set; }

        [Required]
        [JsonIgnore]
        public Guid MovieId { get; set; }

        [Range(0, 4)]
        public int Rating { get; set; }
    }
}
