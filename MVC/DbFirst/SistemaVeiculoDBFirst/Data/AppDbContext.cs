using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SistemaVeiculoDBFirst.Models;

namespace SistemaVeiculoDBFirst.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TabelaVeiculo> TabelaVeiculos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TabelaVeiculo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TabelaFuncionario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
