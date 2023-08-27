using Domain.Contracts.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.DatabaseContext;

namespace Persistence.Implementations;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly PdbDatabaseContext _context;

    public GenericRepository(PdbDatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> Get()
    {
        return await _context.Set<T>().ToListAsync();
    }
}
