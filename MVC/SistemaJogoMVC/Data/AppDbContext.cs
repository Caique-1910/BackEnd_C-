using Microsoft.EntityFrameworkCore;
using SistemaJogoMVC.Models;

namespace SistemaJogoMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet <Personagem> TabelaPersonagem { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>()
            .HasDiscriminator<string>("Tipo")
            .HasValue<Guerreiro>("Guerreiro")
            .HasValue<Mago>("Mago");
        }

    }
}