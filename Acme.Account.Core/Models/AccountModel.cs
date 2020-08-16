using Acme.Account.Core.Enums;
using System.Collections.Generic;

namespace Acme.Account.Core.Models
{
    public class AccountModel : BaseEntity
    {
        public AccountModel()
        {
            Transactions = new List<TransactionModel>();
        }
        public CustomerModel Customer { get; set; }

        public int CustomerId { get; set; }

        public AccountType Type { get; set; }

        public string Number { get; set; }

        public float MinBalance { get; set; }

        public bool IsLocked { get; set; }

        public IList<TransactionModel> Transactions { get; set; }
    }
}
