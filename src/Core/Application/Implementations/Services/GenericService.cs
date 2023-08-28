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

    public async Task<IEnumerable<T>> Get(int pageNumber, int PageSize)
    {
        return await _repository.Get(pageNumber, PageSize);
    }
}
