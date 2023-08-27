namespace Domain.Contracts.Interfaces.Repositories;

public interface IGenericRepository<T> where T : class
{
    public Task<IEnumerable<T>> Get();
    public Task<IEnumerable<T>> Get(int pageNumber = 1, int pageSize = 100);
}
