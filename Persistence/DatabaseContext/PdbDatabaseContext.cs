using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.DatabaseContext;

public sealed class PdbDatabaseContext : DbContext
{
    public PdbDatabaseContext(DbContextOptions<PdbDatabaseContext> options) : base(options)
    {
    }

    public DbSet<Secao> Secoes { get; set; }
    public DbSet<DadosCnpj> DadosCnpj { get; set; }
}
