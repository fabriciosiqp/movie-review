using System;

namespace MovieReview.Domain.Entities
{
    public class MovieActor
    {
        protected MovieActor() { }

        public MovieActor(Guid movieId, Guid actorId)
        {
            MovieId = movieId;
            ActorId = actorId;
        }

        public Guid MovieId { get; private set; }
        public Guid ActorId { get; private set; }

        public Movie Movie { get; private set; }
        public Actor Actor { get; private set; }
    }
}
