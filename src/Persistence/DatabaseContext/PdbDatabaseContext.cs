﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.DatabaseContext;

public sealed class PdbDatabaseContext : DbContext
{
    public PdbDatabaseContext(DbContextOptions<PdbDatabaseContext> options) : base(options)
    {
    }

    public DbSet<Caged> Cageds { get; set; }
    public DbSet<Cnae> Cnaes { get; set; }
    public DbSet<CodigoMunicipioSiaf> CodigosMunicipioSiaf { get; set; }
    public DbSet<DadosCnaeSecundarioCnpj> DadosCnaeSecundarioCnpj { get; set; }
    public DbSet<DadosSocioCnpj> DadosSociosCnpj { get; set; }
    public DbSet<NaturezaJuridica> NaturezasJuridicas { get; set; }
    public DbSet<DadosCadastraisCnpj> DadosCnpj { get; set; }
        
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=amostra100pc.sqlite");

        base.OnConfiguring(optionsBuilder);
    }
}
