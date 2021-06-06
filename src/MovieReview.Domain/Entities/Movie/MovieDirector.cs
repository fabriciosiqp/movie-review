using System;

namespace MovieReview.Domain.Entities
{
    public class MovieDirector
    {
        protected MovieDirector() { }

        public MovieDirector(Guid movieId, Guid directorId)
        {
            MovieId = movieId;
            DirectorId = directorId;
        }

        public Guid MovieId { get; private set; }
        public Guid DirectorId { get; private set; }

        public Movie Movie { get; private set; }
        public Director Director { get; private set; }

    }
}
