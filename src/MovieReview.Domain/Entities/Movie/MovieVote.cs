using System;

namespace MovieReview.Domain.Entities
{
    public class MovieVote
    {
        protected MovieVote() { }

        public MovieVote(int rating, Guid userId, Guid movieId)
        {
            int minRating = 0;
            int maxRating = 4;

            Rating = rating < minRating ? minRating : rating > maxRating ? maxRating : rating;
            UserId = userId;
            MovieId = movieId;
        }

        public int Rating { get; private set; }
        public Guid MovieId { get; private set; }
        public Guid UserId { get; private set; }

        public Movie Movie { get; private set; }
        public User User { get; private set; }


    }
}
