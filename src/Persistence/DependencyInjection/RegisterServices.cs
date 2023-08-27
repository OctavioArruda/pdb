using Microsoft.Extensions.DependencyInjection;

namespace Persistence.DependencyInjection;

public static class RegisterServices
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
    {
        return services;
    }
}
