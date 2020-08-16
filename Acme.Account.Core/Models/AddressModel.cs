using Acme.Account.Core.Enums;

namespace Acme.Account.Core.Models
{
    public class AddressModel : BaseEntity
    {
        public CustomerModel Customer { get; set; }

        public int CustomerId { get; set; }
        public AddressType Type { get; set; }
    }
}
