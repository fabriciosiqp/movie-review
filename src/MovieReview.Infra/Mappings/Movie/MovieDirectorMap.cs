using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReview.Domain.Entities;

namespace MovieReview.Infra.Mappings
{
    public class MovieDirectorMap : IEntityTypeConfiguration<MovieDirector>
    {
        public void Configure(EntityTypeBuilder<MovieDirector> builder)
        {
            builder.ToTable("MovieDirectors");
            builder.HasKey(c => new { c.DirectorId, c.MovieId });
        }
    }
}
