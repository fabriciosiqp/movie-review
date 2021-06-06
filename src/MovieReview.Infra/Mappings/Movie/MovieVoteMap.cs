using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReview.Domain.Entities;

namespace MovieReview.Infra.Mappings
{
    public class MovieVoteMap : IEntityTypeConfiguration<MovieVote>
    {
        public void Configure(EntityTypeBuilder<MovieVote> builder)
        {
            builder.ToTable("MovieVotes");
            builder.HasKey(c => new { c.UserId, c.MovieId });
            builder.Property(x => x.Rating).IsRequired();
        }
    }
}
