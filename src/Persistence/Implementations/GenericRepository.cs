using System.Linq;
using System.Linq.Expressions;
using Domain.Contracts.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.DatabaseContext;

namespace Persistence.Implementations;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    protected readonly PdbDatabaseContext _context;

    public GenericRepository(PdbDatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> GetAsync()
    {
        var items = await _context.Set<T>().ToListAsync();

        return items;
    }

    public async Task<IEnumerable<T>> GetAsync(int pageNumber = 1, int pageSize = 100)
    {
        return await _context.Set<T>().Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .OrderBy(x => x.Id)
            .ToListAsync();
    }

    public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> filter)
    {
        IQueryable<T> query = _context.Set<T>();

        if (filter != null)
        {
            query = query.Where(filter);
        }

        return await query.ToListAsync();
    }

    public async Task<IEnumerable<IGrouping<TKey, T>>> GetAsync<TKey>(
        Expression<Func<T, TKey>> groupBy)
    {
        IQueryable<T> query = _context.Set<T>();

        return await query.GroupBy(groupBy).ToListAsync();
    }
}
