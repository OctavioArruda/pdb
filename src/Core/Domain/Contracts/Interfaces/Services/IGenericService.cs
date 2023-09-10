using System.Linq.Expressions;

namespace Domain.Contracts.Interfaces.Services;

public interface IGenericService<T> where T : class
{
    public Task<IEnumerable<T>> GetAsync();
    public Task<IEnumerable<T>> GetAsync(int pageNumber, int PageSize);
    public Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> filter);
    public Task<IEnumerable<IGrouping<TKey, T>>> GetAsync<TKey>(
        Expression<Func<T, TKey>> groupBy);
}
