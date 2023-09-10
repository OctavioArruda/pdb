using System.Linq.Expressions;
using Domain.Contracts.Interfaces.Repositories;
using Domain.Contracts.Interfaces.Services;

namespace Application.Implementations.Services;

public sealed class GenericService<T> : IGenericService<T> where T : class
{
    private readonly IGenericRepository<T> _repository;

    public GenericService(IGenericRepository<T> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<T>> GetAsync()
    {
        return await _repository.GetAsync();
    }

    public async Task<IEnumerable<T>> GetAsync(int pageNumber, int PageSize)
    {
        return await _repository.GetAsync(pageNumber, PageSize);
    }

    public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> filter)
    {
        return await _repository.GetAsync(filter);
    }

    public async Task<IEnumerable<IGrouping<TKey, T>>> GetAsync<TKey>(
        Expression<Func<T, TKey>> groupBy)
    {
        return await _repository.GetAsync(groupBy);
    }
}
