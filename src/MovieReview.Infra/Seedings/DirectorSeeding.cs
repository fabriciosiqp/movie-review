using Microsoft.EntityFrameworkCore;
using MovieReview.Domain.Entities;
using System;

namespace MovieReview.Infra.Seedings
{
    public static class DirectorSeeding
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Director>().HasData(
               new { Id = Guid.Parse("ab263d6b-09c1-4c00-ae99-eb8af3198b3c"), Name = "Gabriele Muccino", Biography = "é uma cineasta italiana. Ele trabalhou seu caminho de fazer curtas-metragens apenas exibidos na televisão italiana para se tornar um cineasta americano bem conhecido e bem-sucedido.", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("83b0fd46-de27-45ca-b02c-bbd5e12717b5"), Name = "Robert Zemeckis", Biography = "é um cineasta, produtor e roteirista estadunidense. Sua família é de origem lituana e iugoslava.", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("c43e7cdd-c626-43ac-8b31-337f1a0f855a"), Name = "Frank Darabont", Biography = "é um cineasta, roteirista e produtor de cinema francês radicado nos Estados Unidos. Fez várias adaptações dos livros de Stephen King.", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("0ca3fe26-18ea-407b-8cd7-f74aeb60077f"), Name = "Stanley Kubrick", Biography = "Foi um cineasta, roteirista, produtor e fotógrafo estadunidense. Frequentemente apontado como um dos cineastas mais influentes do cinema", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
               new { Id = Guid.Parse("e9594e43-9c98-4eb4-abc7-5e102341ee47"), Name = "Michel Gondry", Biography = "é um cineasta francês. Dirigiu dois filmes do famoso roteirista Charlie Kaufman, Human Nature e Eternal Sunshine of the Spotless Mind.", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                );
        }
    }
}
