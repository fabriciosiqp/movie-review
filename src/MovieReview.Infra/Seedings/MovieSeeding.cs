using Microsoft.EntityFrameworkCore;
using MovieReview.Domain.Entities;
using MovieReview.Domain.Enums;
using System;

namespace MovieReview.Infra.Seedings
{
    public static class MovieSeeding
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Movie>().HasData(
             new { Id = Guid.Parse("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123"), Title = "À Procura da Felicidade", DateRelease = new DateTime(2007, 2, 2), Summary = "Chris enfrenta sérios problemas financeiros e Linda, sua esposa, decide partir. Ele agora é pai solteiro e precisa cuidar de Christopher, seu filho de 5 anos. ", AgeClassification = EAgeClassification.FREE, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
             new { Id = Guid.Parse("7b01ccad-21b0-4d52-9c27-b291813a3e54"), Title = "Forrest Gump - O Contador de Histórias", DateRelease = new DateTime(1994, 12, 7), Summary = "Mesmo com o raciocínio lento, Forrest Gump nunca se sentiu desfavorecido. Graças ao apoio da mãe, ele teve uma vida normal.", AgeClassification = EAgeClassification.FOURTEEN, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
             new { Id = Guid.Parse("8cff0471-6d15-4eb6-aebc-a2d43188ce59"), Title = "Um Sonho de Liberdade", DateRelease = new DateTime(1995, 3, 17), Summary = "Andy Dufresne é condenado a duas prisões perpétuas consecutivas pelas mortes de sua esposa e de seu amante. ", AgeClassification = EAgeClassification.SIXTEEN, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
             new { Id = Guid.Parse("445c98ce-7022-4528-8442-c2675183c280"), Title = "Nascido para Matar", DateRelease = new DateTime(1987, 10, 16), Summary = "O soldado Davis, batizado de 'Joker' pelo sargento linha-dura Hartman, suporta os rigores do treinamento básico e tenta ajudar o ridicularizado colega Lawrence.", AgeClassification = EAgeClassification.SIXTEEN, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
             new { Id = Guid.Parse("955cc101-848d-4304-855a-f309b104660b"), Title = "Brilho Eterno de uma Mente sem Lembranças", DateRelease = new DateTime(2004, 7, 23), Summary = "Joel se surpreende ao saber que seu amor verdadeiro, Clementine, o apagou completamente de sua memória. Ele decide fazer o mesmo, mas muda de ideia.", AgeClassification = EAgeClassification.SIXTEEN, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
              );

            builder.Entity<MovieActor>().HasData(
               new { MovieId = Guid.Parse("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123"), ActorId = Guid.Parse("f10ed5dc-6ed2-4c13-9403-df769238ef7c") },
               new { MovieId = Guid.Parse("7b01ccad-21b0-4d52-9c27-b291813a3e54"), ActorId = Guid.Parse("0585180d-4b05-4a4a-adfb-be571939354f") },
               new { MovieId = Guid.Parse("8cff0471-6d15-4eb6-aebc-a2d43188ce59"), ActorId = Guid.Parse("f98dc22f-5a0c-4d95-922c-637209140ef1") },
               new { MovieId = Guid.Parse("445c98ce-7022-4528-8442-c2675183c280"), ActorId = Guid.Parse("b76c3b43-f46b-4605-9808-e9ce2c157050") },
               new { MovieId = Guid.Parse("955cc101-848d-4304-855a-f309b104660b"), ActorId = Guid.Parse("4552b2e8-d777-4526-aaf8-bc8d460a6eeb") }
                );

            builder.Entity<MovieDirector>().HasData(
               new { MovieId = Guid.Parse("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123"), DirectorId = Guid.Parse("ab263d6b-09c1-4c00-ae99-eb8af3198b3c") },
               new { MovieId = Guid.Parse("7b01ccad-21b0-4d52-9c27-b291813a3e54"), DirectorId = Guid.Parse("83b0fd46-de27-45ca-b02c-bbd5e12717b5") },
               new { MovieId = Guid.Parse("8cff0471-6d15-4eb6-aebc-a2d43188ce59"), DirectorId = Guid.Parse("c43e7cdd-c626-43ac-8b31-337f1a0f855a") },
               new { MovieId = Guid.Parse("445c98ce-7022-4528-8442-c2675183c280"), DirectorId = Guid.Parse("0ca3fe26-18ea-407b-8cd7-f74aeb60077f") },
               new { MovieId = Guid.Parse("955cc101-848d-4304-855a-f309b104660b"), DirectorId = Guid.Parse("e9594e43-9c98-4eb4-abc7-5e102341ee47") }
                );

            builder.Entity<MovieGenre>().HasData(
               new { MovieId = Guid.Parse("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123"), GenreId = Guid.Parse("d31cd4e8-52ba-41f6-983a-9bb2405dc11e") },
               new { MovieId = Guid.Parse("7b01ccad-21b0-4d52-9c27-b291813a3e54"), GenreId = Guid.Parse("d31cd4e8-52ba-41f6-983a-9bb2405dc11e") },
               new { MovieId = Guid.Parse("8cff0471-6d15-4eb6-aebc-a2d43188ce59"), GenreId = Guid.Parse("d31cd4e8-52ba-41f6-983a-9bb2405dc11e") },
               new { MovieId = Guid.Parse("445c98ce-7022-4528-8442-c2675183c280"), GenreId = Guid.Parse("d31cd4e8-52ba-41f6-983a-9bb2405dc11e") },
               new { MovieId = Guid.Parse("955cc101-848d-4304-855a-f309b104660b"), GenreId = Guid.Parse("ba5b1931-64c2-4eaf-b6cb-4130cd83fd04") }
                );
        }
    }
}
