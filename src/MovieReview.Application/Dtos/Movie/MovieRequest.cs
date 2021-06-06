using MovieReview.Domain.Enums;
using MovieReview.Domain.Interfaces.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieReview.Application.Dtos
{
    public class MovieRequest : IRequest
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(300)]
        public string Summary { get; set; }

        [Required]
        [EnumDataType(typeof(EAgeClassification))]
        public EAgeClassification AgeClassification { get; set; }

        [Required]
        public DateTime DateRelease { get; set; }

        public IEnumerable<MovieActorRequest> Actors { get; set; }
        public IEnumerable<MovieDirectorRequest> Directors { get; set; }
        public IEnumerable<MovieGenreRequest> Genres { get; set; }
    }
}
