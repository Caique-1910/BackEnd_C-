using Microsoft.EntityFrameworkCore;
using SistemaFuncionarioMVC.Models;

namespace SistemaFuncionarioMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        //recebe as opcoes de configuracao do banco

        //direciona a classe (Funcionario) para a tabela (TabelaFuncionario)
        public DbSet <Funcionario> TabelaFuncionario { get; set; }

        //sobrescrever o mapeamento do modelo(uma unica tabela para funcionario)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>() //comeca a configurar a entidade base Funcionario
            .HasDiscriminator<string>("Cargo") //cria uma unica tabela diferenciando Gerente e Vendedor por cargo
            .HasValue<Gerente>("Gerente") //quando a instancia for gerente, grava "gerente" em cargo
            .HasValue<Vendedor>("Vendedor"); //quando a instancia for vendedor, grava "vendedor" em cargo
        }
    }
}