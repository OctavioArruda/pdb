namespace Domain.Contracts.Interfaces.Services;

public interface IGenericService<T> where T : class
{
    public Task<IEnumerable<T>> Get(int pageNumber, int PageSize);
}
