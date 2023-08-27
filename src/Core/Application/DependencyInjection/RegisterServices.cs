using Application.Implementations.Services;
using Domain.Contracts.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyInjection;

public static class RegisterServices
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ICagedService, CagedService>();

        return services;
    }
}
