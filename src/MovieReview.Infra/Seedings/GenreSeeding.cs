using Microsoft.EntityFrameworkCore;
using MovieReview.Domain.Entities;
using System;

namespace MovieReview.Infra.Seedings
{
    public static class GenreSeeding
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Genre>().HasData(
               new { Id = Guid.Parse("dd44e09d-dc35-4a87-adc5-fa44b7fb008c"), Name = "Ação", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("d96d07a1-12dd-4c59-90e3-f3075ea89878"), Name = "Aventura", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("b1dc71c5-b0a8-49ea-a920-99c3cbd98adf"), Name = "Comédia", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("0f9a6dce-96f7-42cc-82f8-933a1b124690"), Name = "Dança", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("946b1714-58d9-4edb-beb4-4b6d4ca4abc2"), Name = "Documentário", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"), Name = "Drama", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("41786d05-a046-43d1-9784-87affb7d89d8"), Name = "Faroeste", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("047c52e3-3d9d-4009-8655-62fcac45013b"), Name = "Musical", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("ba5b1931-64c2-4eaf-b6cb-4130cd83fd04"), Name = "Romance", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("f48ffc93-14b9-400c-976d-6bb0b0439763"), Name = "Suspense", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("32425de6-259f-498d-b8df-92d14b11d450"), Name = "Terror", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("425f14d5-ebfa-41a1-a8f2-effe37df280c"), Name = "Thriller", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                );
        }
    }
}
