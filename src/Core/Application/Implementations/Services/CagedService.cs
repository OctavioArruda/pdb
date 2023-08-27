using Domain.Contracts.Interfaces.Repositories;
using Domain.Contracts.Interfaces.Services;
using Domain.Entities;

namespace Application.Implementations.Services;

public sealed  class CagedService : ICagedService
{
    private readonly IGenericRepository<Caged> _cagedRepository;

    public CagedService(IGenericRepository<Caged> cagedRepository)
    {
        _cagedRepository = cagedRepository;
    }

    public async Task<IEnumerable<Caged>> Get(int pageNumber = 1, int pageSize = 100)
    {
        return  await _cagedRepository.Get(pageNumber, pageSize);
    }
}
