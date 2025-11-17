
using Microsoft.EntityFrameworkCore;
using SistemaAnimalMVC.Models;

namespace SistemaAnimalMVC.Data
{
    public class AppDbContext : DbContext
    {
              public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet <Animal> TabelaAnimal { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
            .HasDiscriminator<string>("Nome")
            .HasValue<Leao>("Leao")
            .HasValue<Elefante>("Elefante"); 
        }

    }
}