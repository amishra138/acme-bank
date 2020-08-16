using System.Collections.Generic;

namespace Acme.Account.Core.Models
{
    public class CustomerModel : BaseEntity
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Email { get; private set; }

        public string Mobile { get; private set; }

        public ICollection<AddressModel> Addresses { get; private set; }

        public ICollection<AccountModel> Accounts { get; private set; }

        public CustomerModel(string firstName, string lastName, string email, string mobile)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Mobile = mobile;
            CreatedBy = 1;
            CreatedByUserName = "amishra";
        }

        public void AddAddress(AddressModel address)
        {
            if (Addresses == null)
                Addresses = new List<AddressModel>();

            Addresses.Add(address);
        }

        public void AddAccounts(AccountModel account)
        {
            if (Accounts == null)
                Accounts = new List<AccountModel>();

            Accounts.Add(account);
        }
    }
}
