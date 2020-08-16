using Acme.Account.Core.Command.Customer;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Acme.Account.Core.CommandHandler.Customer
{
    public class DeleteCustomerRequestHandler : IRequestHandler<DeleteCustomerRequest, string>
    {
        public Task<string> Handle(DeleteCustomerRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
