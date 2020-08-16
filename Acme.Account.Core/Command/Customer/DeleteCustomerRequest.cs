using MediatR;

namespace Acme.Account.Core.Command.Customer
{
    public class DeleteCustomerRequest : IRequest<string>
    {
        public int Id { get; private set; }

        public DeleteCustomerRequest(int id)
        {
            Id = id;
        }
    }
}
