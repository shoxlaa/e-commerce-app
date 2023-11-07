using e_commerce_app.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_app.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movies>().HasKey(am => new { am.ActorId, am.MovieId});    
            
            modelBuilder.Entity<Actor_Movies>().HasOne(m=>m.Movie).WithMany(am=> am.Actor_Movies).HasForeignKey(am=>am.MovieId);
            modelBuilder.Entity<Actor_Movies>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(am => am.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set;}
        public DbSet<Movie> Movies { get; set;}
        public DbSet<Cinema> Cinemas { get; set;}
        public DbSet<Producer> Producers { get; set;}
    }
}
