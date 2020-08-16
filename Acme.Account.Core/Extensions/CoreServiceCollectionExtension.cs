using Acme.Account.Core.Command.Customer;
using Acme.Account.Core.Queries.Customer;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Acme.Account.Core.Extensions
{
    public static class CoreServiceCollectionExtension
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateCustomerRequest).Assembly);
            services.AddScoped<ICustomerQuery, CustomerQuery>();
        }
    }
}
