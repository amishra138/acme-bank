using Acme.Account.Core.Enums;
using System.Collections.Generic;

namespace Acme.Account.Core.Models
{
    public class AccountModel : BaseEntity
    {
        public AccountModel(AccountType type, string number, float minBalance)
        {
            Type = type;
            Number = number;
            MinBalance = minBalance;
            Transactions = new List<TransactionModel>();
        }

        public void LockAccount()
        {
            IsLocked = true;
        }

        public void AddTransaction(TransactionModel transaction)
        {
            if (Transactions == null)
                Transactions = new List<TransactionModel>();

            Transactions.Add(transaction);
        }

        public CustomerModel Customer { get; private set; }

        public int CustomerId { get; private set; }

        public AccountType Type { get; private set; }

        public string Number { get; private set; }

        public float MinBalance { get; private set; }

        public bool IsLocked { get; private set; }

        public IList<TransactionModel> Transactions { get; private set; }

    }
}
