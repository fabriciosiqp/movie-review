﻿using System;

namespace MovieReview.Domain.Entities
{
    public class MovieGenre
    {

        protected MovieGenre() { }

        public MovieGenre(Guid movieId, Guid genreId)
        {
            MovieId = movieId;
            GenreId = genreId;
        }

        public Guid MovieId { get; private set; }
        public Guid GenreId { get; private set; }

        public Movie Movie { get; private set; }
        public Genre Genre { get; private set; }

    }
}
