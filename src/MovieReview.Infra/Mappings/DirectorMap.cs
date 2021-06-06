using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReview.Domain.Entities;

namespace MovieReview.Infra.Mappings
{
    public class DirectorMap : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.ToTable("Directors");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Biography).HasMaxLength(300);
        }
    }
}
