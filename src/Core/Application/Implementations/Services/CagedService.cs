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

    public async Task<IEnumerable<Caged>> Get()
    {
        return await _cagedRepository.Get();
    }
}
