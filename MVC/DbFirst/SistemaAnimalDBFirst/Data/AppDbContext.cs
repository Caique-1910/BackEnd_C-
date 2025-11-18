using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SistemaAnimalDBFirst.Models;

namespace SistemaAnimalDBFirst.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TabelaAnimal> TabelaAnimals { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
