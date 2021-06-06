using MovieReview.Domain.Interfaces.Dto;
using System;

namespace MovieReview.Application.Dtos
{
    public class MovieDirectorRequest : IRequest
    {
        public Guid Id { get; set; }
    }
}
