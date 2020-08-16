using Acme.Account.Core.Command;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Acme.Account.Core.Extensions
{
    public static class CoreServiceCollectionExtension
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateCustomerRequest).Assembly);
        }
    }
}
