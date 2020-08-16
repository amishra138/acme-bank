using Acme.Account.Core.Enums;

namespace Acme.Account.Core.Models
{
    public class TransactionModel : BaseEntity
    {
        public AccountModel Account { get; set; }

        public int AccountId { get; set; }

        public float Amount { get; set; }

        public string Remarks { get; set; }

        public TransactionType Type { get; set; }
    }
}
