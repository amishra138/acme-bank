using Acme.Account.Core.Command.Customer;
using Acme.Account.Core.Events.Customer;
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
        private readonly IMediator _mediator;

        public CreateCustomerRequestHandler(IRepository<CustomerModel> repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        public async Task<string> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var customer = new CustomerModel(request.FirstName, request.LastName, request.Email, request.Mobile);

                request.Addresses?.ForEach(x => customer.AddAddress(new AddressModel(x.Type, x.Address1, x.Address2, x.State, x.Country, x.Pincode)));

                var result = await _repository.CreateAsync(customer);

                await _mediator.Publish(new CustomerCreatedEvent(result)).ConfigureAwait(false);

                return "success";
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
