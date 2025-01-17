using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Cinema.Models.DataBaseModels;
using Microsoft.Extensions.Configuration;

namespace Cinema.Data
{
    public class CinemaContext : IdentityDbContext

    {
        private readonly IConfiguration _configuration;
        public CinemaContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Halls> Halls { get; set; }
        public DbSet<Sessions> Sessions { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Sales_statistics> Sales_statistics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<HelpRequest>()
        //        .HasOne(g => g.People)
        //        .WithMany()
        //        .HasForeignKey(g => g.PeopleId);

        //    modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
        //    modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
        //    modelBuilder.Entity< IdentityUserToken<string>>().HasNoKey();
        //}
    }
}