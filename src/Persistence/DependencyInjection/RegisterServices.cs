using Application.Implementations.Services;
using Domain.Contracts.Interfaces.Repositories;
using Domain.Contracts.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.DatabaseContext;
using Persistence.Implementations;

namespace Persistence.DependencyInjection;

public static class RegisterServices
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
    {
        var databasePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "Persistence", "amostra100pc.sqlite");

        services.AddDbContext<PdbDatabaseContext>(options =>
        {
            options.UseSqlite($"Data Source={databasePath}");
        });

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));

        return services;
    }
}
