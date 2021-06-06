using MovieReview.Domain.Interfaces.Dto;
using System;

namespace MovieReview.Application.Dtos
{
    public class ActorResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
    }
}
