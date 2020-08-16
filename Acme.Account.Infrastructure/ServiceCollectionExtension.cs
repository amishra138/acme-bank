using Acme.Account.Core.Interfaces;
using Acme.Account.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Acme.Account.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfraServices(this IServiceCollection services)
        {
            services.AddScoped<AcmeContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
