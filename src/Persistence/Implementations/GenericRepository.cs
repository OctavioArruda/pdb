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
        var items = await _context.Set<T>().ToListAsync();

        return items;
    }

    public async Task<IEnumerable<T>> Get(int pageNumber = 1, int pageSize = 100)
    {
        return await _context.Set<T>().Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}
