using MovieReview.Domain.Enums;
using MovieReview.Domain.Interfaces.Dto;
using System;
using System.Collections.Generic;

namespace MovieReview.Application.Dtos
{
    public class MovieResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public EAgeClassification AgeClassification { get; set; }
        public DateTime DateRelease { get; set; }
        public decimal AverageRating { get; set; }

        public IEnumerable<ActorResponse> Actors { get; set; }
        public IEnumerable<DirectorResponse> Directors { get; set; }
        public IEnumerable<GenreResponse> Genres { get; set; }
    }
}
