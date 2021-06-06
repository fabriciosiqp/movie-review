using Microsoft.EntityFrameworkCore;
using MovieReview.Domain.Entities;
using System;

namespace MovieReview.Infra.Seedings
{
    public static class ActorSeeding
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Actor>().HasData(
               new { Id = Guid.Parse("f10ed5dc-6ed2-4c13-9403-df769238ef7c"), Name = "Will Smith", Biography = "é um ator, rapper, produtor cinematográfico, produtor musical e produtor de televisão americano.", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("0585180d-4b05-4a4a-adfb-be571939354f"), Name = "Tom Hanks", Biography = "é um ator e cineasta norte-americano. Destacou-se em diversos filmes de sucesso.", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("f98dc22f-5a0c-4d95-922c-637209140ef1"), Name = "Morgan Freeman", Biography = "é um premiado ator, produtor, narrador e cineasta estadunidense.", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("b76c3b43-f46b-4605-9808-e9ce2c157050"), Name = "Vicent D'Onofrio", Biography = "é um ator estadunidense. Estudou no Actors Studio e no American Stanislavski Theatre.", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("4552b2e8-d777-4526-aaf8-bc8d460a6eeb"), Name = "Jim Carray", Biography = "James Eugene 'Jim' Carrey é um ator, comediante, dublador, roteirista, produtor e pintor canadense.", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                );
        }
    }
}
