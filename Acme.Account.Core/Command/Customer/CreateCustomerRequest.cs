using MediatR;

namespace Acme.Account.Core.Command.Customer
{
    public class CreateCustomerRequest : IRequest<string>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }
    }
}
