using SimpleArchitecture.Core.Contracts;
using SimpleArchitecture.Infrastructure.Repositories;

namespace SimpleArchitecture.Api.Extensions
{
    public static class DIRegistrations
    {
        public static IServiceCollection RegisterDependencyInjections(this IServiceCollection services)
        {
            services.AddScoped<IOrderRepository, OrderRepository>();

            return services;
        }
    }
}
