using Microsoft.EntityFrameworkCore;
using MovieReview.Core.Helpers;
using MovieReview.Domain.Entities;
using System;

namespace MovieReview.Infra.Seedings
{
    public static class UserSeeding
    {
        public static void Seed(ModelBuilder builder)
        {
            var passwordHash = new Password();

            builder.Entity<User>().HasData(
               new { Id = Guid.Parse("dcffe995-f5b4-4806-b96d-8ca6211cfe8e"), Name = "Administrador", Email = "admin@admin.com", Password = passwordHash.GenerateHash("Km&tgUTw"), IsAdmin = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                );
        }
    }
}
