using Acme.Account.Core.Enums;
using MediatR;
using System.Collections.Generic;

namespace Acme.Account.Core.Command.Customer
{
    public class CreateCustomerRequest : IRequest<string>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public List<Address> Addresses { get; set; }
        
    }

    public class Address
    {
        public AddressType Type { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Pincode { get; set; }
    }
}
