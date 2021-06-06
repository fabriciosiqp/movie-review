using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReview.Domain.Entities;

namespace MovieReview.Infra.Mappings
{
    public class MovieActorMap : IEntityTypeConfiguration<MovieActor>
    {
        public void Configure(EntityTypeBuilder<MovieActor> builder)
        {
            builder.ToTable("MovieActors");
            builder.HasKey(c => new { c.ActorId, c.MovieId });
        }
    }
}
