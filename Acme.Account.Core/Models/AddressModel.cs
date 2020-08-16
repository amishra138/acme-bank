using Acme.Account.Core.Enums;

namespace Acme.Account.Core.Models
{
    public class AddressModel : BaseEntity
    {
        public CustomerModel Customer { get; private set; }

        public int CustomerId { get; private set; }
        public AddressType Type { get; private set; }

        public string Address1 { get; private set; }

        public string Address2 { get; private set; }

        public string State { get; private set; }

        public string Country { get; private set; }

        public string Pincode { get; private set; }

        public AddressModel(AddressType type, string address1, string address2, string state, string country, string pincode)
        {
            Type = type;
            Address1 = address1;
            Address2 = address2;
            State = state;
            Country = country;
            Pincode = pincode;
        }
    }
}
