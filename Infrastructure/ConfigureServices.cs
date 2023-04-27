
using Application.QueriesAbstruction.Queries;
using Infrastructure.Queries;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ConfigureServices
    {

        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configurtion)
        {

            services.AddScoped<ITodoQueries, TodoQueries>();
            return services;
        }
    }
}
