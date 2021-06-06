using MovieReview.Core.DomainObjects;
using MovieReview.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieReview.Domain.Entities
{
    public class Movie : Entity
    {
        protected Movie()
        {
            Votes = new List<MovieVote>();
        }

        public Movie(string title, string summary, EAgeClassification ageClassification, DateTime dateRelease)
        {
            Title = title;
            Summary = summary;
            AgeClassification = ageClassification;
            DateRelease = dateRelease;
        }

        public string Title { get; private set; }
        public string Summary { get; private set; }
        public EAgeClassification AgeClassification { get; private set; }
        public DateTime DateRelease { get; private set; }

        public ICollection<MovieActor> Actors { get; private set; }
        public ICollection<MovieDirector> Directors { get; private set; }
        public ICollection<MovieGenre> Genres { get; private set; }
        public ICollection<MovieVote> Votes { get; private set; }


        public int TotalVotes()
        {
            return Votes.Count();
        }

        public decimal AverageRating
        {
            get
            {
                if (TotalVotes() == 0) return 0;

                return Votes.Select(x => (decimal)x.Rating).Average();
            }
        }

        public void Disable()
        {
            DeletedAt = DateTime.UtcNow;
        }
    }
}
