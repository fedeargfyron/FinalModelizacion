using Domain.Interfaces.Services;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Domain;

public static class ConfigureServices
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddScoped<IQueueService, QueueService>();
        return services;
    }
}