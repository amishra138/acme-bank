using Acme.Account.Core.Command.Customer;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Acme.Account.Core.CommandHandler.Customer
{
    public class UpdateCustomerRequestHandler : IRequestHandler<UpdateCustomerRequest, string>
    {
        public Task<string> Handle(UpdateCustomerRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
