using Microsoft.EntityFrameworkCore;
using SistemaVeiculoMVC.Models;

namespace SistemaVeiculoMVC.Data
{
    public class AppDbContext : DbContext
    {
              public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet <Veiculo> TabelaVeiculo { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>()
            .HasDiscriminator<string>("Tipo")
            .HasValue<Moto>("Moto")
            .HasValue<Carro>("Carro"); 
        }

    }
}