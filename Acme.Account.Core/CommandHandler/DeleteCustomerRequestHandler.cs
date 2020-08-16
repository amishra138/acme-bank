using Acme.Account.Core.Command;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Acme.Account.Core.CommandHandler
{
    public class DeleteCustomerRequestHandler : IRequestHandler<DeleteCustomerRequest, string>
    {
        public Task<string> Handle(DeleteCustomerRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
