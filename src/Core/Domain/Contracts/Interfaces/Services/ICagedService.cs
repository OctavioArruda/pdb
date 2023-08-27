using Domain.Entities;

namespace Domain.Contracts.Interfaces.Services;

public interface ICagedService
{
    public Task<IEnumerable<Caged>> Get();
}
