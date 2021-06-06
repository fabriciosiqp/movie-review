using Microsoft.EntityFrameworkCore;
using MovieReview.Domain.Entities;
using MovieReview.Infra.Mappings;
using MovieReview.Infra.Seedings;
using System.Linq;

namespace MovieReview.Infra.Data
{
    public class DataContext : DbContext
    {

        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieVote> MovieVotes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MovieReview");

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.ApplyConfiguration(new MovieMap());
            modelBuilder.ApplyConfiguration(new MovieActorMap());
            modelBuilder.ApplyConfiguration(new MovieDirectorMap());
            modelBuilder.ApplyConfiguration(new MovieGenreMap());
            modelBuilder.ApplyConfiguration(new MovieVoteMap());

            modelBuilder.ApplyConfiguration(new ActorMap());
            modelBuilder.ApplyConfiguration(new DirectorMap());
            modelBuilder.ApplyConfiguration(new GenreMap());
            modelBuilder.ApplyConfiguration(new UserMap());

            GenreSeeding.Seed(modelBuilder);
            DirectorSeeding.Seed(modelBuilder);
            ActorSeeding.Seed(modelBuilder);
            MovieSeeding.Seed(modelBuilder);
            UserSeeding.Seed(modelBuilder);

        }

    }
}
