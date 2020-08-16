using Acme.Account.Core.Command.Customer;
using Acme.Account.Core.Interfaces;
using Acme.Account.Core.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Acme.Account.Core.CommandHandler.Customer
{
    public class CreateCustomerRequestHandler : IRequestHandler<CreateCustomerRequest, string>
    {
        private readonly IRepository<CustomerModel> _repository;
        
        public CreateCustomerRequestHandler(IRepository<CustomerModel> repository)
        {
            _repository = repository;
        }

        public async Task<string> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new CustomerModel(request.FirstName, request.LastName, request.Email, request.Mobile));

            return "success";
        }
    }
}
