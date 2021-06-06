﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieReview.Infra.Data;

namespace MovieReview.Infra.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("MovieReview")
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieReview.Domain.Entities.Actor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f10ed5dc-6ed2-4c13-9403-df769238ef7c"),
                            Biography = "é um ator, rapper, produtor cinematográfico, produtor musical e produtor de televisão americano.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Will Smith",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("0585180d-4b05-4a4a-adfb-be571939354f"),
                            Biography = "é um ator e cineasta norte-americano. Destacou-se em diversos filmes de sucesso.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tom Hanks",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("f98dc22f-5a0c-4d95-922c-637209140ef1"),
                            Biography = "é um premiado ator, produtor, narrador e cineasta estadunidense.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Morgan Freeman",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("b76c3b43-f46b-4605-9808-e9ce2c157050"),
                            Biography = "é um ator estadunidense. Estudou no Actors Studio e no American Stanislavski Theatre.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Vicent D'Onofrio",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("4552b2e8-d777-4526-aaf8-bc8d460a6eeb"),
                            Biography = "James Eugene 'Jim' Carrey é um ator, comediante, dublador, roteirista, produtor e pintor canadense.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jim Carray",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MovieReview.Domain.Entities.Director", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ab263d6b-09c1-4c00-ae99-eb8af3198b3c"),
                            Biography = "é uma cineasta italiana. Ele trabalhou seu caminho de fazer curtas-metragens apenas exibidos na televisão italiana para se tornar um cineasta americano bem conhecido e bem-sucedido.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gabriele Muccino",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("83b0fd46-de27-45ca-b02c-bbd5e12717b5"),
                            Biography = "é um cineasta, produtor e roteirista estadunidense. Sua família é de origem lituana e iugoslava.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Robert Zemeckis",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("c43e7cdd-c626-43ac-8b31-337f1a0f855a"),
                            Biography = "é um cineasta, roteirista e produtor de cinema francês radicado nos Estados Unidos. Fez várias adaptações dos livros de Stephen King.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Frank Darabont",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("0ca3fe26-18ea-407b-8cd7-f74aeb60077f"),
                            Biography = "Foi um cineasta, roteirista, produtor e fotógrafo estadunidense. Frequentemente apontado como um dos cineastas mais influentes do cinema",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Stanley Kubrick",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("e9594e43-9c98-4eb4-abc7-5e102341ee47"),
                            Biography = "é um cineasta francês. Dirigiu dois filmes do famoso roteirista Charlie Kaufman, Human Nature e Eternal Sunshine of the Spotless Mind.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Michel Gondry",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MovieReview.Domain.Entities.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dd44e09d-dc35-4a87-adc5-fa44b7fb008c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ação",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("d96d07a1-12dd-4c59-90e3-f3075ea89878"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aventura",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("b1dc71c5-b0a8-49ea-a920-99c3cbd98adf"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Comédia",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("0f9a6dce-96f7-42cc-82f8-933a1b124690"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dança",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("946b1714-58d9-4edb-beb4-4b6d4ca4abc2"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Documentário",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Drama",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("41786d05-a046-43d1-9784-87affb7d89d8"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Faroeste",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("047c52e3-3d9d-4009-8655-62fcac45013b"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Musical",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("ba5b1931-64c2-4eaf-b6cb-4130cd83fd04"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Romance",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("f48ffc93-14b9-400c-976d-6bb0b0439763"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Suspense",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("32425de6-259f-498d-b8df-92d14b11d450"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Terror",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("425f14d5-ebfa-41a1-a8f2-effe37df280c"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Thriller",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MovieReview.Domain.Entities.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AgeClassification")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRelease")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123"),
                            AgeClassification = 0,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRelease = new DateTime(2007, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "Chris enfrenta sérios problemas financeiros e Linda, sua esposa, decide partir. Ele agora é pai solteiro e precisa cuidar de Christopher, seu filho de 5 anos. ",
                            Title = "À Procura da Felicidade",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("7b01ccad-21b0-4d52-9c27-b291813a3e54"),
                            AgeClassification = 14,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRelease = new DateTime(1994, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "Mesmo com o raciocínio lento, Forrest Gump nunca se sentiu desfavorecido. Graças ao apoio da mãe, ele teve uma vida normal.",
                            Title = "Forrest Gump - O Contador de Histórias",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("8cff0471-6d15-4eb6-aebc-a2d43188ce59"),
                            AgeClassification = 16,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRelease = new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "Andy Dufresne é condenado a duas prisões perpétuas consecutivas pelas mortes de sua esposa e de seu amante. ",
                            Title = "Um Sonho de Liberdade",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("445c98ce-7022-4528-8442-c2675183c280"),
                            AgeClassification = 16,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRelease = new DateTime(1987, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "O soldado Davis, batizado de 'Joker' pelo sargento linha-dura Hartman, suporta os rigores do treinamento básico e tenta ajudar o ridicularizado colega Lawrence.",
                            Title = "Nascido para Matar",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("955cc101-848d-4304-855a-f309b104660b"),
                            AgeClassification = 16,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRelease = new DateTime(2004, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Summary = "Joel se surpreende ao saber que seu amor verdadeiro, Clementine, o apagou completamente de sua memória. Ele decide fazer o mesmo, mas muda de ideia.",
                            Title = "Brilho Eterno de uma Mente sem Lembranças",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MovieReview.Domain.Entities.MovieActor", b =>
                {
                    b.Property<Guid>("ActorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieActors");

                    b.HasData(
                        new
                        {
                            ActorId = new Guid("f10ed5dc-6ed2-4c13-9403-df769238ef7c"),
                            MovieId = new Guid("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123")
                        },
                        new
                        {
                            ActorId = new Guid("0585180d-4b05-4a4a-adfb-be571939354f"),
                            MovieId = new Guid("7b01ccad-21b0-4d52-9c27-b291813a3e54")
                        },
                        new
                        {
                            ActorId = new Guid("f98dc22f-5a0c-4d95-922c-637209140ef1"),
                            MovieId = new Guid("8cff0471-6d15-4eb6-aebc-a2d43188ce59")
                        },
                        new
                        {
                            ActorId = new Guid("b76c3b43-f46b-4605-9808-e9ce2c157050"),
                            MovieId = new Guid("445c98ce-7022-4528-8442-c2675183c280")
                        },
                        new
                        {
                            ActorId = new Guid("4552b2e8-d777-4526-aaf8-bc8d460a6eeb"),
                            MovieId = new Guid("955cc101-848d-4304-855a-f309b104660b")
                        });
                });

            modelBuilder.Entity("MovieReview.Domain.Entities.MovieDirector", b =>
                {
                    b.Property<Guid>("DirectorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DirectorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieDirectors");

                    b.HasData(
                        new
                        {
                            DirectorId = new Guid("ab263d6b-09c1-4c00-ae99-eb8af3198b3c"),
                            MovieId = new Guid("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123")
                        },
                        new
                        {
                            DirectorId = new Guid("83b0fd46-de27-45ca-b02c-bbd5e12717b5"),
                            MovieId = new Guid("7b01ccad-21b0-4d52-9c27-b291813a3e54")
                        },
                        new
                        {
                            DirectorId = new Guid("c43e7cdd-c626-43ac-8b31-337f1a0f855a"),
                            MovieId = new Guid("8cff0471-6d15-4eb6-aebc-a2d43188ce59")
                        },
                        new
                        {
                            DirectorId = new Guid("0ca3fe26-18ea-407b-8cd7-f74aeb60077f"),
                            MovieId = new Guid("445c98ce-7022-4528-8442-c2675183c280")
                        },
                        new
                        {
                            DirectorId = new Guid("e9594e43-9c98-4eb4-abc7-5e102341ee47"),
                            MovieId = new Guid("955cc101-848d-4304-855a-f309b104660b")
                        });
                });

            modelBuilder.Entity("MovieReview.Domain.Entities.MovieGenre", b =>
                {
                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GenreId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieGenres");

                    b.HasData(
                        new
                        {
                            GenreId = new Guid("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"),
                            MovieId = new Guid("2dfa3862-7bcf-44c7-a9b1-a5a42ee13123")
                        },
                        new
                        {
                            GenreId = new Guid("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"),
                            MovieId = new Guid("7b01ccad-21b0-4d52-9c27-b291813a3e54")
                        },
                        new
                        {
                            GenreId = new Guid("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"),
                            MovieId = new Guid("8cff0471-6d15-4eb6-aebc-a2d43188ce59")
                        },
                        new
                        {
                            GenreId = new Guid("d31cd4e8-52ba-41f6-983a-9bb2405dc11e"),
                            MovieId = new Guid("445c98ce-7022-4528-8442-c2675183c280")
                        },
                        new
                        {
                            GenreId = new Guid("ba5b1931-64c2-4eaf-b6cb-4130cd83fd04"),
                            MovieId = new Guid("955cc101-848d-4304-855a-f309b104660b")
                        });
                });

            modelBuilder.Entity("MovieReview.Domain.Entities.MovieVote", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("UserId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieVotes");
                });

            modelBuilder.Entity("MovieReview.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<bool>("IsAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dcffe995-f5b4-4806-b96d-8ca6211cfe8e"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@admin.com",
                            Name = "Administrador",
                            Password = "4D693211BCDEF83ED934CB46B2152FB3749CFAA980180A7D13B1246F4E11689F3A4FC925A4B42A32BDADA021481D3E11908DF2EC61A44C03F9CE37F2E724DE47",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MovieReview.Domain.Entities.MovieActor", b =>
                {
                    b.HasOne("MovieReview.Domain.Entities.Actor", "Actor")
                        .WithMany()
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MovieReview.Domain.Entities.Movie", "Movie")
                        .WithMany("Actors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieReview.Domain.Entities.MovieDirector", b =>
                {
                    b.HasOne("MovieReview.Domain.Entities.Director", "Director")
                        .WithMany()
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MovieReview.Domain.Entities.Movie", "Movie")
                        .WithMany("Directors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieReview.Domain.Entities.MovieGenre", b =>
                {
                    b.HasOne("MovieReview.Domain.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MovieReview.Domain.Entities.Movie", "Movie")
                        .WithMany("Genres")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieReview.Domain.Entities.MovieVote", b =>
                {
                    b.HasOne("MovieReview.Domain.Entities.Movie", "Movie")
                        .WithMany("Votes")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MovieReview.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
