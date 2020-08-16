using System.Collections.Generic;

namespace Acme.Account.Core.Models
{
    public class CustomerModel : BaseEntity
    {
        public CustomerModel()
        {
            Addresses = new List<AddressModel>();
            Accounts = new List<AccountModel>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public ICollection<AddressModel> Addresses { get; set; }

        public ICollection<AccountModel> Accounts { get; set; }
    }
}
