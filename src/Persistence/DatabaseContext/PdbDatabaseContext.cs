using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.DatabaseContext;

public sealed class PdbDatabaseContext : DbContext
{
    public PdbDatabaseContext()
    {
        
    }

    public PdbDatabaseContext(DbContextOptions<PdbDatabaseContext> options) : base(options)
    {
    }

    public DbSet<Caged> Caged { get; set; }
    public DbSet<DadosCadastraisCnpj> DadosCnpj { get; set; }
    public DbSet<DadosCnaeSecundarioCnpj> DadosCnaeSecundarioCnpj { get; set; }
    public DbSet<DadosSocioCnpj> DadosSociosCnpj { get; set; }
    public DbSet<Cnae> Cnaes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}
