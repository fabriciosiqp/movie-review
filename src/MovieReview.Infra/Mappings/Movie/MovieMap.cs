using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReview.Domain.Entities;

namespace MovieReview.Infra.Mappings
{
    public class MovieMap : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movies");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Summary).HasMaxLength(300).IsRequired();
            builder.Property(x => x.AgeClassification).IsRequired();
            builder.Property(x => x.DateRelease).IsRequired();

        }
    }
}
