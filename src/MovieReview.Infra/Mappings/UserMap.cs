using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReview.Domain.Entities;

namespace MovieReview.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(255).IsRequired();
            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.Password).HasMaxLength(128).IsRequired();
            builder.Property(x => x.IsAdmin).HasDefaultValue(0);
        }
    }
}
