using MovieReview.Domain.Interfaces.Dto;
using System;

namespace MovieReview.Application.Dtos
{
    public class MovieGenreRequest : IRequest
    {
        public Guid Id { get; set; }
    }
}
