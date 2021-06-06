using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReview.Domain.Entities;

namespace MovieReview.Infra.Mappings
{
    public class MovieGenreMap : IEntityTypeConfiguration<MovieGenre>
    {
        public void Configure(EntityTypeBuilder<MovieGenre> builder)
        {
            builder.ToTable("MovieGenres");
            builder.HasKey(c => new { c.GenreId, c.MovieId });
        }
    }
}
